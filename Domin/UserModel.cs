using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcces;

namespace Domin
{
   
    public class UserModel
    {
       

        readonly UserDao userDao = new UserDao();
     
        public void edituser(string id, string userName, string password, string name, string lastName, string position, string mail)
        {
            userDao.EditUser(Convert.ToInt32(id), userName, password, name, lastName, position, mail);
        }
        public DataTable dt()
        {
            DataTable table = new DataTable();
            table=userDao.dt();
            return table;
        }
        public void deleteuser(string id) 
        {
            userDao.DeleteUser(Convert.ToInt32(id));
        }
            
        public void useradd(string userName, string password, string name, string lastName,string position ,string mail)
        {
            
            userDao.AddUser(userName, password, name, lastName, position, mail);
        }
        

        public bool LoginUser(string username,string password)
        {
            return userDao.Login(username, password);
        }

        public DataTable search(string username)
        {
            DataTable dataTable = new DataTable();

            dataTable=userDao.search(username);


            return dataTable;
        }
      

       
    }
}
