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
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            inmueblesToolStripMenuItem = new ToolStripMenuItem();
            cocinaToolStripMenuItem = new ToolStripMenuItem();
            automovilesToolStripMenuItem = new ToolStripMenuItem();
            juguetesToolStripMenuItem = new ToolStripMenuItem();
            eléctronicosToolStripMenuItem = new ToolStripMenuItem();
            toolStripContainer1 = new ToolStripContainer();
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
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-1, 1);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1223, 87);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1166, 16);
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
            textBox1.Location = new Point(649, 27);
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
            // button1
            // 
            button1.BackColor = Color.FromArgb(23, 140, 112);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1024, 26);
            button1.Name = "button1";
            button1.Size = new Size(127, 36);
            button1.TabIndex = 1;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { inmueblesToolStripMenuItem, cocinaToolStripMenuItem, automovilesToolStripMenuItem, juguetesToolStripMenuItem, eléctronicosToolStripMenuItem });
            menuStrip1.Location = new Point(-1, 88);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(372, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // inmueblesToolStripMenuItem
            // 
            inmueblesToolStripMenuItem.Name = "inmueblesToolStripMenuItem";
            inmueblesToolStripMenuItem.Size = new Size(74, 20);
            inmueblesToolStripMenuItem.Text = "Inmuebles";
            // 
            // cocinaToolStripMenuItem
            // 
            cocinaToolStripMenuItem.Name = "cocinaToolStripMenuItem";
            cocinaToolStripMenuItem.Size = new Size(56, 20);
            cocinaToolStripMenuItem.Text = "Cocina";
            // 
            // automovilesToolStripMenuItem
            // 
            automovilesToolStripMenuItem.Name = "automovilesToolStripMenuItem";
            automovilesToolStripMenuItem.Size = new Size(86, 20);
            automovilesToolStripMenuItem.Text = "Automoviles";
            // 
            // juguetesToolStripMenuItem
            // 
            juguetesToolStripMenuItem.Name = "juguetesToolStripMenuItem";
            juguetesToolStripMenuItem.Size = new Size(65, 20);
            juguetesToolStripMenuItem.Text = "Juguetes";
            // 
            // eléctronicosToolStripMenuItem
            // 
            eléctronicosToolStripMenuItem.Name = "eléctronicosToolStripMenuItem";
            eléctronicosToolStripMenuItem.Size = new Size(83, 20);
            eléctronicosToolStripMenuItem.Text = "Eléctronicos";
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
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 229, 229);
            ClientSize = new Size(1223, 629);
            Controls.Add(menuStrip1);
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
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private MenuStrip menuStrip1;
        private ToolStripContainer toolStripContainer1;
        private ToolStripMenuItem inmueblesToolStripMenuItem;
        private ToolStripMenuItem cocinaToolStripMenuItem;
        private ToolStripMenuItem automovilesToolStripMenuItem;
        private ToolStripMenuItem juguetesToolStripMenuItem;
        private ToolStripMenuItem eléctronicosToolStripMenuItem;
    }
}