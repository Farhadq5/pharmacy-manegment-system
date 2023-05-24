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
    public partial class Products : Form
    {
        ProductModel productmodel = new ProductModel();
        string id = null;
        bool isedit=false;
        public Products()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Products_Load(object sender, EventArgs e)
        {
            datatable();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (isedit is false)
            {
                try 
                {
                    productmodel.addmed(txtmedid.Text, txtmedname.Text, txtmednumber.Text, dtmandate.Text, dtexdate.Text, txtquentity.Text, txtprice.Text);
                    MessageBox.Show("Succesfuly saved");
                }
                catch (Exception )
                {
                    MessageBox.Show("Not saved");
                }

            }
            if (isedit is true)
            {
                try
                {
                    productmodel.editmed(id, txtmedid.Text, txtmedname.Text, txtmednumber.Text, dtmandate.Text, dtexdate.Text, txtquentity.Text, txtprice.Text);
                    isedit = false;
                    MessageBox.Show("Succesfuly Updated");
                }
                catch (Exception)
                {

                    MessageBox.Show("Not Updated");
                }
            }
            clearall();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            clearall();
        }
        private void clearall()
        {
            txtmedid.Clear();
            txtmedname.Clear();
            txtmednumber.Clear();
            txtquentity.Clear();
            txtprice.Clear();

        }

        void datatable()
        {
            dataGridView1.DataSource = productmodel.datatable();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                isedit = true;
                txtmedid.Text = dataGridView1.CurrentRow.Cells["medId"].Value.ToString();
                txtmedname.Text = dataGridView1.CurrentRow.Cells["medName"].Value.ToString();
                txtmednumber.Text = dataGridView1.CurrentRow.Cells["medNumber"].Value.ToString();
                dtmandate.Text = dataGridView1.CurrentRow.Cells["Manufacturedate"].Value.ToString();
                dtexdate.Text = dataGridView1.CurrentRow.Cells["expiredate"].Value.ToString();
                txtquentity.Text = dataGridView1.CurrentRow.Cells["Quantity"].Value.ToString();
                txtprice.Text = dataGridView1.CurrentRow.Cells["price"].Value.ToString();
                id = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                tabControl1.SelectedTab = tabPage1;
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete selected medicene?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    int selectedRowIndex = dataGridView1.CurrentCell.RowIndex; // Get the index of the selected row

                    datatable();
                    id = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                    productmodel.deletemed(id);
                    // Remove the selected row from the DataGridView
                    dataGridView1.Rows.RemoveAt(selectedRowIndex);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("medicene not deleted. Please try again.");
            }
        }
        private void search()
        {
            try
            {
                dataGridView1.DataSource = productmodel.search(textBox1.Text, textBox1.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred while searching: " + ex.Message);
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            search();
        }
    }
}
