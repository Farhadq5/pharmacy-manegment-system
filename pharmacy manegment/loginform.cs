using System;
using System.Drawing;
using System.Windows.Forms;
using Domin;

namespace pharmacy_manegment
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void loginform_Load(object sender, EventArgs e)
        {
            lblerrormsg.Visible = false;
          
        }
        private void txtusername_TextChanged(object sender, EventArgs e)
        {
           
            //if (txtusername.Text == "username")
            //{
            //    txtusername.Text = "";
            //    txtusername.ForeColor = Color.LightGray;
            //}
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            //if (txtusername.Text == "")
            //{
            //    txtusername.Text = "username";
            //    txtusername.ForeColor = Color.DimGray;
            //}
        }
        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
           
            //if (txtpassword.Text=="password")
            //{
            //    txtpassword.Text = "";
            //    txtpassword.ForeColor = Color.LightGray;
              txtpassword.UseSystemPasswordChar = true;
            //}
        }
        private void txtpassword_Leave(object sender, EventArgs e)
        {
            //if (txtpassword.Text == "")
            //{
            //    txtpassword.Text = "password";
            //    txtpassword.ForeColor = Color.DimGray;
            //    txtpassword.UseSystemPasswordChar = true;
            //}
        }

        private void iconbtnsignin_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();
                    var validlogin = user.LoginUser(txtusername.Text, txtpassword.Text);
                    if (validlogin == true)
                    {
                        mainform mainmenu = new mainform();
                        mainmenu.Show();
                      mainmenu.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        errormsg("username or password is incorect"); 
                        txtusername.Focus();
                        txtpassword.Clear();
                        
                    }
        }
        private void errormsg(string msg)
        {
            lblerrormsg.Text = " " + msg;
            lblerrormsg.Visible = true;
        }

       private void Logout(object sender, FormClosedEventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
            lblerrormsg.Visible= false;
            Show();

        }
    }
}
