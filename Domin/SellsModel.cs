using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcces;

namespace Domin
{
    public class SellsModel
    {

        SellesDao selledao= new SellesDao();
        public void sells(string medid,string medname,decimal unit,int quantity,decimal total)
        {
            selledao.InsertSales(medid, medname,unit, quantity, Convert.ToInt32(total));
        }


        public DataTable search()
        {
            DataTable table = new DataTable();
            table = selledao.viewsales();
            return table;
        }

        public DataTable searchbydate(string start,string end)
        {
            DataTable table = new DataTable();
            table=selledao.search(Convert.ToDateTime(start),Convert.ToDateTime(end));
            return table;
        }

        public DataTable searchname(string name) 
        {
            DataTable table=new DataTable();
            table=selledao.searchbyname(name);
            return table;
        }
    }
}
