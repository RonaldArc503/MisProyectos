namespace Markeplace
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label2 = new Label();
            Btnbuscar = new Button();
            menuStrip1 = new MenuStrip();
            toolStripContainer1 = new ToolStripContainer();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            menuToolStripMenuItem = new ToolStripMenuItem();
            inmuebleToolStripMenuItem = new ToolStripMenuItem();
            cocinaToolStripMenuItem = new ToolStripMenuItem();
            electródomesticoToolStripMenuItem = new ToolStripMenuItem();
            electrónicaToolStripMenuItem = new ToolStripMenuItem();
            jugueteriaToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 176, 140);
            panel1.Controls.Add(menuStrip1);
            panel1.Controls.Add(Btnbuscar);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-1, 1);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1223, 87);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(829, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(13, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(404, 29);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(369, 33);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Perpetua", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(86, 29);
            label2.Name = "label2";
            label2.Size = new Size(167, 31);
            label2.TabIndex = 2;
            label2.Text = "Bambu forest";
            // 
            // Btnbuscar
            // 
            Btnbuscar.BackColor = Color.Transparent;
            Btnbuscar.BackgroundImage = (Image)resources.GetObject("Btnbuscar.BackgroundImage");
            Btnbuscar.BackgroundImageLayout = ImageLayout.Stretch;
            Btnbuscar.FlatAppearance.BorderColor = Color.FromArgb(26, 176, 140);
            Btnbuscar.FlatAppearance.BorderSize = 0;
            Btnbuscar.FlatStyle = FlatStyle.Flat;
            Btnbuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btnbuscar.ForeColor = Color.White;
            Btnbuscar.Location = new Point(404, 25);
            Btnbuscar.Name = "Btnbuscar";
            Btnbuscar.Size = new Size(40, 40);
            Btnbuscar.TabIndex = 1;
            Btnbuscar.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(298, 36);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(58, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "Opciones";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Size = new Size(150, 6);
            toolStripContainer1.Location = new Point(1072, 599);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(150, 31);
            toolStripContainer1.TabIndex = 2;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.BackColor = Color.White;
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inmuebleToolStripMenuItem, cocinaToolStripMenuItem, electródomesticoToolStripMenuItem, electrónicaToolStripMenuItem, jugueteriaToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menú";
            // 
            // inmuebleToolStripMenuItem
            // 
            inmuebleToolStripMenuItem.Name = "inmuebleToolStripMenuItem";
            inmuebleToolStripMenuItem.Size = new Size(180, 22);
            inmuebleToolStripMenuItem.Text = "Inmueble";
            // 
            // cocinaToolStripMenuItem
            // 
            cocinaToolStripMenuItem.Name = "cocinaToolStripMenuItem";
            cocinaToolStripMenuItem.Size = new Size(180, 22);
            cocinaToolStripMenuItem.Text = "Cocina";
            // 
            // electródomesticoToolStripMenuItem
            // 
            electródomesticoToolStripMenuItem.Name = "electródomesticoToolStripMenuItem";
            electródomesticoToolStripMenuItem.Size = new Size(180, 22);
            electródomesticoToolStripMenuItem.Text = "Electródomestico";
            // 
            // electrónicaToolStripMenuItem
            // 
            electrónicaToolStripMenuItem.Name = "electrónicaToolStripMenuItem";
            electrónicaToolStripMenuItem.Size = new Size(180, 22);
            electrónicaToolStripMenuItem.Text = "Electrónica";
            // 
            // jugueteriaToolStripMenuItem
            // 
            jugueteriaToolStripMenuItem.Name = "jugueteriaToolStripMenuItem";
            jugueteriaToolStripMenuItem.Size = new Size(180, 22);
            jugueteriaToolStripMenuItem.Text = "Jugueteria";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 229, 229);
            ClientSize = new Size(877, 629);
            Controls.Add(toolStripContainer1);
            Controls.Add(panel1);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += Inicio_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button Btnbuscar;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private MenuStrip menuStrip1;
        private ToolStripContainer toolStripContainer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem inmuebleToolStripMenuItem;
        private ToolStripMenuItem cocinaToolStripMenuItem;
        private ToolStripMenuItem electródomesticoToolStripMenuItem;
        private ToolStripMenuItem electrónicaToolStripMenuItem;
        private ToolStripMenuItem jugueteriaToolStripMenuItem;
    }
}