using PRsTicketsListing.consts;
using PRsTicketsListing.database;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace PRsTicketsListing.repositories
{
    internal class Query
    {
        public static List<models.Query> loadQueries(string ticketNumber)
        {
            List<models.Query> queries = new List<models.Query>();

            using (var connection = DatabaseInitializer.GetConnection()) 
            { 
                connection.Open();

                using (var command = new SQLiteCommand(Queries.SELECT_TICKET_QUERIES, connection)) 
                {
                    command.Parameters.AddWithValue("@ticketNumber", ticketNumber);

                    using (var reader = command.ExecuteReader()) 
                    {
                        while (reader.Read()) 
                        {
                            var query = new models.Query
                            {
                                Id = Convert.ToInt32(reader[QueryDBFields.ID]),
                                TicketNumber = reader[QueryDBFields.TICKET_NUMBER].ToString(),
                                Description = reader[QueryDBFields.DESCRIPTION].ToString(),
                                QueryContent = reader[QueryDBFields.QUERY].ToString()
                            };

                            queries.Add(query);
                        }
                    }
                }

                connection.Close();
            }

            return queries;
        }
    }
}
