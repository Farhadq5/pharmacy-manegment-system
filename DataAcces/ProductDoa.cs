using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
   public class ProductDoa : ConnectionToSql
    {
        public void AddMedicene(string medId, string medName, string medNumber, DateTime mandate, DateTime exdate, int quantity, float price)
{
         using (var connection = GetConnection())
         {
        connection.Open();
        
        // Check if medNumber or MedId already exists
        using (var checkCommand = new SqlCommand())
        {
            checkCommand.Connection = connection;
            checkCommand.CommandText = "SELECT COUNT(*) FROM Medicenes WHERE medName = @medName OR MedId = @medId";
            checkCommand.Parameters.AddWithValue("@medNumber", medNumber);
            checkCommand.Parameters.AddWithValue("@medId", medId);

            int existingCount = Convert.ToInt32(checkCommand.ExecuteScalar());
            if (existingCount > 0)
            {
                throw new Exception("The medNumber or MedId already exists.");
            }
        }

        // Insert the new record
        using (var insertCommand = new SqlCommand())
        {
            insertCommand.Connection = connection;
            insertCommand.CommandText = "INSERT INTO Medicenes (MedId, medName, medNumber, Manufacturedate, expiredate, Quantity, price) " +
                                        "VALUES (@medId, @medName, @medNumber, @mandate, @exdate, @quantity, @price)";

            // Add parameters and their values
            insertCommand.Parameters.AddWithValue("@medId", medId);
            insertCommand.Parameters.AddWithValue("@medName", medName);
            insertCommand.Parameters.AddWithValue("@medNumber", medNumber);
            insertCommand.Parameters.AddWithValue("@mandate", mandate);
            insertCommand.Parameters.AddWithValue("@exdate", exdate);
            insertCommand.Parameters.AddWithValue("@quantity", quantity);
            insertCommand.Parameters.AddWithValue("@price", price);

            insertCommand.CommandType = CommandType.Text;
            insertCommand.ExecuteNonQuery();
        }
    }
}

       
        public DataTable datatable()
        {
            DataTable table = new DataTable();

            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT * FROM Medicenes";

                        SqlDataReader reader = command.ExecuteReader();
                        table.Load(reader);
                        reader.Close();

                        return table;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception or log the error
                Console.WriteLine("An error occurred: " + ex.Message);
                return null; // Return null or an empty DataTable in case of an error
            }
        }

        public void EditMedicene(int id, string medId, string medName, string medNumber, DateTime manufactureDate, DateTime expireDate, int quantity, float price)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Medicenes " +
                                          "SET MedId = @medId, " +
                                          "medName = @medName, " +
                                          "medNumber = @medNumber, " +
                                          "Manufacturedate = @manufactureDate, " +
                                          "expiredate = @expireDate, " +
                                          "Quantity = @quantity, " +
                                          "price = @price " +
                                          "WHERE id = @id";

                    // Add parameters and their values
                    command.Parameters.AddWithValue("@medId", medId);
                    command.Parameters.AddWithValue("@medName", medName);
                    command.Parameters.AddWithValue("@medNumber", medNumber);
                    command.Parameters.AddWithValue("@manufactureDate", manufactureDate);
                    command.Parameters.AddWithValue("@expireDate", expireDate);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@id", id);

                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void deletmed(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Medicenes WHERE id = @id";
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }


        
        public DataTable mednamecheack()
        {
            DataTable table = new DataTable();

            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "  select medName from Medicenes where Quantity >0 and expiredate> GETDATE()";

                        SqlDataReader reader = command.ExecuteReader();
                        table.Load(reader);
                        reader.Close();

                        return table;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception or log the error
                Console.WriteLine("An error occurred: " + ex.Message);
                return null; // Return null or an empty DataTable in case of an error
            }
        }

        public DataTable filltxt(string name)
        {
            DataTable table = new DataTable();

            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select MedId,expiredate,price from Medicenes where medName = @name";
                        command.Parameters.AddWithValue ("@name", name);
                        SqlDataReader reader = command.ExecuteReader();
                        table.Load(reader);
                        reader.Close();

                        return table;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception or log the error
                Console.WriteLine("An error occurred: " + ex.Message);
                return null; // Return null or an empty DataTable in case of an error
            }
        }

        public DataTable GetQuantity(string medId)
        {
            DataTable table = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Quantity FROM Medicenes WHERE MedId = @medId";
                    command.Parameters.AddWithValue("@medId", medId);
                    SqlDataReader reader = command.ExecuteReader();
                    table.Load(reader);
                    reader.Close();
                }
            }
            return table;
        }

        public void insertquantity (int quantity,string medid)
        {
            using (var connection = GetConnection()) 
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update Medicenes set Quantity=@quantity where MedId=@medid";
                    command.Parameters.AddWithValue("@medid", medid);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }


        public DataTable search(string medname,string medid)
        {
            DataTable dataT = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Medicenes WHERE medName LIKE '%' + @medname + '%' OR MedId LIKE '%' + @medid + '%'";
                    command.Parameters.AddWithValue("@medname", medname);
                    command.Parameters.AddWithValue("@medid", medid);
                    SqlDataReader reader = command.ExecuteReader();
                    dataT.Load(reader);
                    reader.Close();

                    return dataT;
                }
            }
        }
        //public void showdata(string name)
        //{
        //    using(var connection = GetConnection()) 
        //    {
        //        connection.Open();
        //        using (var command = new SqlCommand()) 
        //        {
        //            command.Connection = connection;
        //            command.CommandText = "select MedId,expiredate,price where medName = @name";
        //            command.Parameters.AddWithValue ("@name", name);
        //            command.CommandType= CommandType.Text;
        //            SqlDataReader reader = command.ExecuteReader();
        //        }
        //    }
        //}
    }

   
}
