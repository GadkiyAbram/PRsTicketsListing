using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRsTicketsListing.models
{
    internal class Ticket
    {
        public int Id { get; set; }
        public string CreatedAt { get; set; }
        public string JiraTicketNumber { get; set; }
        public string JiraTicketLink { get; set; }
        public string GithubLink { get; set; }
        public string Title { get; set; }
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string TargetBranch { get; set; }
        public bool Merged { get; set; }
        public bool DevDeployed { get; set; }
        public bool UatDeployed { get; set; }
        public bool ClientNotified { get; set; }
        public string Comment { get; set; }
    }
}
