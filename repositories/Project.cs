using PRsTicketsListing.database;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using PRsTicketsListing.consts;

namespace PRsTicketsListing.repositories
{
    internal static class Project
    {
        public static List<models.Project> LoadProjects()
        {
            List<models.Project> projects = new List<models.Project>();

            using (var connection = DatabaseInitializer.GetConnection())
            {
                connection.Open();

                using (var command = new SQLiteCommand(Queries.SELECT_PROJECT_NAMES, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var project = new models.Project {
                                Id = Convert.ToInt32(reader[ProjectDBFields.ID]),
                                ProjectName = reader[ProjectDBFields.NAME].ToString()
                            };

                            projects.Add(project);
                        }
                    }
                }

                connection.Close();
            }

            return projects;
        }
    }
}
