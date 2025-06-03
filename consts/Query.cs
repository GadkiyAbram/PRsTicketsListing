using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRsTicketsListing.consts
{
    public static class QueryFields
    { 
        public const string ID = "Id";
        public const string TICKET_NUMBER = "TicketNumber";
        public const string DESCRIPTION = "Description";
        public const string QUERY_CONTENT = "QueryContent";
    }

    public static class QueryDBFields
    {
        public const string ID = "id";
        public const string TICKET_NUMBER = "ticket_number";
        public const string DESCRIPTION = "description";
        public const string QUERY = "query";
    }
}
