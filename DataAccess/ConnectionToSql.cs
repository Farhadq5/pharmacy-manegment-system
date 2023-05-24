using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class ConnectionToSql
    {
        private readonly string connectionString;
        public ConnectionToSql()
        {
            connectionString = (@"Data Source=ARSALANQURSD05E\SQLEXPRESS;Initial Catalog=Pharmacymng;Integrated Security=True");
        }
        protected  GetConnection()
        {
           return new SqlConnection(connectionString);
        }
    }
}