using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DataAcces;


namespace Domin
{
    public class ProductModel
    {
        ProductDoa productdoa= new ProductDoa();
        
        public void addmed(string medId, string medName, string medNumber, string mandate, string exdate, string quantity, string price)
        {
            DateTime Mandate = DateTime.Parse(mandate);
            DateTime Exdate = DateTime.Parse(exdate);
            productdoa.AddMedicene(medId, medName, medNumber, Mandate, Exdate,Convert.ToInt32(quantity),Convert.ToByte(price));
        }
        public DataTable datatable()
        {
            DataTable table = new DataTable();
            table = productdoa.datatable();
            return table;
        }

        public void editmed(string id,string medId, string medName, string medNumber, string mandate, string exdate, string quantity, string price)
        {
            DateTime Mandate = DateTime.Parse(mandate);
            DateTime Exdate = DateTime.Parse(exdate);
            productdoa.EditMedicene(Convert.ToInt32(id), medId,medName,medNumber,Mandate,Exdate,Convert.ToInt32(quantity),Convert.ToSByte(price));
        }

        public void deletemed(string id) 
        {
            productdoa.deletmed(Convert.ToInt32(id));
        }

        public DataTable showname()
        {
            DataTable nametable = new DataTable();
            nametable = productdoa.mednamecheack();
            return nametable;
        }

        public DataTable putdata(string name)
        {
            DataTable table = new DataTable();
            table=productdoa.filltxt(name);
            return table;
        }

        
       public DataTable showquantity(string quantity)
        {
            DataTable table2 = new DataTable();
            table2=productdoa.GetQuantity(quantity);
            return table2;
        }
        public void updatequantity(int quantity,string medid) 
        {
            productdoa.insertquantity(quantity, medid);
        }

        public DataTable search(string medname, string medid)
        {
            DataTable table = new DataTable();
            table = productdoa.search(medname, medid);
            return table;
        }
    }
}
