namespace Markeplace
{
    partial class Administradores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administradores));
            userbox = new TextBox();
            clavebox = new TextBox();
            lastnamebox = new TextBox();
            emailbox = new TextBox();
            namebox = new TextBox();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            button2 = new Button();
            idbox = new TextBox();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            button4 = new Button();
            usuariosview = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            usuariosview.SuspendLayout();
            SuspendLayout();
            // 
            // userbox
            // 
            userbox.BackColor = Color.White;
            userbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userbox.ForeColor = Color.Black;
            userbox.Location = new Point(102, 129);
            userbox.Margin = new Padding(0);
            userbox.Multiline = true;
            userbox.Name = "userbox";
            userbox.Size = new Size(317, 37);
            userbox.TabIndex = 32;
            userbox.Tag = "";
            userbox.TextAlign = HorizontalAlignment.Center;
            // 
            // clavebox
            // 
            clavebox.BackColor = Color.White;
            clavebox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clavebox.ForeColor = Color.Black;
            clavebox.Location = new Point(419, 129);
            clavebox.Margin = new Padding(0);
            clavebox.Multiline = true;
            clavebox.Name = "clavebox";
            clavebox.Size = new Size(229, 37);
            clavebox.TabIndex = 31;
            clavebox.Tag = "";
            clavebox.TextAlign = HorizontalAlignment.Center;
            clavebox.TextChanged += clavebox_TextChanged;
            // 
            // lastnamebox
            // 
            lastnamebox.BackColor = Color.White;
            lastnamebox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastnamebox.ForeColor = Color.Black;
            lastnamebox.Location = new Point(419, 55);
            lastnamebox.Margin = new Padding(0);
            lastnamebox.Multiline = true;
            lastnamebox.Name = "lastnamebox";
            lastnamebox.Size = new Size(229, 37);
            lastnamebox.TabIndex = 30;
            lastnamebox.TextAlign = HorizontalAlignment.Center;
            // 
            // emailbox
            // 
            emailbox.BackColor = Color.White;
            emailbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailbox.ForeColor = Color.Black;
            emailbox.Location = new Point(648, 55);
            emailbox.Margin = new Padding(0);
            emailbox.Multiline = true;
            emailbox.Name = "emailbox";
            emailbox.Size = new Size(326, 37);
            emailbox.TabIndex = 29;
            emailbox.Tag = "";
            emailbox.TextAlign = HorizontalAlignment.Center;
            // 
            // namebox
            // 
            namebox.BackColor = Color.White;
            namebox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            namebox.ForeColor = Color.Black;
            namebox.Location = new Point(193, 55);
            namebox.Margin = new Padding(0);
            namebox.Multiline = true;
            namebox.Name = "namebox";
            namebox.Size = new Size(226, 37);
            namebox.TabIndex = 28;
            namebox.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(425, 9);
            label1.Name = "label1";
            label1.Size = new Size(308, 50);
            label1.TabIndex = 27;
            label1.Text = "Administradores";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(102, 178);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(872, 230);
            dataGridView2.TabIndex = 33;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // button2
            // 
            button2.Location = new Point(22, 77);
            button2.Name = "button2";
            button2.Size = new Size(150, 40);
            button2.TabIndex = 34;
            button2.Text = "Ver datos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += llenardatos_Click;
            // 
            // idbox
            // 
            idbox.BackColor = Color.White;
            idbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idbox.ForeColor = Color.Black;
            idbox.Location = new Point(102, 55);
            idbox.Margin = new Padding(0);
            idbox.Multiline = true;
            idbox.Name = "idbox";
            idbox.Size = new Size(91, 37);
            idbox.TabIndex = 35;
            idbox.TextAlign = HorizontalAlignment.Center;
            // 
            // button3
            // 
            button3.Location = new Point(22, 123);
            button3.Name = "button3";
            button3.Size = new Size(150, 39);
            button3.TabIndex = 36;
            button3.Text = "Actualizar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += actualizar_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(191, 18);
            textBox1.Margin = new Padding(0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 37);
            textBox1.TabIndex = 37;
            textBox1.Text = "Nombre";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(419, 18);
            textBox2.Margin = new Padding(0);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(229, 37);
            textBox2.TabIndex = 38;
            textBox2.Text = "Apellido";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = Color.Black;
            textBox3.Location = new Point(648, 18);
            textBox3.Margin = new Padding(0);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(326, 37);
            textBox3.TabIndex = 39;
            textBox3.Text = "Correo";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.ForeColor = Color.Black;
            textBox4.Location = new Point(102, 92);
            textBox4.Margin = new Padding(0);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(317, 37);
            textBox4.TabIndex = 40;
            textBox4.Text = "Usuario";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.White;
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.ForeColor = Color.Black;
            textBox5.Location = new Point(419, 92);
            textBox5.Margin = new Padding(0);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(229, 37);
            textBox5.TabIndex = 41;
            textBox5.Text = "Clave";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.White;
            textBox6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.ForeColor = Color.Black;
            textBox6.Location = new Point(102, 18);
            textBox6.Margin = new Padding(0);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(91, 37);
            textBox6.TabIndex = 42;
            textBox6.Text = "ID";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.White;
            textBox7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox7.ForeColor = Color.Black;
            textBox7.Location = new Point(648, 92);
            textBox7.Margin = new Padding(0);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(326, 37);
            textBox7.TabIndex = 43;
            textBox7.Text = "Fecha de nacimiento";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.White;
            textBox8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.ForeColor = Color.Black;
            textBox8.Location = new Point(648, 129);
            textBox8.Margin = new Padding(0);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(326, 37);
            textBox8.TabIndex = 44;
            textBox8.Tag = "";
            textBox8.TextAlign = HorizontalAlignment.Center;
            // 
            // button4
            // 
            button4.Location = new Point(22, 168);
            button4.Name = "button4";
            button4.Size = new Size(207, 40);
            button4.TabIndex = 45;
            button4.Text = "Ver Usuarios";
            button4.UseVisualStyleBackColor = true;
            // 
            // usuariosview
            // 
            usuariosview.BackColor = Color.FromArgb(33, 33, 33);
            usuariosview.Controls.Add(panel2);
            usuariosview.Controls.Add(textBox6);
            usuariosview.Controls.Add(namebox);
            usuariosview.Controls.Add(textBox8);
            usuariosview.Controls.Add(emailbox);
            usuariosview.Controls.Add(textBox7);
            usuariosview.Controls.Add(lastnamebox);
            usuariosview.Controls.Add(clavebox);
            usuariosview.Controls.Add(textBox5);
            usuariosview.Controls.Add(userbox);
            usuariosview.Controls.Add(textBox4);
            usuariosview.Controls.Add(dataGridView2);
            usuariosview.Controls.Add(textBox3);
            usuariosview.Controls.Add(idbox);
            usuariosview.Controls.Add(textBox2);
            usuariosview.Controls.Add(textBox1);
            usuariosview.Location = new Point(273, 77);
            usuariosview.Name = "usuariosview";
            usuariosview.Size = new Size(990, 421);
            usuariosview.TabIndex = 46;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(69, 211, 178);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(83, 421);
            panel2.TabIndex = 45;
            // 
            // Administradores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 540);
            Controls.Add(usuariosview);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Administradores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administradores";
            Load += Administradores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            usuariosview.ResumeLayout(false);
            usuariosview.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.CodeDom.CodeTypeReference button1;
        private System.CodeDom.CodeTypeReference panel1;
        private System.CodeDom.CodeTypeReference dataGridView1;
        private System.CodeDom.CodeTypeReference id;
        private System.CodeDom.CodeTypeReference nametable;
        private System.CodeDom.CodeTypeReference lastntable;
        private System.CodeDom.CodeTypeReference correotable;
        private System.CodeDom.CodeTypeReference usertable;
        private System.CodeDom.CodeTypeReference calvetable;
        private System.CodeDom.CodeTypeReference borntable;
        private TextBox userbox;
        private TextBox clavebox;
        private TextBox lastnamebox;
        private TextBox emailbox;
        private TextBox namebox;
        private Label label1;
        private DataGridView dataGridView2;
        private Button button2;
        private TextBox idbox;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Button button4;
        private Panel usuariosview;
        private Panel panel2;
    }
}