using Domin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Forms;


namespace pharmacy_manegment
{
    public partial class Employes : Form
    {
        UserModel usermodal = new UserModel();
        private string id = "";
        private bool edit = false;
        public Employes()
        {
            InitializeComponent();
        }
        private void Employes_Load(object sender, EventArgs e)
        {

            dt();
        }
        private void dt()
        {
            txtupmail.Visible = false;
            txtupfirstname.Visible = false;
            txtuplastname.Visible = false;
            txtuppass.Visible = false;
            txtupposition.Visible = false;
            txtupusername.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            iconbtnsave.Visible = false;
            dataGridView3.DataSource = usermodal.dt();
            dataGridView2.DataSource = usermodal.dt();
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {

            usermodal.useradd(txtuser.Text, txtpass.Text, txtfirstname.Text, txtlastname.Text
            , comboBox2.Text, txtemail.Text);
            Clearalltxt();


        }
        private void Clearalltxt()
        {
            txtemail.Clear();
            txtuser.Clear();
            txtpass.Clear();
            txtfirstname.Clear();
            txtlastname.Clear();
            comboBox2.Items.Clear();
            txtuser.Focus();

        }
        private void search()
        {
            try
            {
                dataGridView3.DataSource = usermodal.search(textBox1.Text);
            }
            catch (Exception ex)
            {
                // Handle the exception or display an error message
                MessageBox.Show("An error occurred while searching: " + ex.Message);
            }
        }
           
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconbtnupdate_Click(object sender, EventArgs e)
        {

            if (dataGridView3.SelectedRows.Count > 0)
            {
                txtupmail.Visible = true;
                txtupfirstname.Visible = true;
                txtuplastname.Visible = true;
                txtuppass.Visible = true;
                txtupposition.Visible = true;
                txtupusername.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                iconbtnsave.Visible = true;
                edit = true;
                txtupusername.Text = dataGridView3.CurrentRow.Cells["Username"].Value.ToString();
                txtuppass.Text = dataGridView3.CurrentRow.Cells["Password"].Value.ToString();
                txtupfirstname.Text = dataGridView3.CurrentRow.Cells["firstName"].Value.ToString();
                txtuplastname.Text = dataGridView3.CurrentRow.Cells["LastName"].Value.ToString();
                txtupposition.Text = dataGridView3.CurrentRow.Cells["Position"].Value.ToString();
                txtupmail.Text = dataGridView3.CurrentRow.Cells["Email"].Value.ToString();
                id = dataGridView3.CurrentRow.Cells["UserId"].Value.ToString();


            }
        }

        private void iconbtnsave_Click(object sender, EventArgs e)
        {
            if (edit == true)
            {
                try
                {
                    usermodal.edituser(id, txtupusername.Text, txtuppass.Text, txtupfirstname.Text, txtuplastname.Text, txtupposition.Text, txtupmail.Text);
                    dt();
                    edit = false;
                }
                catch (Exception)
                {

                    MessageBox.Show("try again");
                }
            }

        }

        private void iconbtndelete_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the user?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    int selectedRowIndex = dataGridView3.CurrentCell.RowIndex; // Get the index of the selected row

                    dataGridView3.DataSource = usermodal.dt();
                    dataGridView2.DataSource = usermodal.dt();
                    id = dataGridView3.CurrentRow.Cells["UserId"].Value.ToString();
                    usermodal.deleteuser(id);

                    // Remove the selected row from the DataGridView
                    dataGridView3.Rows.RemoveAt(selectedRowIndex);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("User not deleted. Please try again.");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search();
        }
    }
}
