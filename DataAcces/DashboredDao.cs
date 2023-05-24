using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Security.Cryptography;

namespace DataAcces
{
    public class DashboredDao : ConnectionToSql
    {

        public decimal totalamount(int days)
        {
            decimal totalAmount = 0;

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    if (days == 1)
                    {
                        // Retrieve sum for 1 day
                        command.CommandText = "SELECT SUM(TotalAmount) FROM MedicineSalle WHERE SoldDate >= DATEADD(DAY, -1, GETDATE())";
                    }
                    else if (days == 7)
                    {
                        // Retrieve sum for 7 days
                        command.CommandText = "SELECT SUM(TotalAmount) FROM MedicineSalle WHERE SoldDate >= DATEADD(DAY, -7, GETDATE())";
                    }
                    else if (days == 30)
                    {
                        // Retrieve sum for 30 days
                        command.CommandText = "SELECT SUM(TotalAmount) FROM MedicineSalle WHERE SoldDate >= DATEADD(DAY, -30, GETDATE())";
                    }
                    else
                    {
                        // Invalid input, return 0
                        return totalAmount;
                    }

                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalAmount = Convert.ToDecimal(result);
                    }
                }
            }

            return totalAmount;
        }

        public int totalproduct(int days)
        {
            int totalproduct = 0;

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    if (days == 1)
                    {
                        // Retrieve sum for 1 day
                        command.CommandText = "SELECT SUM(SoldQuantity) FROM MedicineSalle WHERE SoldDate >= DATEADD(DAY, -1, GETDATE())";
                    }
                    else if (days == 7)
                    {
                        // Retrieve sum for 7 days
                        command.CommandText = "SELECT SUM(SoldQuantity) FROM MedicineSalle WHERE SoldDate >= DATEADD(DAY, -7, GETDATE())";
                    }
                    else if (days == 30)
                    {
                        // Retrieve sum for 30 days
                        command.CommandText = "SELECT SUM(SoldQuantity) FROM MedicineSalle WHERE SoldDate >= DATEADD(DAY, -30, GETDATE())";
                    }
                    else
                    {
                        // Invalid input, return 0
                        return totalproduct;
                    }

                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalproduct = Convert.ToInt32(result);
                    }
                }
            }

            return totalproduct;
        }

        public DataTable expire(DateTime day)
        {
            DataTable dt = new DataTable();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT medName, medNumber, Quantity, price
                                    FROM Medicenes
                                    WHERE  expiredate < @day";
                    command.Parameters.AddWithValue("@day", day);

                    using (var reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }

            return dt;
        }

        public DataTable nonexpiered(DateTime day)
        {
            DataTable dt = new DataTable();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT medName, medNumber, Quantity, price
                                    FROM Medicenes
                                    WHERE  expiredate > @day";
                    command.Parameters.AddWithValue("@day", day);

                    using (var reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }

            return dt;
        }

        public DataTable show()
        {
            DataTable dt = new DataTable();
            using (var connection = GetConnection()) 
            {
                connection.Open();
                using (var command= new SqlCommand()) 
                {
                    command.Connection = connection;
                    command.CommandText = "select medName, medNumber, Quantity, price from Medicenes";
                    using (var reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }

        public string mostsold()
        {
            string show = null;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT TOP 1 MedicineName
                                   FROM MedicineSalle
                                   GROUP BY MedicineName
                                   ORDER BY SUM(SoldQuantity) DESC";
                    show = command.ExecuteScalar()?.ToString();
                }
            }
            return show;
        }
        public string mostsoldquantity()
        {
            string show = null;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT TOP 1 SUM(SoldQuantity)
                                   FROM MedicineSalle
                                   GROUP BY MedicineName
                                   ORDER BY SUM(SoldQuantity) DESC";
                    show = command.ExecuteScalar()?.ToString();
                }
            }
            return show;
        }

        public string leastsold()
        {
            string show = null;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT TOP 1 MedicineName
                                   FROM MedicineSalle
                                   GROUP BY MedicineName
                                   ORDER BY SUM(SoldQuantity) asc";
                    show = command.ExecuteScalar()?.ToString();
                }
            }
            return show;
        }

        public string leastsoldquantity()
        {
            string show = null;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT TOP 1 SUM(SoldQuantity)
                                   FROM MedicineSalle
                                   GROUP BY MedicineName
                                   ORDER BY SUM(SoldQuantity) asc";
                    show = command.ExecuteScalar()?.ToString();
                }
            }
            return show;
        }
    }
}
    

