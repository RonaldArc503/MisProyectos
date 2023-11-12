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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            personalizardiseño();
        }
        private void personalizardiseño() 
        {
         panelsubmenu1.Visible = false;
         panelsubmenu2.Visible = false;
         panelsubmenu3.Visible = false;
        }

        private void hidesubmenu() 
        {
            if (panelsubmenu1.Visible == true)
                panelsubmenu1.Visible = false;
            if (panelsubmenu2.Visible == true)
                panelsubmenu2.Visible = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Perfil Dats = new Perfil();
            Dats.Show();
            Hide();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
