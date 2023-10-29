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
            Correo = new TextBox();
            Nombreusuario = new TextBox();
            label1 = new Label();
            Apellidousuario = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            Contrasena = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(50, 73);
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
            panel1.Location = new Point(549, 1);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(516, 632);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
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
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            // 
            // Correo
            // 
            Correo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Correo.ForeColor = Color.Gray;
            Correo.Location = new Point(42, 152);
            Correo.Multiline = true;
            Correo.Name = "Correo";
            Correo.Size = new Size(358, 37);
            Correo.TabIndex = 11;
            Correo.Tag = "";
            Correo.Text = "Correo electrónico";
            Correo.TextAlign = HorizontalAlignment.Center;
            Correo.Enter += Correo_Enter;
            Correo.Leave += Correo_Leave;
            // 
            // Nombreusuario
            // 
            Nombreusuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Nombreusuario.ForeColor = Color.Gray;
            Nombreusuario.Location = new Point(42, 109);
            Nombreusuario.Multiline = true;
            Nombreusuario.Name = "Nombreusuario";
            Nombreusuario.Size = new Size(165, 37);
            Nombreusuario.TabIndex = 10;
            Nombreusuario.Text = "Nombres";
            Nombreusuario.TextAlign = HorizontalAlignment.Center;
            Nombreusuario.Enter += Nombreusuario_Enter;
            Nombreusuario.Leave += Nombreusuario_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 28);
            label1.Name = "label1";
            label1.Size = new Size(163, 50);
            label1.TabIndex = 8;
            label1.Text = "Registro";
            // 
            // Apellidousuario
            // 
            Apellidousuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Apellidousuario.ForeColor = Color.Gray;
            Apellidousuario.Location = new Point(235, 109);
            Apellidousuario.Multiline = true;
            Apellidousuario.Name = "Apellidousuario";
            Apellidousuario.Size = new Size(165, 37);
            Apellidousuario.TabIndex = 15;
            Apellidousuario.Text = "Apellidos";
            Apellidousuario.TextAlign = HorizontalAlignment.Center;
            Apellidousuario.Enter += Apellidousuario_Enter;
            Apellidousuario.Leave += Apellidousuario_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(42, 245);
            label2.Name = "label2";
            label2.Size = new Size(196, 25);
            label2.TabIndex = 16;
            label2.Text = "Fecha de Nacimiento";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Masculino", "Femenino", "Otro" });
            comboBox1.Location = new Point(42, 348);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 18;
            // 
            // Contrasena
            // 
            Contrasena.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Contrasena.ForeColor = Color.Gray;
            Contrasena.Location = new Point(42, 195);
            Contrasena.Multiline = true;
            Contrasena.Name = "Contrasena";
            Contrasena.Size = new Size(358, 37);
            Contrasena.TabIndex = 20;
            Contrasena.Tag = "";
            Contrasena.Text = "Contraseña";
            Contrasena.TextAlign = HorizontalAlignment.Center;
            Contrasena.Enter += Contrasena_Enter;
            Contrasena.Leave += Contrasena_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(42, 320);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 21;
            label3.Text = "Género";
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
            label4.Click += label4_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            comboBox2.Location = new Point(42, 282);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(69, 23);
            comboBox2.TabIndex = 23;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Enero", "Febrero", "Marzo", "Abril ", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" });
            comboBox3.Location = new Point(117, 282);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(69, 23);
            comboBox3.TabIndex = 24;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "" });
            comboBox4.Location = new Point(194, 282);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(69, 23);
            comboBox4.TabIndex = 25;
            // 
            // registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 633);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Contrasena);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(Apellidousuario);
            Controls.Add(Login);
            Controls.Add(Correo);
            Controls.Add(Nombreusuario);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "registro";
            Text = "registro";
            Load += registro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button Login;
        private TextBox Correo;
        private TextBox Nombreusuario;
        private Label label1;
        private TextBox Apellidousuario;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox Contrasena;
        private Label label3;
        private Label label4;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
    }
}