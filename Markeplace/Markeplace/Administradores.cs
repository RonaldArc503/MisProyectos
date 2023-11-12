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
    public partial class Administradores : Form
    {
        public Administradores()
        {
            InitializeComponent();

        }


        private void Administradores_Load(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Close();
        }


    }
}
