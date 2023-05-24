using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domin;

namespace pharmacy_manegment
{
    public partial class Dashboard : Form
    {
        DashboredModel dashboard =new DashboredModel();
      
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
            decimal totalAmount = dashboard.totalamount(1);
            int totalproduct = dashboard.totalproduct(1);
            lbltotalproduct.Text = totalproduct.ToString();
            lbltotalamount.Text = totalAmount.ToString();

            dataGridView1.DataSource = dashboard.show();

            label3.Text = dashboard.mostsold();
            label7.Text = dashboard.mostsoldquantity();
            label6.Text = dashboard.leastsold();
            label8.Text = dashboard.leastsoldquantity();
        }

        private void btn1day_Click(object sender, EventArgs e)
        {
           
            decimal totalAmount = dashboard.totalamount(1);
            int totalproduct= dashboard.totalproduct(1);
            lbltotalproduct.Text = totalproduct.ToString();
            lbltotalamount.Text = totalAmount.ToString();
        }

        private void btn7days_Click(object sender, EventArgs e)
        {
            decimal totalAmount = dashboard.totalamount(7);
            int totalproduct = dashboard.totalproduct(7);
            lbltotalproduct.Text = totalproduct.ToString();
            lbltotalamount.Text = totalAmount.ToString();
        }

        private void btn30days_Click(object sender, EventArgs e)
        {
            decimal totalAmount = dashboard.totalamount(30);
            int totalproduct = dashboard.totalproduct(30);
            lbltotalproduct.Text = totalproduct.ToString();
            lbltotalamount.Text = totalAmount.ToString();
        }

        private void btnexpierd_Click(object sender, EventArgs e)
        {
            string currentDay = DateTime.Now.ToString("yyyy.MM.dd");
            dataGridView1.DataSource = dashboard.expire(currentDay);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string currentDay = DateTime.Now.ToString("yyyy.MM.dd");
            dataGridView1.DataSource= dashboard.nonexpired(currentDay);
        }
    }
}
