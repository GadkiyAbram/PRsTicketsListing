using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using PRsTicketsListing.components;
using PRsTicketsListing.consts;
using PRsTicketsListing.database;
using PRsTicketsListing.models;

namespace PRsTicketsListing
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DatabaseInitializer.InitDatabase();
            this.loadData();
            ticketsDataTable.CellFormatting += this.boolTypeCellFormatter;
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
                ticketsDataTable.Columns[e.ColumnIndex].Name == "merged" ||
                ticketsDataTable.Columns[e.ColumnIndex].Name == "devDeployed" ||
                ticketsDataTable.Columns[e.ColumnIndex].Name == "uatDeployed" ||
                ticketsDataTable.Columns[e.ColumnIndex].Name == "clientNotified"
                )
            {
                if (e.Value is bool boolValue)
                {
                    e.Value = boolValue ? "YES" : "NO";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
