using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net.Configuration;
using Common.Cache;

namespace DataAcces
{
    public class SellesDao : ConnectionToSql
    {
        public void InsertSales(string medid, string medname, decimal unitprice, int quantity, decimal total)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    try
                    {
                        string sellerName = UserLoginCache.FirstName + " " + UserLoginCache.LastName;
                        DateTime curentdate = DateTime.Now;
                        command.Connection = connection;
                        command.CommandText = "INSERT INTO MedicineSalle (seller, MedicineId, MedicineName, UnitPrice, SoldQuantity, TotalAmount,SoldDate) " +
                                              "VALUES (@sellerName, @medid, @medname, @unitprice, @quantity, @total,@curentdate)";

                        command.Parameters.AddWithValue("@sellerName", sellerName);
                        command.Parameters.AddWithValue("@medid", medid);
                        command.Parameters.AddWithValue("@medname", medname);
                        command.Parameters.AddWithValue("@unitprice", unitprice);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Parameters.AddWithValue("@total", total);
                        command.Parameters.AddWithValue("@curentdate", curentdate);

                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                    }
                    catch (Exception) 
                    {

                    }
                }
            }
        }

        public DataTable viewsales() 
        {
            DataTable seetable = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command= new SqlCommand())
                {
                    command.Connection=connection;
                    command.CommandText = "select * from MedicineSalle";
                    command.CommandType=CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    seetable.Load(reader);
                    reader.Close();

                    return seetable;
                }
            }
        }
        

        public DataTable search(DateTime start,DateTime end)
        {
            DataTable table = new DataTable();
            using (var connection = GetConnection()) 
            {
                connection.Open();
                using (var command= new SqlCommand()) 
                {
                    command.Connection=connection;
                    command.CommandText= @"SELECT * FROM MedicineSalle
                                   WHERE SoldDate BETWEEN @start AND @end";
                    command.Parameters.AddWithValue ("@start", start);
                    command.Parameters.AddWithValue("@end", end);
                    using (var reader = command.ExecuteReader())
                    {
                        table.Load(reader);
                    }
                }
            }
            return table;
        }

        public DataTable searchbyname(string name)
        {
            DataTable table = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT * FROM MedicineSalle
                                   WHERE MedicineName LIKE '%' + @name + '%'";
                    command.Parameters.AddWithValue("@name", name);
                    using (var reader = command.ExecuteReader())
                    {
                        table.Load(reader);
                    }
                }
            }
            return table;
        }





    }
}
