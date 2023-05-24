using Common.Cache;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;





namespace DataAcces
{
    public class UserDao : ConnectionToSql
    {

        public void AddUser(string userName, string password, string name, string lastName, string position, string mail)
        {
            if (UsernameExists(userName))
            {
                // Username already exists, handle the situation accordingly
                // For example, display an error message to the user
                string msg = "user already exest try new username";
                throw new Exception(msg);
            }
            else
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "INSERT INTO Users (Username, Password, FirstName, LastName, Position, Email) " +
                                              "VALUES (@userName, @password, @name, @lastName, @position, @mail)";
                        command.Parameters.AddWithValue("@userName", userName);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@lastName", lastName);
                        command.Parameters.AddWithValue("@mail", mail);
                        command.Parameters.AddWithValue("@position", position);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
        private bool UsernameExists(string userName)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(*) FROM Users WHERE Username = @userName";
                    command.Parameters.AddWithValue("@userName", userName);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public DataTable dt()
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
                        command.CommandText = "SELECT * FROM Users";

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

        public void EditUser(int id, string userName, string password, string name, string lastName, string position, string mail)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Users " +
                                          "SET Username = @userName, " +
                                          "Password = @password, " +
                                          "FirstName = @name, " +
                                          "LastName = @lastName, " +
                                          "Position = @position, " +
                                          "Email = @mail " +
                                          "WHERE UserId = @id";

                    // Add parameters and their values
                    command.Parameters.Add("@userName", SqlDbType.NVarChar).Value = userName;
                    command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                    command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = lastName;
                    command.Parameters.Add("@position", SqlDbType.NVarChar).Value = position;
                    command.Parameters.Add("@mail", SqlDbType.NVarChar).Value = mail;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteUser(int id)
        {
            //if (IsCurrentUser(id))
            //{
            //    throw new InvalidOperationException("You cannot delete yourself.");
            //}
            //else
            //{
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "DELETE FROM Users WHERE UserId = @id";
                        command.Parameters.AddWithValue("@id", id);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                    }
                }
           // }
        }

        //private bool IsCurrentUser(int id)
        //{
        //    using (var connection = GetConnection())
        //    {
        //        connection.Open();
        //        using (var command = new SqlCommand())
        //        {
        //            command.Connection = connection;
        //            command.CommandText = "SELECT COUNT(*) FROM Users WHERE UserId = @id";
        //            command.Parameters.AddWithValue("@id", id);
        //            return ((int)command.ExecuteScalar()) > 0;
        //        }
        //    }
        //}
        public bool Login(string username, string password)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Users where Username=@username and Password=@password";
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.UserId = reader.GetInt32(0);
                            UserLoginCache.FirstName = reader.GetString(3);
                            UserLoginCache.LastName = reader.GetString(4);
                            UserLoginCache.Position = reader.GetString(5);


                        }
                        return true;

                    }
                    else { return false; }
                }
            }
        }

        public DataTable search(string username)
        {
            DataTable dataT = new DataTable();
            using (var connection = GetConnection()) 
            {
                connection.Open();
                using (var command = new SqlCommand()) 
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Users WHERE Username LIKE '%' + @username + '%'";
                    command.Parameters.AddWithValue ("@username", username);
                    SqlDataReader reader = command.ExecuteReader();
                    dataT.Load(reader);
                    reader.Close();

                    return dataT;
                }
            }
        }

        //security
        //public void userpivlages()
        //{
        //    if ( UserLoginCache.Position== UserPrivlageCache.manneger)
        //    {

        //    }
        //    if (UserLoginCache.Position==UserPrivlageCache.seller)
        //    {

        //    }
        //}
    }

   
}
