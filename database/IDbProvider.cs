using System.Data;

namespace PRsTicketsListing.database
{
    public interface IDbProvider<TConnection> where TConnection : IDbConnection
    {
        void InitDb();
        void ExecuteSqlQueries(params string[] queries);
        
        TConnection GetConnection();
    }
}