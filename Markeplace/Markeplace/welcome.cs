using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Markeplace
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }
     

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Form1 Fm = new Form1();

            this.Hide();
            Fm.ShowDialog();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            registro rt = new registro();

            this.Hide();
            rt.ShowDialog();
            this.Close();
        }
    }
}
