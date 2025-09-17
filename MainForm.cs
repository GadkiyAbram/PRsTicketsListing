using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PRsTicketsListing.components;
using PRsTicketsListing.consts;
using PRsTicketsListing.database;

namespace PRsTicketsListing
{
    public partial class MainForm : Form
    {
        private ContextMenuStrip cellMenu;
        public MainForm()
        {
            InitializeComponent();
            DatabaseInitializer.InitDatabase();
            this.loadData();
            ticketsDataTable.CellFormatting += this.boolTypeCellFormatter;

            cellMenu = new ContextMenuStrip();

            cellMenu.Items.Add("Queries", null, (s, e) => { MessageBox.Show("Queries clicked"); });

            ticketsDataTable.CellMouseClick += ticketsDataTable_CellMouseClick;
        }

        private void showAddNewRecord_Click(object sender, EventArgs e)
        {
            var addNewRecordForm = new TicketDetailsForm();
            var result = addNewRecordForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.loadData();
            }
        }

        private void showRecord_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int recordId = Convert.ToInt32(
                ticketsDataTable
                .Rows[e.RowIndex]
                .Cells[consts.Forms.Ticket.RECORD_ID]
                .Value);

            var recordForm = new TicketDetailsForm(recordId);
            recordForm.ShowDialog();
        }

        private void loadData()
        {
            ticketsDataTable.Columns["id"].DataPropertyName = TicketFields.ID;
            ticketsDataTable.Columns["createdAt"].DataPropertyName = TicketFields.CREATED_AT;
            ticketsDataTable.Columns["jiraTicketNumber"].DataPropertyName = TicketFields.JIRA_NUMBER;
            ticketsDataTable.Columns["jiraTicketLink"].DataPropertyName = TicketFields.JIRA_LINK;
            ticketsDataTable.Columns["githubLink"].DataPropertyName = TicketFields.GITHUB_LINK;
            ticketsDataTable.Columns["title"].DataPropertyName = TicketFields.TITLE;
            ticketsDataTable.Columns["projectName"].DataPropertyName = ProjectFields.NAME;
            ticketsDataTable.Columns["targetBranch"].DataPropertyName = TicketFields.TARGET_BRANCH;
            ticketsDataTable.Columns["merged"].DataPropertyName = TicketFields.MERGED;
            ticketsDataTable.Columns["devDeployed"].DataPropertyName = TicketFields.DEV_DEPLOYED;
            ticketsDataTable.Columns["uatDeployed"].DataPropertyName = TicketFields.UAT_DEPLOYED;
            ticketsDataTable.Columns["clientNotified"].DataPropertyName = TicketFields.CLIENT_NOTIFIED;
            ticketsDataTable.Columns["queries"].DataPropertyName = TicketFields.QUERIES;
            ticketsDataTable.Columns["comment"].DataPropertyName = TicketFields.COMMENT;

            List<models.Ticket> tickets = repositories.Ticket.LoadTickets();

            ticketsDataTable.DataSource = tickets;
        }

        private void btnGetTicketsData_Click(object sender, EventArgs e)
        {
            this.loadData();
        }

        private void boolTypeCellFormatter(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (
                TicketFields
                .ticketBoolFields
                .Contains(ticketsDataTable.Columns[e.ColumnIndex].Name)
                )
            {
                if (e.Value is bool boolValue)
                {
                    e.Value = boolValue ? Common.YES : Common.NO;
                    e.FormattingApplied = true;
                }
            }
        }

        private void ticketsDataTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0) {
                ticketsDataTable.ClearSelection();
                ticketsDataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;

                cellMenu.Show(Cursor.Position);
            }
        }
    }
}
