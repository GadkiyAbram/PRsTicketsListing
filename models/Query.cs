using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRsTicketsListing.models
{
    internal class Query
    {
        public int Id { get; set; }
        public string TicketNumber { get; set; }
        public string Description { get; set; }
        public string QueryContent { get; set; }
    }
}
