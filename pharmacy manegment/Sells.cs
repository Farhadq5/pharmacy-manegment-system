using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Domin;

namespace pharmacy_manegment
{
    public partial class Sells : Form
    {
        ProductModel productmodel = new ProductModel();
        SellsModel sellsmodel = new SellsModel();


        public Sells()
        {
            InitializeComponent();
        }

        private void Sells_Load(object sender, EventArgs e)
        {
            listshowname();
            btnSell.Enabled = false;


        }

        private void listselectname()
        {

        }
        private void listshowname()
        {

            DataTable nametable = productmodel.showname();

            for (int i = 0; i < nametable.Rows.Count; i++)
            {
                string displayValue = string.Empty;

                displayValue += nametable.Rows[i][0].ToString();

                listBox1.Items.Add(displayValue);
            }
        }
        private void total()
        {
            if (Int64.TryParse(txtmedid.Text, out Int64 medid))
            {
                if (Int64.TryParse(txtquantitu.Text, out Int64 quantity) && quantity > 0)
                {
                    if (Int64.TryParse(txtunitprice.Text, out Int64 price) && price > 0)
                    {
                        Int64 total = quantity * price;
                        txttotal.Text = total.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid number for Unit Price");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid number greater than 0 for Quantity");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number for MedID");
            }
        }

      
        private void validate()
        {
            if (txtquantitu.Text != "")
            {
                try
                {
                    Int64 quantity = Int64.Parse(txtquantitu.Text);
                    Int64 price = Int64.Parse(txtunitprice.Text);
                    if (quantity >= 0)
                        btnSell.Enabled = true;

                }
                catch (Exception)
                {

                    MessageBox.Show("plese inserte number");
                }               
            }
          
        }
        //private void sellsinsert()
        //{
        //    quantity();
        //    //sellsmodel.sells(txtmedid.Text, txtmedname.Text, txtunitprice.Text, txtquantitu.Text, txttotal.Text);
        //}
        private void clearall()
        {
            txtmedid.Clear();
            txtmedname.Clear();
            txtunitprice.Clear();
            txtquantitu.Clear();
            txttotal.Clear();
            txtexdate.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        { txtquantitu.Clear();
            if (listBox1.SelectedIndex != -1)
            {
                txtquantitu.Clear();
                string selectedItem = listBox1.SelectedItem.ToString();
                DataTable table = productmodel.putdata(selectedItem);
                txtmedname.Text = selectedItem;


                if (table != null && table.Rows.Count > 0)
                {
                    txtmedid.Text = table.Rows[0][0].ToString();
                    txtexdate.Text = table.Rows[0][1].ToString();
                    txtunitprice.Text = table.Rows[0][2].ToString();
                }
                else
                {
                    MessageBox.Show("insert Name");
                }
            }

        }


        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
       
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void quantity()
        {
            if (Int64.TryParse(txtmedid.Text, out Int64 medid))
            {
                if (int.TryParse(txtquantitu.Text, out int quantity) && quantity > 0)
                {
                    DataTable quantityTable = productmodel.showquantity(txtmedid.Text);

                    if (quantityTable.Rows.Count > 0)
                    {
                        int currentQuantity = Convert.ToInt32(quantityTable.Rows[0]["Quantity"]);

                        if (quantity <= currentQuantity)
                        {
                            int newQuantity = currentQuantity - quantity;
                            productmodel.updatequantity(newQuantity, txtmedid.Text);

                            decimal unitPrice;
                            if (decimal.TryParse(txtunitprice.Text, out unitPrice))
                            {
                                decimal total;
                                if (decimal.TryParse(txttotal.Text, out total))
                                {
                                    sellsmodel.sells(txtmedid.Text, txtmedname.Text, unitPrice, quantity, total);
                                }
                                else
                                {
                                    MessageBox.Show("Please enter a valid number for Total");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid number for Unit Price");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Insufficient quantity in stock");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid product ID");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid number greater than 0 for Quantity");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number for MedID");
            }
        }


        private void btnSell_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to sell the item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    quantity();
                    clearall();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your list again. Item not sold.");
            }

           
        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtquantitu_TextChanged(object sender, EventArgs e)
        {
           
            total();
            validate();
        }
    }
}
