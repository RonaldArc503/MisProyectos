namespace Markeplace
{
    partial class Formulario_de_ayuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario_de_ayuda));
            pnlprgntas = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtperfil = new TextBox();
            txtcompra = new TextBox();
            pnlfrecuentes = new Panel();
            txtfrecuentes = new TextBox();
            pnlprgntas.SuspendLayout();
            pnlfrecuentes.SuspendLayout();
            SuspendLayout();
            // 
            // pnlprgntas
            // 
            pnlprgntas.BackColor = Color.FromArgb(47, 88, 157);
            pnlprgntas.Controls.Add(button3);
            pnlprgntas.Controls.Add(button2);
            pnlprgntas.Controls.Add(button1);
            pnlprgntas.Dock = DockStyle.Left;
            pnlprgntas.Location = new Point(0, 0);
            pnlprgntas.Name = "pnlprgntas";
            pnlprgntas.Size = new Size(200, 450);
            pnlprgntas.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(24, 210);
            button3.Name = "button3";
            button3.Size = new Size(153, 23);
            button3.TabIndex = 2;
            button3.Text = "Perfil";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(24, 159);
            button2.Name = "button2";
            button2.Size = new Size(153, 23);
            button2.TabIndex = 1;
            button2.Text = "Interfaz de compra";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(24, 102);
            button1.Name = "button1";
            button1.Size = new Size(153, 23);
            button1.TabIndex = 0;
            button1.Text = "Preguntas frecuentes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtperfil
            // 
            txtperfil.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtperfil.Location = new Point(40, 137);
            txtperfil.Multiline = true;
            txtperfil.Name = "txtperfil";
            txtperfil.Size = new Size(475, 134);
            txtperfil.TabIndex = 0;
            txtperfil.Text = "En la opción de perfil podras encontrar un menú donde podras ver tu información y \r\ntambien podras editar dicha información,  no obstante esto solo se podra realizar una vez al mes.";
            txtperfil.Visible = false;
            // 
            // txtcompra
            // 
            txtcompra.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtcompra.Location = new Point(40, 34);
            txtcompra.Multiline = true;
            txtcompra.Name = "txtcompra";
            txtcompra.Size = new Size(499, 336);
            txtcompra.TabIndex = 0;
            txtcompra.Text = resources.GetString("txtcompra.Text");
            txtcompra.Visible = false;
            // 
            // pnlfrecuentes
            // 
            pnlfrecuentes.BackColor = Color.FromArgb(9, 36, 70);
            pnlfrecuentes.Controls.Add(txtperfil);
            pnlfrecuentes.Controls.Add(txtcompra);
            pnlfrecuentes.Controls.Add(txtfrecuentes);
            pnlfrecuentes.Dock = DockStyle.Fill;
            pnlfrecuentes.Location = new Point(200, 0);
            pnlfrecuentes.Name = "pnlfrecuentes";
            pnlfrecuentes.Size = new Size(600, 450);
            pnlfrecuentes.TabIndex = 1;
            // 
            // txtfrecuentes
            // 
            txtfrecuentes.BackColor = Color.White;
            txtfrecuentes.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtfrecuentes.ForeColor = Color.Black;
            txtfrecuentes.Location = new Point(40, 34);
            txtfrecuentes.Multiline = true;
            txtfrecuentes.Name = "txtfrecuentes";
            txtfrecuentes.Size = new Size(529, 372);
            txtfrecuentes.TabIndex = 0;
            txtfrecuentes.Text = resources.GetString("txtfrecuentes.Text");
            txtfrecuentes.Visible = false;
            // 
            // Formulario_de_ayuda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 99, 136);
            ClientSize = new Size(800, 450);
            Controls.Add(pnlfrecuentes);
            Controls.Add(pnlprgntas);
            Name = "Formulario_de_ayuda";
            Text = "Formulario_de_ayuda";
            pnlprgntas.ResumeLayout(false);
            pnlfrecuentes.ResumeLayout(false);
            pnlfrecuentes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlprgntas;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel pnlfrecuentes;
        private TextBox txtfrecuentes;
        private Panel panelinterfaz;
        private TextBox txtcompra;
        private TextBox txtperfil;
    }
}