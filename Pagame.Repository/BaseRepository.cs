using System;
using System.Data;
using System.Data.SqlClient;
namespace Pagame.Repository
{
    public class BaseRepository : IDisposable
    {
        protected IDbConnection con;
        public BaseRepository()
        {
            string connectionString = "Data Source=****;Initial Catalog=PagameDevDatabase;Integrated Security=True;";
            con = new SqlConnection(connectionString);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
