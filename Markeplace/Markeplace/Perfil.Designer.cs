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
            perfilimage = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            lblemail = new Label();
            lblname = new Label();
            lbllastname = new Label();
            lbluser = new Label();
            panel1 = new Panel();
            txtactualcontra = new TextBox();
            label5 = new Label();
            confirmar = new Button();
            cancelar = new Button();
            label15 = new Label();
            txtconfirmarcontra = new TextBox();
            txtcontra = new TextBox();
            label13 = new Label();
            label14 = new Label();
            txtemail = new TextBox();
            txtlastname = new TextBox();
            txtfirstname = new TextBox();
            txtusername = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            label11 = new Label();
            label16 = new Label();
            ((System.ComponentModel.ISupportInitialize)perfilimage).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // perfilimage
            // 
            perfilimage.BackColor = Color.Transparent;
            perfilimage.BackgroundImageLayout = ImageLayout.None;
            perfilimage.Image = (Image)resources.GetObject("perfilimage.Image");
            perfilimage.Location = new Point(37, 28);
            perfilimage.Name = "perfilimage";
            perfilimage.Size = new Size(126, 135);
            perfilimage.SizeMode = PictureBoxSizeMode.StretchImage;
            perfilimage.TabIndex = 3;
            perfilimage.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 166);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 5;
            label1.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 254);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 6;
            label2.Text = "Lastname :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 212);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 7;
            label3.Text = "Firstname :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 305);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 8;
            label4.Text = "Email :";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(79, 370);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(64, 15);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Edit profile";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.BackColor = Color.White;
            lblemail.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblemail.ForeColor = Color.Gray;
            lblemail.Location = new Point(12, 320);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(34, 13);
            lblemail.TabIndex = 13;
            lblemail.Text = "Email";
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.BackColor = Color.White;
            lblname.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblname.ForeColor = Color.Gray;
            lblname.Location = new Point(11, 227);
            lblname.Name = "lblname";
            lblname.Size = new Size(35, 13);
            lblname.TabIndex = 12;
            lblname.Text = "name";
            // 
            // lbllastname
            // 
            lbllastname.AutoSize = true;
            lbllastname.BackColor = Color.White;
            lbllastname.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbllastname.ForeColor = Color.Gray;
            lbllastname.Location = new Point(12, 269);
            lbllastname.Name = "lbllastname";
            lbllastname.Size = new Size(55, 13);
            lbllastname.TabIndex = 11;
            lbllastname.Text = "Lastname";
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.BackColor = Color.White;
            lbluser.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbluser.ForeColor = Color.Gray;
            lbluser.Location = new Point(12, 181);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(30, 13);
            lbluser.TabIndex = 10;
            lbluser.Text = "User";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 176, 140);
            panel1.Controls.Add(txtactualcontra);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(confirmar);
            panel1.Controls.Add(cancelar);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(txtconfirmarcontra);
            panel1.Controls.Add(txtcontra);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(txtemail);
            panel1.Controls.Add(txtlastname);
            panel1.Controls.Add(txtfirstname);
            panel1.Controls.Add(txtusername);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(245, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 433);
            panel1.TabIndex = 14;
            panel1.Visible = false;
            // 
            // txtactualcontra
            // 
            txtactualcontra.Location = new Point(37, 330);
            txtactualcontra.Name = "txtactualcontra";
            txtactualcontra.Size = new Size(194, 23);
            txtactualcontra.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 312);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 32;
            label5.Text = "Current password :";
            // 
            // confirmar
            // 
            confirmar.Location = new Point(143, 385);
            confirmar.Name = "confirmar";
            confirmar.Size = new Size(75, 23);
            confirmar.TabIndex = 31;
            confirmar.Text = "Confirmar";
            confirmar.UseVisualStyleBackColor = true;
            confirmar.Click += confirmar_Click;
            // 
            // cancelar
            // 
            cancelar.Location = new Point(28, 385);
            cancelar.Name = "cancelar";
            cancelar.Size = new Size(75, 23);
            cancelar.TabIndex = 30;
            cancelar.Text = "Cancelar";
            cancelar.UseVisualStyleBackColor = true;
            cancelar.Click += cancelar_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(37, 14);
            label15.Name = "label15";
            label15.Size = new Size(116, 25);
            label15.TabIndex = 29;
            label15.Text = "Edit my data";
            // 
            // txtconfirmarcontra
            // 
            txtconfirmarcontra.Location = new Point(37, 280);
            txtconfirmarcontra.Name = "txtconfirmarcontra";
            txtconfirmarcontra.Size = new Size(194, 23);
            txtconfirmarcontra.TabIndex = 28;
            // 
            // txtcontra
            // 
            txtcontra.Location = new Point(37, 236);
            txtcontra.Name = "txtcontra";
            txtcontra.Size = new Size(194, 23);
            txtcontra.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(37, 262);
            label13.Name = "label13";
            label13.Size = new Size(110, 15);
            label13.TabIndex = 26;
            label13.Text = "Confirm password :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(37, 218);
            label14.Name = "label14";
            label14.Size = new Size(63, 15);
            label14.TabIndex = 25;
            label14.Text = "Password :";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(38, 191);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(193, 23);
            txtemail.TabIndex = 24;
            // 
            // txtlastname
            // 
            txtlastname.Location = new Point(38, 147);
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(193, 23);
            txtlastname.TabIndex = 23;
            // 
            // txtfirstname
            // 
            txtfirstname.Location = new Point(38, 103);
            txtfirstname.Name = "txtfirstname";
            txtfirstname.Size = new Size(193, 23);
            txtfirstname.TabIndex = 22;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(37, 60);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(194, 23);
            txtusername.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(37, 86);
            label9.Name = "label9";
            label9.Size = new Size(65, 15);
            label9.TabIndex = 19;
            label9.Text = "Firstname :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(38, 173);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 20;
            label10.Text = "Email :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(37, 42);
            label12.Name = "label12";
            label12.Size = new Size(66, 15);
            label12.TabIndex = 17;
            label12.Text = "Username :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(38, 129);
            label11.Name = "label11";
            label11.Size = new Size(64, 15);
            label11.TabIndex = 18;
            label11.Text = "Lastname :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(12, 0);
            label16.Name = "label16";
            label16.Size = new Size(98, 25);
            label16.TabIndex = 30;
            label16.Text = "My Profile";
            // 
            // Perfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 433);
            Controls.Add(label16);
            Controls.Add(panel1);
            Controls.Add(lblemail);
            Controls.Add(lblname);
            Controls.Add(lbllastname);
            Controls.Add(lbluser);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(perfilimage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Perfil";
            Text = "Perfil";
            Load += Perfil_Load;
            ((System.ComponentModel.ISupportInitialize)perfilimage).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox perfilimage;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private LinkLabel linkLabel1;
        private Label lblemail;
        private Label lblname;
        private Label lbllastname;
        private Label lbluser;
        private Panel panel1;
        private TextBox txtconfirmarcontra;
        private TextBox txtcontra;
        private Label label13;
        private Label label14;
        private TextBox txtemail;
        private TextBox txtlastname;
        private TextBox txtfirstname;
        private TextBox txtusername;
        private Label label9;
        private Label label10;
        private Label label12;
        private Label label11;
        private Label label15;
        private Label label16;
        private Button cancelar;
        private Button confirmar;
        private TextBox txtactualcontra;
        private Label label5;
    }
}