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
    public partial class Formulario_de_ayuda : Form
    {
        public Formulario_de_ayuda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtfrecuentes.Visible = true;
            txtperfil.Visible = false;
            txtcompra.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtcompra.Visible = true;
            txtfrecuentes.Visible = false;
            txtperfil.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtperfil.Visible = true;
            txtcompra.Visible = false;
            txtfrecuentes.Visible = false;
        }


    }
}
