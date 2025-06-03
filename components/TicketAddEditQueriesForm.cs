using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRsTicketsListing.components
{
    public partial class TicketAddEditQueriesForm : Form
    {
        private string ticketNumber;

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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddQuery_Click(object sender, EventArgs e)
        {

        }
    }
}
