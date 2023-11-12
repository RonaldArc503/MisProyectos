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
            button1 = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nametable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lastntable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            correotable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            usertable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            calvetable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            borntable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(25, 29);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(195, 55);
            button1.TabIndex = 0;
            button1.Text = "Usuarios registrados";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(245, 547);
            panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { id, nametable, lastntable, correotable, usertable, calvetable, borntable });
            dataGridView1.Location = new System.Drawing.Point(261, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(727, 230);
            dataGridView1.TabIndex = 2;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            // 
            // nametable
            // 
            nametable.HeaderText = "Nombre";
            nametable.Name = "nametable";
            // 
            // lastntable
            // 
            lastntable.HeaderText = "Apellido";
            lastntable.Name = "lastntable";
            // 
            // correotable
            // 
            correotable.HeaderText = "Correo";
            correotable.Name = "correotable";
            // 
            // usertable
            // 
            usertable.HeaderText = "Usuario";
            usertable.Name = "usertable";
            // 
            // calvetable
            // 
            calvetable.HeaderText = "Clave";
            calvetable.Name = "calvetable";
            // 
            // borntable
            // 
            borntable.HeaderText = "Fecha de Nacimiento";
            borntable.Name = "borntable";
            // 
            // Administradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 540);
            this.Controls.Add(dataGridView1);
            this.Controls.Add(panel1);
            this.Name = "Administradores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administradores";
            this.Load += this.Administradores_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            this.ResumeLayout(false);
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
    }
}