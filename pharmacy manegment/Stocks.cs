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
    public partial class Stocks : Form
    {
        SellsModel SellsModel = new SellsModel();
        public Stocks()
        {
            InitializeComponent();
        }

        private void viewsales()
        {
            dataGridView1.DataSource = SellsModel.search();
        }

        private void Stocks_Load(object sender, EventArgs e)
        {
            viewsales();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=SellsModel.searchbydate(dateTimePicker1.Text, dateTimePicker2.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           dataGridView1.DataSource=SellsModel.searchname(textBox1.Text);

        }
    }
}
