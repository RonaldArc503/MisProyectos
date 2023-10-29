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
    public partial class registro : Form
    {

        public registro()
        {
            InitializeComponent();

        }

        private void registro_Load(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Nombreusuario_Enter(object sender, EventArgs e)
        {
            if (Nombreusuario.Text == "Nombres")
            {
                Nombreusuario.Text = "";
                Nombreusuario.ForeColor = Color.Black;
            }

        }

        private void Nombreusuario_Leave(object sender, EventArgs e)
        {
            if (Nombreusuario.Text == "")
            {
                Nombreusuario.Text = "Nombres";
                Nombreusuario.ForeColor = Color.Gray;
            }
        }

        private void Apellidousuario_Enter(object sender, EventArgs e)
        {
            if (Apellidousuario.Text == "Apellidos")
            {
                Apellidousuario.Text = "";
                Apellidousuario.ForeColor = Color.Black;
            }
        }

        private void Apellidousuario_Leave(object sender, EventArgs e)
        {
            if (Apellidousuario.Text == "")
            {
                Apellidousuario.Text = "Apellidos";
                Apellidousuario.ForeColor = Color.Gray;
            }
        }

        private void Correo_Enter(object sender, EventArgs e)
        {
            if (Correo.Text == "Correo electrónico")
            {
                Correo.Text = "";
                Correo.ForeColor = Color.Black;
            }
        }

        private void Correo_Leave(object sender, EventArgs e)
        {
            if (Correo.Text == "")
            {
                Correo.Text = "Correo electrónico";
                Correo.ForeColor = Color.Gray;
            }
        }

        private void Contrasena_Enter(object sender, EventArgs e)
        {
            if (Contrasena.Text == "Contraseña")
            {
                Contrasena.Text = "";
                Contrasena.ForeColor = Color.Black;
            }
        }

        private void Contrasena_Leave(object sender, EventArgs e)
        {
            if (Contrasena.Text == "")
            {
                Contrasena.Text = "Contraseña";
                Contrasena.ForeColor = Color.Gray;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 Fm = new Form1();
            Fm.Show();
            Hide();
            
        }
    }
}
