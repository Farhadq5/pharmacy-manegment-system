using DataAcces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin
{
    public class DashboredModel
    {
        DashboredDao dashbored=new DashboredDao();

        public decimal totalamount(int days)
        {
            decimal totalamount = dashbored.totalamount(days);            
            return totalamount;
        }

        public int totalproduct(int days) 
        {
            int totalproduct= dashbored.totalproduct(days);
            return totalproduct;
        }

        public DataTable expire(string days)
        {
           
                DataTable dt = new DataTable();
                dt = dashbored.expire(Convert.ToDateTime(days));
                return dt;
            
        }


        public DataTable nonexpired(string days) 
        {
            DataTable dt = new DataTable();
            dt=dashbored.nonexpiered(Convert.ToDateTime(days));
            return dt;
        }
        public DataTable show()
        {
            DataTable dt = new DataTable();
            dt=dashbored.show();
            return dt;
        }

        public string mostsold()
        {
            string show = dashbored.mostsold();
            return show;
        }

        public string mostsoldquantity()
        {
            string show = dashbored.mostsoldquantity();
            return show;
        }
        public string leastsold()
        {
            string show = dashbored.leastsold();
            return show;
        }

        public string leastsoldquantity()
        {
            string show = dashbored.leastsoldquantity();
            return show;
        }
    }
}
