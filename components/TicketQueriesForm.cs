using PRsTicketsListing.consts;
using PRsTicketsListing.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRsTicketsListing.components
{
    public partial class TicketQueriesForm : Form
    {
        private string jiraTicketNumber;

        public TicketQueriesForm(string jiraTicketNumber = "")
        {
            InitializeComponent();

            if (jiraTicketNumber != "")
            {
                this.jiraTicketNumber = jiraTicketNumber;
                this.setFormTitle();

                this.loadTicketQueries();
            }
        }

        private void setFormTitle()
        {
            this.Text = $"Queries {this.jiraTicketNumber}";
        }

        private void loadTicketQueries() {
            ticketQueriesTable.Columns["id"].DataPropertyName = QueryFields.ID;
            ticketQueriesTable.Columns["description"].DataPropertyName = QueryFields.DESCRIPTION;
            ticketQueriesTable.Columns["query"].DataPropertyName = QueryFields.QUERY_CONTENT;

            List<models.Query> queries = repositories.Query.loadQueries(this.jiraTicketNumber);

            ticketQueriesTable.DataSource = queries;
        }

        private void btnShowAddEditQuery_Click(object sender, EventArgs e)
        {
            var ticketQueryDialog = new TicketAddEditQueriesForm(this.jiraTicketNumber);

            ticketQueryDialog.ShowDialog();
        }
    }
}
