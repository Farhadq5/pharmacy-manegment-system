namespace pharmacy_manegment
{
    partial class mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.panelmenu = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnstock = new FontAwesome.Sharp.IconButton();
            this.btnsetting = new FontAwesome.Sharp.IconButton();
            this.btncustomers = new FontAwesome.Sharp.IconButton();
            this.btnsells = new FontAwesome.Sharp.IconButton();
            this.btnproduct = new FontAwesome.Sharp.IconButton();
            this.btndashboard = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.paneltitlebar = new System.Windows.Forms.Panel();
            this.lblposition = new System.Windows.Forms.Label();
            this.lblfname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltitlechildform = new System.Windows.Forms.Label();
            this.iconcurrentchildform = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paneldesktop = new System.Windows.Forms.Panel();
            this.lbltime = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelmenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.paneltitlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcurrentchildform)).BeginInit();
            this.paneldesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelmenu.Controls.Add(this.iconButton1);
            this.panelmenu.Controls.Add(this.btnstock);
            this.panelmenu.Controls.Add(this.btnsetting);
            this.panelmenu.Controls.Add(this.btncustomers);
            this.panelmenu.Controls.Add(this.btnsells);
            this.panelmenu.Controls.Add(this.btnproduct);
            this.panelmenu.Controls.Add(this.btndashboard);
            this.panelmenu.Controls.Add(this.panel2);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(246, 675);
            this.panelmenu.TabIndex = 0;
            this.panelmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(0, 627);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(246, 48);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.Text = "LOGOUT";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnstock
            // 
            this.btnstock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnstock.FlatAppearance.BorderSize = 0;
            this.btnstock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnstock.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btnstock.IconColor = System.Drawing.Color.SeaShell;
            this.btnstock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnstock.IconSize = 35;
            this.btnstock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstock.Location = new System.Drawing.Point(0, 390);
            this.btnstock.Margin = new System.Windows.Forms.Padding(2);
            this.btnstock.Name = "btnstock";
            this.btnstock.Padding = new System.Windows.Forms.Padding(7, 0, 13, 0);
            this.btnstock.Size = new System.Drawing.Size(246, 67);
            this.btnstock.TabIndex = 6;
            this.btnstock.Text = "View Sells";
            this.btnstock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnstock.UseVisualStyleBackColor = true;
            this.btnstock.Click += new System.EventHandler(this.btnstock_Click);
            // 
            // btnsetting
            // 
            this.btnsetting.FlatAppearance.BorderSize = 0;
            this.btnsetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsetting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsetting.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.btnsetting.IconColor = System.Drawing.Color.SeaShell;
            this.btnsetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsetting.IconSize = 35;
            this.btnsetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsetting.Location = new System.Drawing.Point(0, 459);
            this.btnsetting.Margin = new System.Windows.Forms.Padding(2);
            this.btnsetting.Name = "btnsetting";
            this.btnsetting.Padding = new System.Windows.Forms.Padding(7, 0, 13, 0);
            this.btnsetting.Size = new System.Drawing.Size(246, 61);
            this.btnsetting.TabIndex = 5;
            this.btnsetting.Text = "Setting";
            this.btnsetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsetting.UseVisualStyleBackColor = true;
            this.btnsetting.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // btncustomers
            // 
            this.btncustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncustomers.FlatAppearance.BorderSize = 0;
            this.btncustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncustomers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncustomers.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btncustomers.IconColor = System.Drawing.Color.SeaShell;
            this.btncustomers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncustomers.IconSize = 35;
            this.btncustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncustomers.Location = new System.Drawing.Point(0, 329);
            this.btncustomers.Margin = new System.Windows.Forms.Padding(2);
            this.btncustomers.Name = "btncustomers";
            this.btncustomers.Padding = new System.Windows.Forms.Padding(7, 0, 13, 0);
            this.btncustomers.Size = new System.Drawing.Size(246, 61);
            this.btncustomers.TabIndex = 4;
            this.btncustomers.Text = "Employes";
            this.btncustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncustomers.UseVisualStyleBackColor = true;
            this.btncustomers.Click += new System.EventHandler(this.btncustomers_Click);
            // 
            // btnsells
            // 
            this.btnsells.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsells.FlatAppearance.BorderSize = 0;
            this.btnsells.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsells.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsells.IconChar = FontAwesome.Sharp.IconChar.Exchange;
            this.btnsells.IconColor = System.Drawing.Color.SeaShell;
            this.btnsells.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsells.IconSize = 35;
            this.btnsells.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsells.Location = new System.Drawing.Point(0, 268);
            this.btnsells.Margin = new System.Windows.Forms.Padding(2);
            this.btnsells.Name = "btnsells";
            this.btnsells.Padding = new System.Windows.Forms.Padding(7, 0, 13, 0);
            this.btnsells.Size = new System.Drawing.Size(246, 61);
            this.btnsells.TabIndex = 3;
            this.btnsells.Text = "Sell";
            this.btnsells.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsells.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsells.UseVisualStyleBackColor = true;
            this.btnsells.Click += new System.EventHandler(this.btnsells_Click);
            // 
            // btnproduct
            // 
            this.btnproduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnproduct.FlatAppearance.BorderSize = 0;
            this.btnproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnproduct.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnproduct.IconColor = System.Drawing.Color.SeaShell;
            this.btnproduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnproduct.IconSize = 35;
            this.btnproduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproduct.Location = new System.Drawing.Point(0, 207);
            this.btnproduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.Padding = new System.Windows.Forms.Padding(7, 0, 13, 0);
            this.btnproduct.Size = new System.Drawing.Size(246, 61);
            this.btnproduct.TabIndex = 2;
            this.btnproduct.Text = "Products";
            this.btnproduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnproduct.UseVisualStyleBackColor = true;
            this.btnproduct.Click += new System.EventHandler(this.btnproduct_Click);
            // 
            // btndashboard
            // 
            this.btndashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndashboard.FlatAppearance.BorderSize = 0;
            this.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashboard.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btndashboard.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.btndashboard.IconColor = System.Drawing.Color.SeaShell;
            this.btndashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btndashboard.IconSize = 35;
            this.btndashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashboard.Location = new System.Drawing.Point(0, 146);
            this.btndashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Padding = new System.Windows.Forms.Padding(7, 0, 13, 0);
            this.btndashboard.Size = new System.Drawing.Size(246, 61);
            this.btndashboard.TabIndex = 1;
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndashboard.UseVisualStyleBackColor = true;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.iconPictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 146);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 5;
            this.iconPictureBox2.Location = new System.Drawing.Point(74, 68);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(5, 5);
            this.iconPictureBox2.TabIndex = 1;
            this.iconPictureBox2.TabStop = false;
            // 
            // paneltitlebar
            // 
            this.paneltitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(64)))));
            this.paneltitlebar.Controls.Add(this.lblposition);
            this.paneltitlebar.Controls.Add(this.lblfname);
            this.paneltitlebar.Controls.Add(this.label2);
            this.paneltitlebar.Controls.Add(this.label1);
            this.paneltitlebar.Controls.Add(this.lbltitlechildform);
            this.paneltitlebar.Controls.Add(this.iconcurrentchildform);
            this.paneltitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitlebar.Location = new System.Drawing.Point(246, 0);
            this.paneltitlebar.Margin = new System.Windows.Forms.Padding(2);
            this.paneltitlebar.Name = "paneltitlebar";
            this.paneltitlebar.Size = new System.Drawing.Size(881, 83);
            this.paneltitlebar.TabIndex = 1;
            this.paneltitlebar.Paint += new System.Windows.Forms.PaintEventHandler(this.paneltitlebar_Paint);
            // 
            // lblposition
            // 
            this.lblposition.AutoSize = true;
            this.lblposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblposition.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblposition.Location = new System.Drawing.Point(741, 44);
            this.lblposition.Name = "lblposition";
            this.lblposition.Size = new System.Drawing.Size(46, 18);
            this.lblposition.TabIndex = 5;
            this.lblposition.Text = "label4";
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfname.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblfname.Location = new System.Drawing.Point(741, 16);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(46, 18);
            this.lblfname.TabIndex = 4;
            this.lblfname.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(656, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Position :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(640, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Full Name :";
            // 
            // lbltitlechildform
            // 
            this.lbltitlechildform.AutoSize = true;
            this.lbltitlechildform.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbltitlechildform.Location = new System.Drawing.Point(69, 36);
            this.lbltitlechildform.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitlechildform.Name = "lbltitlechildform";
            this.lbltitlechildform.Size = new System.Drawing.Size(44, 16);
            this.lbltitlechildform.TabIndex = 1;
            this.lbltitlechildform.Text = "Home";
            // 
            // iconcurrentchildform
            // 
            this.iconcurrentchildform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(64)))));
            this.iconcurrentchildform.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconcurrentchildform.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconcurrentchildform.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconcurrentchildform.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconcurrentchildform.IconSize = 43;
            this.iconcurrentchildform.Location = new System.Drawing.Point(15, 32);
            this.iconcurrentchildform.Margin = new System.Windows.Forms.Padding(2);
            this.iconcurrentchildform.Name = "iconcurrentchildform";
            this.iconcurrentchildform.Size = new System.Drawing.Size(43, 44);
            this.iconcurrentchildform.TabIndex = 0;
            this.iconcurrentchildform.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(246, 83);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 8);
            this.panel1.TabIndex = 2;
            // 
            // paneldesktop
            // 
            this.paneldesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.paneldesktop.Controls.Add(this.lbltime);
            this.paneldesktop.Controls.Add(this.pictureBox2);
            this.paneldesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldesktop.Location = new System.Drawing.Point(246, 91);
            this.paneldesktop.Margin = new System.Windows.Forms.Padding(2);
            this.paneldesktop.Name = "paneldesktop";
            this.paneldesktop.Size = new System.Drawing.Size(881, 584);
            this.paneldesktop.TabIndex = 3;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbltime.Location = new System.Drawing.Point(297, 319);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(0, 76);
            this.lbltime.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(242, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(396, 280);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 675);
            this.Controls.Add(this.paneldesktop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paneltitlebar);
            this.Controls.Add(this.panelmenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainform";
            this.Text = "mainform";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.panelmenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.paneltitlebar.ResumeLayout(false);
            this.paneltitlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcurrentchildform)).EndInit();
            this.paneldesktop.ResumeLayout(false);
            this.paneldesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private FontAwesome.Sharp.IconButton btnsetting;
        private FontAwesome.Sharp.IconButton btncustomers;
        private FontAwesome.Sharp.IconButton btnsells;
        private FontAwesome.Sharp.IconButton btnproduct;
        private FontAwesome.Sharp.IconButton btndashboard;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnstock;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel paneltitlebar;
        private FontAwesome.Sharp.IconPictureBox iconcurrentchildform;
        private System.Windows.Forms.Label lbltitlechildform;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel paneldesktop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblposition;
        private System.Windows.Forms.Label lblfname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

