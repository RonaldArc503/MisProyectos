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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginda(object sender, PaintEventArgs e)
        {


        }

        private void panel3_Click(object sender, EventArgs e)
        {
            logeo Fm = new logeo();

            Hide();
            Fm.ShowDialog();
            Close();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            registro rt = new registro();
            Hide();

            rt.ShowDialog();
            Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //  private void panel2_Paint(object sender, PaintEventArgs e)
        //    {
        //        registro rt = new registro();


        //      rt.Show();

        //   }
    }
}
