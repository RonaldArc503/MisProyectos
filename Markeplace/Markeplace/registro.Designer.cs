namespace Markeplace
{
    partial class registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registro));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            Login = new Button();
            emailbox = new TextBox();
            namebox = new TextBox();
            label1 = new Label();
            lastnamebox = new TextBox();
            label2 = new Label();
            clavebox = new TextBox();
            label4 = new Label();
            daybox = new ComboBox();
            monthbox = new ComboBox();
            yearbox = new ComboBox();
            userbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(73, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 400);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 176, 140);
            panel1.Controls.Add(pictureBox1);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(536, -1);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(527, 634);
            panel1.TabIndex = 1;
            // 
            // Login
            // 
            Login.BackColor = Color.FromArgb(26, 176, 140);
            Login.Font = new Font("SimSun-ExtB", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Login.ForeColor = Color.White;
            Login.Location = new Point(174, 423);
            Login.Name = "Login";
            Login.Size = new Size(157, 51);
            Login.TabIndex = 13;
            Login.Text = "Registrar";
            Login.UseVisualStyleBackColor = false;
            Login.Click += RegistrarBD;
            // 
            // emailbox
            // 
            emailbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailbox.ForeColor = Color.Gray;
            emailbox.Location = new Point(42, 152);
            emailbox.Multiline = true;
            emailbox.Name = "emailbox";
            emailbox.Size = new Size(358, 37);
            emailbox.TabIndex = 11;
            emailbox.Tag = "";
            emailbox.Text = "Correo electrónico";
            emailbox.TextAlign = HorizontalAlignment.Center;
            emailbox.Enter += Correo_Enter;
            emailbox.Leave += Correo_Leave;
            // 
            // namebox
            // 
            namebox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            namebox.ForeColor = Color.Gray;
            namebox.Location = new Point(42, 109);
            namebox.Multiline = true;
            namebox.Name = "namebox";
            namebox.Size = new Size(165, 37);
            namebox.TabIndex = 10;
            namebox.Text = "Nombre";
            namebox.TextAlign = HorizontalAlignment.Center;
            namebox.Enter += Nombreusuario_Enter;
            namebox.Leave += Nombreusuario_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(147, 29);
            label1.Name = "label1";
            label1.Size = new Size(163, 50);
            label1.TabIndex = 8;
            label1.Text = "Registro";
            // 
            // lastnamebox
            // 
            lastnamebox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastnamebox.ForeColor = Color.Gray;
            lastnamebox.Location = new Point(235, 109);
            lastnamebox.Multiline = true;
            lastnamebox.Name = "lastnamebox";
            lastnamebox.Size = new Size(165, 37);
            lastnamebox.TabIndex = 15;
            lastnamebox.Text = "Apellido";
            lastnamebox.TextAlign = HorizontalAlignment.Center;
            lastnamebox.Enter += Apellidousuario_Enter;
            lastnamebox.Leave += Contrasena_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(42, 299);
            label2.Name = "label2";
            label2.Size = new Size(196, 25);
            label2.TabIndex = 16;
            label2.Text = "Fecha de Nacimiento";
            // 
            // clavebox
            // 
            clavebox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clavebox.ForeColor = Color.Gray;
            clavebox.Location = new Point(42, 244);
            clavebox.Multiline = true;
            clavebox.Name = "clavebox";
            clavebox.Size = new Size(358, 37);
            clavebox.TabIndex = 20;
            clavebox.Tag = "";
            clavebox.Text = "Contraseña";
            clavebox.TextAlign = HorizontalAlignment.Center;
            clavebox.Enter += Contrasena_Enter;
            clavebox.Leave += Contrasena_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 0, 192);
            label4.Location = new Point(194, 477);
            label4.Name = "label4";
            label4.Size = new Size(132, 17);
            label4.TabIndex = 22;
            label4.Text = "Ya tienes una cuenta?";
            label4.Click += LoginYatengocuenta;
            // 
            // daybox
            // 
            daybox.FormattingEnabled = true;
            daybox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            daybox.Location = new Point(42, 336);
            daybox.Name = "daybox";
            daybox.Size = new Size(69, 23);
            daybox.TabIndex = 23;
            // 
            // monthbox
            // 
            monthbox.FormattingEnabled = true;
            monthbox.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            monthbox.Location = new Point(117, 336);
            monthbox.Name = "monthbox";
            monthbox.Size = new Size(69, 23);
            monthbox.TabIndex = 24;
            // 
            // yearbox
            // 
            yearbox.FormattingEnabled = true;
            yearbox.Items.AddRange(new object[] { "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005" });
            yearbox.Location = new Point(194, 336);
            yearbox.Name = "yearbox";
            yearbox.Size = new Size(69, 23);
            yearbox.TabIndex = 25;
            // 
            // userbox
            // 
            userbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userbox.ForeColor = Color.Gray;
            userbox.Location = new Point(42, 201);
            userbox.Multiline = true;
            userbox.Name = "userbox";
            userbox.Size = new Size(358, 37);
            userbox.TabIndex = 26;
            userbox.Tag = "";
            userbox.Text = "Usuario";
            userbox.TextAlign = HorizontalAlignment.Center;
            userbox.Enter += user_Enter;
            userbox.Leave += User_Leave;
            // 
            // registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1063, 633);
            Controls.Add(userbox);
            Controls.Add(yearbox);
            Controls.Add(monthbox);
            Controls.Add(daybox);
            Controls.Add(label4);
            Controls.Add(clavebox);
            Controls.Add(label2);
            Controls.Add(lastnamebox);
            Controls.Add(Login);
            Controls.Add(emailbox);
            Controls.Add(namebox);
            Controls.Add(label1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "registro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button Login;
        private TextBox emailbox;
        private TextBox namebox;
        private Label label1;
        private TextBox lastnamebox;
        private Label label2;
        private TextBox clavebox;
        private Label label4;
        private ComboBox daybox;
        private ComboBox monthbox;
        private ComboBox yearbox;
        private TextBox userbox;
    }
}