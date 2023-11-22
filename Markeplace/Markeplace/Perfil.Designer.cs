namespace Markeplace
{
    partial class Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
            perfiliconimg = new PictureBox();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            lblname = new Label();
            lbllastname = new Label();
            lbluser = new Label();
            lblcorreo = new Label();
            datosuser = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)perfiliconimg).BeginInit();
            datosuser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // perfiliconimg
            // 
            perfiliconimg.BackColor = Color.FromArgb(0, 99, 136);
            perfiliconimg.BackgroundImageLayout = ImageLayout.None;
            perfiliconimg.Image = (Image)resources.GetObject("perfiliconimg.Image");
            perfiliconimg.Location = new Point(12, 102);
            perfiliconimg.Name = "perfiliconimg";
            perfiliconimg.Size = new Size(138, 136);
            perfiliconimg.SizeMode = PictureBoxSizeMode.StretchImage;
            perfiliconimg.TabIndex = 3;
            perfiliconimg.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(269, 46);
            label2.Name = "label2";
            label2.Size = new Size(0, 24);
            label2.TabIndex = 6;
            label2.Click += label2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(0, 192, 192);
            linkLabel1.Location = new Point(406, 155);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(64, 15);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Edit profile";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.BackColor = Color.Transparent;
            lblname.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblname.ForeColor = Color.White;
            lblname.Location = new Point(20, 64);
            lblname.Name = "lblname";
            lblname.Size = new Size(51, 22);
            lblname.TabIndex = 12;
            lblname.Text = "name";
            // 
            // lbllastname
            // 
            lbllastname.AutoSize = true;
            lbllastname.BackColor = Color.Transparent;
            lbllastname.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbllastname.ForeColor = Color.White;
            lbllastname.Location = new Point(20, 104);
            lbllastname.Name = "lbllastname";
            lbllastname.Size = new Size(84, 22);
            lbllastname.TabIndex = 11;
            lbllastname.Text = "Lastname";
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.BackColor = Color.Transparent;
            lbluser.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbluser.ForeColor = Color.White;
            lbluser.Location = new Point(20, 27);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(47, 22);
            lbluser.TabIndex = 10;
            lbluser.Text = "User";
            // 
            // lblcorreo
            // 
            lblcorreo.AutoSize = true;
            lblcorreo.BackColor = Color.Transparent;
            lblcorreo.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblcorreo.ForeColor = Color.White;
            lblcorreo.Location = new Point(20, 148);
            lblcorreo.Name = "lblcorreo";
            lblcorreo.Size = new Size(72, 22);
            lblcorreo.TabIndex = 31;
            lblcorreo.Text = "Usuario";
            lblcorreo.Click += label6_Click;
            // 
            // datosuser
            // 
            datosuser.BackColor = Color.FromArgb(0, 99, 136);
            datosuser.Controls.Add(lblcorreo);
            datosuser.Controls.Add(lbluser);
            datosuser.Controls.Add(lbllastname);
            datosuser.Controls.Add(lblname);
            datosuser.Controls.Add(linkLabel1);
            datosuser.Location = new Point(165, 167);
            datosuser.Name = "datosuser";
            datosuser.Size = new Size(502, 203);
            datosuser.TabIndex = 32;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(827, 287);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(-3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(827, 158);
            panel2.TabIndex = 33;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(15, 6);
            pictureBox3.Margin = new Padding(0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 34;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 335);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Perfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 48, 75);
            ClientSize = new Size(824, 401);
            Controls.Add(pictureBox2);
            Controls.Add(perfiliconimg);
            Controls.Add(panel2);
            Controls.Add(datosuser);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Perfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Perfil";
            Load += Perfil_Load;
            ((System.ComponentModel.ISupportInitialize)perfiliconimg).EndInit();
            datosuser.ResumeLayout(false);
            datosuser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox perfiliconimg;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private LinkLabel linkLabel1;
        private Label lblemail;
        private Label lblname;
        private Label lbllastname;
        private Label lbluser;
        private Label lblcorreo;
        private Panel datosuser;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}