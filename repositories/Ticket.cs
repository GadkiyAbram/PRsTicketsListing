using System;
using System.Collections.Generic;
using System.Data.SQLite;
using PRsTicketsListing.consts;
using PRsTicketsListing.database;
using PRsTicketsListing.models;

namespace PRsTicketsListing.repositories
{
    internal static class Ticket
    {
        public static List<models.Ticket> LoadTickets()
        {
            List<models.Ticket> tickets = new List<models.Ticket>();

            using (var connection = DatabaseInitializer.GetConnection())
            {
                connection.Open();

                using (var command = new SQLiteCommand(Queries.SELECT_TICKETS, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read()) { 
                            var ticket = new models.Ticket {
                                Id = Convert.ToInt32(reader[TicketDBFields.ID]),
                                CreatedAt = reader[TicketDBFields.CREATED_AT].ToString(),
                                JiraTicketNumber = reader[TicketDBFields.JIRA_NUMBER].ToString(),
                                JiraTicketLink = reader[TicketDBFields.JIRA_LINK].ToString(),
                                GithubLink = reader[TicketDBFields.GITHUB_LINK].ToString(),
                                Title = reader[TicketDBFields.TITLE].ToString(),
                                ProjectId = Convert.ToInt32(reader[TicketDBFields.PROJECT_ID]),
                                ProjectName = reader[ProjectDBFields.NAME].ToString(),
                                TargetBranch = reader[TicketDBFields.TARGET_BRANCH].ToString(),
                                Merged = Convert.ToBoolean(reader[TicketDBFields.MERGED]),
                                DevDeployed = Convert.ToBoolean(reader[TicketDBFields.DEV_DEPLOYED]),
                                UatDeployed = Convert.ToBoolean(reader[TicketDBFields.UAT_DEPLOYED]),
                                ClientNotified = Convert.ToBoolean(reader[TicketDBFields.CLIENT_NOTIFIED]),
                                Comment = reader[TicketDBFields.COMMENT].ToString()
                            };

                            tickets.Add(ticket);
                        }
                    }
                }

                connection.Close();
            }

            return tickets;
        }
    }
}
