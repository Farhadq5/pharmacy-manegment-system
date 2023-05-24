using System.Data.SqlClient;

namespace DataAcces
{
    public abstract class ConnectionToSql
    {

        private readonly string connectionString;
        public ConnectionToSql() 
        {
            connectionString = @"Data Source = KING\SQLEXPRESS; Initial Catalog = Pharmacymng; Integrated Security = True";
        }
        protected SqlConnection GetConnection() 
        {
            return new SqlConnection(connectionString);
        }
    }
}
