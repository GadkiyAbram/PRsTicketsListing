using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRsTicketsListing.consts
{
    public static class TicketFields
    {
        public const string ID = "Id";
        public const string CREATED_AT = "CreatedAt";
        public const string JIRA_NUMBER = "JiraTicketNumber";
        public const string JIRA_LINK = "JiraTicketLink";
        public const string GITHUB_LINK = "GithubLink";
        public const string TITLE = "Title";
        public const string PROJECT_ID = "ProjectName";
        public const string TARGET_BRANCH = "TargetBranch";
        public const string MERGED = "Merged";
        public const string DEV_DEPLOYED = "DevDeployed";
        public const string UAT_DEPLOYED = "UatDeployed";
        public const string CLIENT_NOTIFIED = "ClientNotified";
        public const string QUERIES = "Queries";
        public const string COMMENT = "Comment";

        public static string[] ticketBoolFields = new string[]
        {
            "merged",
            "devDeployed",
            "uatDeployed",
            "clientNotified",
            "queries"
        };
    }

    public static class TicketDBFields
    {
        public const string ID = "id";
        public const string CREATED_AT = "created_at";
        public const string JIRA_NUMBER = "jira_number";
        public const string JIRA_LINK = "jira_link";
        public const string GITHUB_LINK = "github_link";
        public const string TITLE = "title";
        public const string PROJECT_ID = "project_id";
        public const string TARGET_BRANCH = "target_branch";
        public const string MERGED = "merged";
        public const string DEV_DEPLOYED = "dev_depl";
        public const string UAT_DEPLOYED = "uat_depl";
        public const string CLIENT_NOTIFIED = "client_notified";
        public const string QUERIES = "queries";
        public const string COMMENT = "comment";

        public static Dictionary<string, string> GetTicketDbFieldsMapped(bool update = false)
        {
            var ticketDbFields = new List<string>
            {
                CREATED_AT,
                JIRA_NUMBER,
                JIRA_LINK,
                GITHUB_LINK,
                TITLE,
                PROJECT_ID,
                TARGET_BRANCH,
                MERGED,
                DEV_DEPLOYED,
                UAT_DEPLOYED,
                CLIENT_NOTIFIED,
                QUERIES,
                COMMENT
            };

            if (update == true)
            {
                ticketDbFields.Add(ID);
            }

            Dictionary<string, string> fieldsPrepared = new Dictionary<string, string>();

            foreach (var field in ticketDbFields)
            {
                fieldsPrepared[field] = "@" + field.ToString();
            }

            return fieldsPrepared;
        }
    }
}
