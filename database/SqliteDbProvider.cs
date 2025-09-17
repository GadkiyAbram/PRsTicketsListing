using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using PRsTicketsListing.consts;

namespace PRsTicketsListing.database
{
    public class SqliteDbProvider : IDbProvider<SQLiteConnection>

    {
        private readonly string dbFolder;
        private readonly string dbPath;

        public SqliteDbProvider(string dbFolder, string dbPath)
        {
            this.dbFolder = Path.Combine(Application.StartupPath, "database");
            this.dbPath = Path.Combine(dbFolder, "database.db");
        }

        public void InitDb()
        {
            if (!Directory.Exists(this.dbFolder))
            {
                Directory.CreateDirectory(this.dbFolder);
            }

            if (!File.Exists(this.dbPath))
            {
                SQLiteConnection.CreateFile(this.dbPath);
            }

            ExecuteSqlQueries(Queries.TABLE_CREATE_QUERIES);
        }

        public void ExecuteSqlQueries(params string[] queries)
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

        public SQLiteConnection GetConnection()
        {
            return new SQLiteConnection($"Data Source={dbPath}");
        }
    }
}