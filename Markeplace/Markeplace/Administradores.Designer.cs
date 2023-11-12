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
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // userbox
            // 
            userbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userbox.ForeColor = Color.Gray;
            userbox.Location = new Point(336, 193);
            userbox.Margin = new Padding(0);
            userbox.Multiline = true;
            userbox.Name = "userbox";
            userbox.Size = new Size(278, 37);
            userbox.TabIndex = 32;
            userbox.Tag = "";
            userbox.TextAlign = HorizontalAlignment.Center;
            // 
            // clavebox
            // 
            clavebox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clavebox.ForeColor = Color.Gray;
            clavebox.Location = new Point(614, 193);
            clavebox.Margin = new Padding(0);
            clavebox.Multiline = true;
            clavebox.Name = "clavebox";
            clavebox.Size = new Size(523, 37);
            clavebox.TabIndex = 31;
            clavebox.Tag = "";
            clavebox.TextAlign = HorizontalAlignment.Center;
            clavebox.TextChanged += clavebox_TextChanged;
            // 
            // lastnamebox
            // 
            lastnamebox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastnamebox.ForeColor = Color.Gray;
            lastnamebox.Location = new Point(614, 119);
            lastnamebox.Margin = new Padding(0);
            lastnamebox.Multiline = true;
            lastnamebox.Name = "lastnamebox";
            lastnamebox.Size = new Size(187, 37);
            lastnamebox.TabIndex = 30;
            lastnamebox.TextAlign = HorizontalAlignment.Center;
            // 
            // emailbox
            // 
            emailbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailbox.ForeColor = Color.Gray;
            emailbox.Location = new Point(779, 119);
            emailbox.Margin = new Padding(0);
            emailbox.Multiline = true;
            emailbox.Name = "emailbox";
            emailbox.Size = new Size(358, 37);
            emailbox.TabIndex = 29;
            emailbox.Tag = "";
            emailbox.TextAlign = HorizontalAlignment.Center;
            // 
            // namebox
            // 
            namebox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            namebox.ForeColor = Color.Gray;
            namebox.Location = new Point(427, 119);
            namebox.Margin = new Padding(0);
            namebox.Multiline = true;
            namebox.Name = "namebox";
            namebox.Size = new Size(187, 37);
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
            dataGridView2.Location = new Point(336, 392);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(872, 150);
            dataGridView2.TabIndex = 33;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // button2
            // 
            button2.Location = new Point(22, 42);
            button2.Name = "button2";
            button2.Size = new Size(150, 40);
            button2.TabIndex = 34;
            button2.Text = "Ver datos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += llenardatos_Click;
            // 
            // idbox
            // 
            idbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idbox.ForeColor = Color.Gray;
            idbox.Location = new Point(336, 119);
            idbox.Margin = new Padding(0);
            idbox.Multiline = true;
            idbox.Name = "idbox";
            idbox.Size = new Size(91, 37);
            idbox.TabIndex = 35;
            idbox.TextAlign = HorizontalAlignment.Center;
            // 
            // button3
            // 
            button3.Location = new Point(22, 88);
            button3.Name = "button3";
            button3.Size = new Size(150, 39);
            button3.TabIndex = 36;
            button3.Text = "Actualizar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += actualizar_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(425, 82);
            textBox1.Margin = new Padding(0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 37);
            textBox1.TabIndex = 37;
            textBox1.Text = "Nombre";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(614, 82);
            textBox2.Margin = new Padding(0);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 37);
            textBox2.TabIndex = 38;
            textBox2.Text = "Apellido";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = Color.Black;
            textBox3.Location = new Point(801, 82);
            textBox3.Margin = new Padding(0);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(336, 37);
            textBox3.TabIndex = 39;
            textBox3.Text = "Correo";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.ForeColor = Color.Black;
            textBox4.Location = new Point(336, 156);
            textBox4.Margin = new Padding(0);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(278, 37);
            textBox4.TabIndex = 40;
            textBox4.Text = "Usuario";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.ForeColor = Color.Black;
            textBox5.Location = new Point(614, 156);
            textBox5.Margin = new Padding(0);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(523, 37);
            textBox5.TabIndex = 41;
            textBox5.Text = "Clave";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.ForeColor = Color.Black;
            textBox6.Location = new Point(336, 82);
            textBox6.Margin = new Padding(0);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(91, 37);
            textBox6.TabIndex = 42;
            textBox6.Text = "ID";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // Administradores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 540);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(idbox);
            Controls.Add(button2);
            Controls.Add(dataGridView2);
            Controls.Add(userbox);
            Controls.Add(clavebox);
            Controls.Add(lastnamebox);
            Controls.Add(emailbox);
            Controls.Add(namebox);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Administradores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administradores";
            Load += Administradores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
    }
}