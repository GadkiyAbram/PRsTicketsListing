using PRsTicketsListing.consts;
using PRsTicketsListing.database;
using System.Collections.Generic;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace PRsTicketsListing.components
{
    public partial class TicketDetailsForm : Form
    {
        private int? recordId;
        private bool? edit;
        private string now;
        private List<models.Project> projects;
        private models.Ticket ticket;

        public TicketDetailsForm(int? recordId = null)
        {
            InitializeComponent();
            this.checkBoxQueries.CheckedChanged += btnQueries_CheckedChange;
            this.jiraNumberInput.TextChanged += jiraNumberInput_TextChanged;

            this.initializeProjectNamesCombobox();

            if (recordId.HasValue)
            {
                this.recordId = recordId;
                this.edit = true;
                this.btnInsertDetails.Text = "Update";

                this.LoadRecordData();
            }
            else
            {
                this.now = DateTime.Now.ToString(consts.Datetime.DD_MM_YYY_FORMAT);

                this.createdAtInput.Text = this.now;
                this.createdAtInput.Enabled = false;
            }
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            this.closeTicketDetailsForm();
        }

        private void setFormTitle(string ticketNumber)
        {
            this.Text = $"Update {ticketNumber}";
        }

        private void btnInsertEditTicket_Click(object sender, EventArgs e)
        {
            using (var connection = DatabaseInitializer.GetConnection())
            {
                connection.Open();

                if (this.edit == true)
                {
                    this.updateTicket(connection);
                }
                else
                {
                    this.insertTicket(connection);
                }

                connection.Close();
            }
        }

        private void updateTicket(SQLiteConnection connection)
        {
            this.ticket = this.CreateThisTicketInstance(false);

            using (var command = new SQLiteCommand(Queries.UPDATE_TICKET, connection))
            {
                this.AddParametersToCommand(command, true);

                int rowsUpdated = command.ExecuteNonQuery();

                if (rowsUpdated > 0)
                {
                    this.closeTicketDetailsForm();
                }
                else
                {
                    MessageBox.Show($"Update failed for {this.ticket.JiraTicketNumber}");
                }
            }
        }

        private void insertTicket(SQLiteConnection connection)
        {
            this.ticket = this.CreateThisTicketInstance(true);

            using (var command = new SQLiteCommand(Queries.INSERT_TICKET, connection))
            {
                this.AddParametersToCommand(command);

                int rowsInserted = command.ExecuteNonQuery();

                if (rowsInserted > 0)
                {
                    closeTicketDetailsForm();
                }
                else
                {
                    MessageBox.Show($"Insert failed for {ticket.JiraTicketNumber}");
                }
            }
        }

        private void LoadRecordData()
        {
            using (var connection = DatabaseInitializer.GetConnection())
            {
                connection.Open();

                using (var command = new SQLiteCommand(Queries.SELECT_RECORD, connection))
                {
                    command.Parameters.AddWithValue("@recordId", this.recordId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            this.createdAtInput.Text = reader[TicketDBFields.CREATED_AT].ToString();
                            this.jiraNumberInput.Text = reader[TicketDBFields.JIRA_NUMBER].ToString();
                            this.jiraTicketLinkInput.Text = reader[TicketDBFields.JIRA_LINK].ToString();
                            this.githubLinkInput.Text = reader[TicketDBFields.GITHUB_LINK].ToString();
                            this.titleInput.Text = reader[TicketDBFields.TITLE].ToString();
                            this.projectNameInput.SelectedValue = Convert.ToInt32(reader[TicketDBFields.PROJECT_ID]);
                            this.targetBranchInput.Text = reader[TicketDBFields.TARGET_BRANCH].ToString();
                            this.checkBoxMerged.Checked = Convert.ToBoolean(reader[TicketDBFields.MERGED]);
                            this.checkBoxDevDeployed.Checked = Convert.ToBoolean(reader[TicketDBFields.DEV_DEPLOYED]);
                            this.checkBoxUatDeployed.Checked = Convert.ToBoolean(reader[TicketDBFields.UAT_DEPLOYED]);
                            this.checkBoxClientNotified.Checked = Convert.ToBoolean(reader[TicketDBFields.CLIENT_NOTIFIED]);
                            this.checkBoxQueries.Checked = Convert.ToBoolean(reader[TicketDBFields.QUERIES]);
                            this.commentInput.Text = reader[TicketDBFields.COMMENT].ToString();
                        }

                        this.ticket = this.CreateThisTicketInstance();

                        this.setFormTitle(this.jiraNumberInput.Text);
                    }

                    connection.Close();
                }
            }
        }
        private models.Ticket CreateThisTicketInstance(bool newTicket = false) 
        { 
            string createdAt = newTicket ? this.now : this.createdAtInput.Text;

            return new models.Ticket 
            { 
                CreatedAt = createdAt,
                JiraTicketNumber = this.jiraNumberInput.Text,
                JiraTicketLink = this.jiraTicketLinkInput.Text,
                GithubLink = this.githubLinkInput.Text,
                Title = titleInput.Text,
                ProjectId = (int) this.projectNameInput.SelectedValue,
                TargetBranch = this.targetBranchInput.Text,
                Merged = this.checkBoxMerged.Checked,
                DevDeployed = this.checkBoxDevDeployed.Checked,
                UatDeployed = this.checkBoxUatDeployed.Checked,
                ClientNotified = this.checkBoxClientNotified.Checked,
                Queries = this.checkBoxQueries.Checked,
                Comment = this.commentInput.Text
            };
        }

        private void AddParametersToCommand(SQLiteCommand command, bool withId = false)
        {
            var ticketFieldsPrepared = consts.TicketDBFields.GetTicketDbFieldsMapped(true);

            if (withId)
            {
                command.Parameters.AddWithValue(ticketFieldsPrepared[consts.TicketDBFields.ID], this.recordId);
            }

            command.Parameters.AddWithValue(ticketFieldsPrepared[consts.TicketDBFields.CREATED_AT], this.ticket.CreatedAt);
            command.Parameters.AddWithValue(ticketFieldsPrepared[consts.TicketDBFields.JIRA_NUMBER], this.ticket.JiraTicketNumber);
            command.Parameters.AddWithValue(ticketFieldsPrepared[consts.TicketDBFields.JIRA_LINK], this.ticket.JiraTicketLink);
            command.Parameters.AddWithValue(ticketFieldsPrepared[consts.TicketDBFields.GITHUB_LINK], this.ticket.GithubLink);
            command.Parameters.AddWithValue(ticketFieldsPrepared[consts.TicketDBFields.TITLE], this.ticket.Title);
            command.Parameters.AddWithValue(ticketFieldsPrepared[consts.TicketDBFields.PROJECT_ID], this.ticket.ProjectId);
            command.Parameters.AddWithValue(ticketFieldsPrepared[consts.TicketDBFields.TARGET_BRANCH], this.ticket.TargetBranch);
            command.Parameters.AddWithValue(ticketFieldsPrepared[consts.TicketDBFields.MERGED], this.ticket.Merged);
            command.Parameters.AddWithValue(ticketFieldsPrepared[consts.TicketDBFields.DEV_DEPLOYED], this.ticket.DevDeployed);
            command.Parameters.AddWithValue(ticketFieldsPrepared[consts.TicketDBFields.UAT_DEPLOYED], this.ticket.UatDeployed);
            command.Parameters.AddWithValue(ticketFieldsPrepared[consts.TicketDBFields.CLIENT_NOTIFIED], this.ticket.ClientNotified);
            command.Parameters.AddWithValue(ticketFieldsPrepared[consts.TicketDBFields.QUERIES], this.ticket.Queries);
            command.Parameters.AddWithValue(ticketFieldsPrepared[consts.TicketDBFields.COMMENT], this.ticket.Comment);
        }

        private void initializeProjectNamesCombobox()
        {
            this.projects = repositories.Project.LoadProjects();

            this.projectNameInput.DataSource = this.projects;
            this.projectNameInput.DisplayMember = ProjectFields.NAME;
            this.projectNameInput.ValueMember = ProjectFields.ID;
        }

        private void closeTicketDetailsForm()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnQueries_CheckedChange(object sender, EventArgs e)
        {
            this.btnShowQueries.Enabled = 
                this.checkBoxQueries.Checked && 
                (
                    this.jiraNumberInput.Text != "" || 
                    this.ticket != null
                );
        }

        private void jiraNumberInput_TextChanged(object sender, EventArgs e)
        {
            string ticketNumber = this.jiraNumberInput.Text;
            
            if (ticketNumber.Contains("MP-"))
            {
                this.jiraTicketLinkInput.Text = $"https://markertrax.atlassian.net/browse/{ticketNumber}"; 
            }
            else
            {
                this.jiraTicketLinkInput.Text = "";
            }
        }

        private void showTicketQueries_Click(object sender, EventArgs e)
        {
            string ticketNumber = "";

            if (this.ticket != null)
            {
                ticketNumber = this.ticket.JiraTicketNumber;
            }
            else if (this.jiraNumberInput.Text != "")
            {
                ticketNumber = this.jiraNumberInput.Text;
            }

            var queriesForm = new TicketQueriesForm(ticketNumber);
            queriesForm.ShowDialog();
        }
    }
}