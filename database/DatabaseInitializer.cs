using PRsTicketsListing.consts;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRsTicketsListing.database
{
    public static class DatabaseInitializer
    {
        public static void InitDatabase()
        {
            var (dbFolder, dbPath) = DatabaseInitializer.GetDbPaths();

            if (!Directory.Exists(dbFolder))
            {
                Directory.CreateDirectory(dbFolder);
            }

            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
            }

            ExecuteSqlQueries(Queries.TABLE_CREATE_QUERIES);

            //using (var connection = DatabaseInitializer.GetConnection())
            //{
            //    connection.Open();

            //    using (var command = new SQLiteCommand(Queries.CREATE_TABLE_PROJECT_NAMES, connection))
            //    {
            //        command.ExecuteNonQuery();
            //    }

            //    using (var command = new SQLiteCommand(Queries.CREATE_TABLE_TICKETS, connection))
            //    {
            //        command.ExecuteNonQuery();
            //    }

            //    using (var command = new SQLiteCommand(Queries.CREATE_TABLE_TICEKT_QUERIES, connection))
            //    {
            //        command.ExecuteNonQuery();
            //    }

            //    connection.Close();
            //}
        }

        private static void ExecuteSqlQueries(params string[] queries)
        {
            var connection = GetConnection();

            connection.Open();

            using (var command = new SQLiteCommand(connection))
            {
                foreach (var query in queries)
                {
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                }
            }

            connection.Close();
        }

        private static (string dbFolder, string dbPath) GetDbPaths()
        {
            string dbFolder = Path.Combine(Application.StartupPath, "database");
            string dbPath = Path.Combine(dbFolder, "database.db");

            return (dbFolder, dbPath);
        }

        public static SQLiteConnection GetConnection()
        {
            var (_, dbPath) = DatabaseInitializer.GetDbPaths();

            return new SQLiteConnection($"Data Source={dbPath}");
        }
    }
}
