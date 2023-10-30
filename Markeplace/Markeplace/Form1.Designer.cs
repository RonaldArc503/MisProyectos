namespace Markeplace
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            Usuario = new TextBox();
            Contrasena = new TextBox();
            label3 = new Label();
            label4 = new Label();
            Login = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 176, 140);
            panel1.Controls.Add(pictureBox1);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(-2, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(539, 638);
            panel1.TabIndex = 0;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(554, 125);
            label1.Name = "label1";
            label1.Size = new Size(121, 50);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun-ExtB", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(579, 227);
            label2.Name = "label2";
            label2.Size = new Size(70, 24);
            label2.TabIndex = 2;
            label2.Text = "User:";
            // 
            // Usuario
            // 
            Usuario.Font = new Font("SimSun-ExtB", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Usuario.Location = new Point(579, 254);
            Usuario.Multiline = true;
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(409, 37);
            Usuario.TabIndex = 3;
            Usuario.TextChanged += textBox1_TextChanged;
            // 
            // Contrasena
            // 
            Contrasena.Font = new Font("SimSun-ExtB", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Contrasena.Location = new Point(579, 348);
            Contrasena.Multiline = true;
            Contrasena.Name = "Contrasena";
            Contrasena.Size = new Size(409, 37);
            Contrasena.TabIndex = 4;
            Contrasena.Tag = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun-ExtB", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(579, 321);
            label3.Name = "label3";
            label3.Size = new Size(118, 24);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 0, 192);
            label4.Location = new Point(913, 417);
            label4.Name = "label4";
            label4.Size = new Size(112, 17);
            label4.TabIndex = 6;
            label4.Text = "No tienes cuenta?";
            label4.Click += label4_Click;
            // 
            // Login
            // 
            Login.BackColor = Color.FromArgb(26, 176, 140);
            Login.Font = new Font("SimSun-ExtB", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Login.ForeColor = Color.White;
            Login.Location = new Point(717, 521);
            Login.Name = "Login";
            Login.Size = new Size(157, 51);
            Login.TabIndex = 7;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1063, 633);
            Controls.Add(Login);
            Controls.Add(label3);
            Controls.Add(Contrasena);
            Controls.Add(Usuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox Usuario;
        private TextBox Contrasena;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Button Login;
    }
}