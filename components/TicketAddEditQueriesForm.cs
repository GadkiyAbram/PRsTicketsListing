using System;
using System.Data.SQLite;
using System.Windows.Forms;
using PRsTicketsListing.consts;
using PRsTicketsListing.database;

namespace PRsTicketsListing.components
{
    public partial class TicketAddEditQueriesForm : Form
    {
        private string ticketNumber;
        private models.Query query;

        public TicketAddEditQueriesForm(string ticketNumber)
        {
            InitializeComponent();
            this.ticketNumber = ticketNumber;

            this.setFormTitle();
        }

        private void setFormTitle()
        {
            this.Text = $"Add New Query {this.ticketNumber}";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.closeQueryAddEditForm();
        }

        private void closeQueryAddEditForm()
        {
            this.Close();
        }

        private void btnAddQuery_Click(object sender, EventArgs e)
        {
            using (var connection = DatabaseInitializer.GetConnection())
            {
                connection.Open();
                
                this.insertQuery(connection);

                connection.Close();
            }
        }

        private models.Query createQueryInstance()
        {
            return new models.Query
            {
                TicketNumber = this.ticketNumber,
                QueryContent = this.queryContent.Text,
                Description = this.description.Text
            };
        }

        private void insertQuery(SQLiteConnection connection)
        {
            this.query = this.createQueryInstance();

            using (var command = new SQLiteCommand(Queries.INSERT_TICKET_QUERY, connection))
            {
                command.Parameters.AddWithValue(QueryDBFields.TICKET_NUMBER, this.ticketNumber);
                command.Parameters.AddWithValue(QueryDBFields.DESCRIPTION, this.query.Description);
                command.Parameters.AddWithValue(QueryDBFields.QUERY, this.query.QueryContent);

                int rowsInserted = command.ExecuteNonQuery();

                if (rowsInserted > 0)
                {
                    this.closeQueryAddEditForm();
                }
            }
        }
    }
}
