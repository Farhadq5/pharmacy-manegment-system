using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Drawing.Design;
using System.Runtime.InteropServices;
using Common.Cache;

namespace pharmacy_manegment
{
    public partial class mainform : Form
    {
        //Fields
        private IconButton currentbtn;
        private Panel leftBorderbtn;
        private Form currentchildform;
        public string time;

        //constructor
        public mainform()
        {
            InitializeComponent();
            leftBorderbtn = new Panel();
            leftBorderbtn.Size = new Size(7, 60);
            panelmenu.Controls.Add(leftBorderbtn);
            //form
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            lbltime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
        //struct
        private struct RGBcolors
        {
          public static System.Drawing.Color color1 = System.Drawing.Color.FromArgb(172, 126, 241);
          public static System.Drawing.Color color2 = System.Drawing.Color.FromArgb(249, 118, 176);
          public static System.Drawing.Color color3 = System.Drawing.Color.FromArgb(253, 138, 114);
          public static System.Drawing.Color color4 = System.Drawing.Color.FromArgb(95, 77, 221);
          public static System.Drawing.Color color5 = System.Drawing.Color.FromArgb(249, 88, 155);
          public static System.Drawing.Color color6 = System.Drawing.Color.FromArgb(24, 161, 251);
        }
        //Metods
        private void ActivateButton(object senderbtn, System.Drawing.Color color)
        {
            if (senderbtn!= null)
            {
                Disablebutton();
                //button
                currentbtn=(IconButton)senderbtn;
                currentbtn.BackColor = System.Drawing.Color.FromArgb(31, 30, 68);
                currentbtn.ForeColor = color;
                currentbtn.TextAlign=ContentAlignment.MiddleCenter;
                currentbtn.IconColor = color;
                currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentbtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border btn
                leftBorderbtn.BackColor = color;
                leftBorderbtn.Location = new Point(0,currentbtn.Location.Y);
                leftBorderbtn.Visible = true;
                leftBorderbtn.BringToFront();
                //icone current child form
                iconcurrentchildform.IconChar = currentbtn.IconChar;
                iconcurrentchildform.IconColor = currentbtn.IconColor;
            }
        }

        private void Disablebutton()
        {
            if(currentbtn!= null) 
            {
                currentbtn.BackColor = System.Drawing.Color.FromArgb(37, 36, 81);
                currentbtn.ForeColor = System.Drawing.Color.WhiteSmoke;
                currentbtn.TextAlign = ContentAlignment.MiddleLeft;
                currentbtn.IconColor = System.Drawing.Color.WhiteSmoke;
                currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentbtn.ImageAlign = ContentAlignment.MiddleLeft;
              
            }
        }

        private void Openchildform(Form childform)
        {
            if (currentchildform !=null) 
            {
                //open only form
                currentchildform.Close();
            }
            currentchildform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle= FormBorderStyle.None;
            childform.Dock= DockStyle.Fill;
            paneldesktop.Controls.Add(childform);
            paneldesktop.Tag= childform;
            childform.BringToFront();
            childform.Show();
            lbltitlechildform.Text = childform.Text;

        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color1);
            Openchildform(new Dashboard());
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            ActivateButton(sender,RGBcolors.color2);
            Openchildform(new Products());
        }

        private void btnsells_Click(object sender, EventArgs e)
        {
            ActivateButton(sender,RGBcolors.color3);
            Openchildform(new Sells());
        }

        private void btncustomers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color4);
            Openchildform(new Employes());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color5);
            Openchildform(new Setting());
        }

        private void btnstock_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color6);
            Openchildform(new Stocks());
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            currentchildform.Close();
            Reset();
            // Openchildform(new mainform());
            
        }

        private void Reset()
        {
           Disablebutton();
            leftBorderbtn.Visible = false;
            iconcurrentchildform.IconChar = IconChar.Home;
            iconcurrentchildform.IconColor =System.Drawing.Color.MediumPurple;
            lbltitlechildform.Text = "Home";
        }

        //drag form
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wMsg,int wparam,int Iparam);

        private void paneltitlebar_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            showuserdata();
            privlage();
        }
        private void privlage()
        {
            if (UserLoginCache.Position==UserPrivlageCache.manneger) 
            {

            }
            if (UserLoginCache.Position==UserPrivlageCache.seller)
            {
                btncustomers.Enabled = false;
                btncustomers.Visible = false;
                btnsetting.Visible = false;
                btnsetting.Enabled = false;
            }
        }
        private void showuserdata()
        {
            lblfname.Text = UserLoginCache.FirstName+"."+UserLoginCache.LastName;
            lblposition.Text = UserLoginCache.Position;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the application","warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Close();
            }
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
