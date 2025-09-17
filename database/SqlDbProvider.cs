using System.Data.SqlClient;

namespace PRsTicketsListing.database
{
    public class SqlDbProvider : IDbProvider<SqlConnection>
    {
        private readonly string connectionString;
        
        public void InitDb()
        {
            throw new System.NotImplementedException();
        }

        public void ExecuteSqlQueries(params string[] queries)
        {
            throw new System.NotImplementedException();
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(this.connectionString);
        }
    }
}