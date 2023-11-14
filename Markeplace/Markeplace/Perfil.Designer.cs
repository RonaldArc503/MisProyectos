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
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)perfilimage).BeginInit();
            SuspendLayout();
            // 
            // perfilimage
            // 
            perfilimage.BackColor = Color.Transparent;
            perfilimage.BackgroundImageLayout = ImageLayout.None;
            perfilimage.Image = (Image)resources.GetObject("perfilimage.Image");
            perfilimage.Location = new Point(12, 12);
            perfilimage.Name = "perfilimage";
            perfilimage.Size = new Size(56, 57);
            perfilimage.SizeMode = PictureBoxSizeMode.StretchImage;
            perfilimage.TabIndex = 3;
            perfilimage.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(101, 384);
            button1.Name = "button1";
            button1.Size = new Size(190, 47);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 29);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
         
            // 
            // Perfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 492);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(perfilimage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Perfil";
            Text = "Perfil";
            ((System.ComponentModel.ISupportInitialize)perfilimage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox perfilimage;
        private Button button1;
        private Label label1;
    }
}