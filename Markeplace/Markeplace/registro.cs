using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Markeplace
{
    public partial class registro : Form
    {

        public registro()
        {
            InitializeComponent();


        }
        //sql conectado
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-LALT64T; database=Marketplace; integrated security= true ");

        private void RegistrarBD(object sender, EventArgs e)
        {
            conexion.Open();

            string name = namebox.Text;
            string lastn = lastnamebox.Text;
            string email = emailbox.Text;
            string user = userbox.Text;
            string clave = clavebox.Text;

            string consulta = "INSERT INTO Usuarios (Nombre, Apellido, Correo, Usuario,Clave) " +
                                "VALUES (@Name, @Lastn, @Email, @User,@Clave)";
            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                comando.Parameters.AddWithValue("@Name", name);
                comando.Parameters.AddWithValue("@Lastn", lastn);
                comando.Parameters.AddWithValue("@Email", email);
                comando.Parameters.AddWithValue("@User", user);
                comando.Parameters.AddWithValue("@Clave", clave);
                comando.ExecuteNonQuery();

                MessageBox.Show("Usted se ha Registrado, Gracias.");
            }
        }








        private void registro_Load(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Nombreusuario_Enter(object sender, EventArgs e)
        {
            if (namebox.Text == "Nombres")
            {
                namebox.Text = "";
                namebox.ForeColor = Color.Black;
            }

        }

        private void Nombreusuario_Leave(object sender, EventArgs e)
        {
            if (namebox.Text == "")
            {
                namebox.Text = "Nombres";
                namebox.ForeColor = Color.Gray;
            }
        }

        private void Apellidousuario_Enter(object sender, EventArgs e)
        {
            if (lastnamebox.Text == "Apellidos")
            {
                lastnamebox.Text = "";
                lastnamebox.ForeColor = Color.Black;
            }
        }

        private void Apellidousuario_Leave(object sender, EventArgs e)
        {
            if (lastnamebox.Text == "")
            {
                lastnamebox.Text = "Apellidos";
                lastnamebox.ForeColor = Color.Gray;
            }
        }

        private void Correo_Enter(object sender, EventArgs e)
        {
            if (emailbox.Text == "Correo electrónico")
            {
                emailbox.Text = "";
                emailbox.ForeColor = Color.Black;
            }
        }

        private void Correo_Leave(object sender, EventArgs e)
        {
            if (emailbox.Text == "")
            {
                emailbox.Text = "Correo electrónico";
                emailbox.ForeColor = Color.Gray;
            }
        }

        private void Contrasena_Enter(object sender, EventArgs e)
        {
            if (clavebox.Text == "Contraseña")
            {
                clavebox.Text = "";
                clavebox.ForeColor = Color.Black;
            }
        }

        private void Contrasena_Leave(object sender, EventArgs e)
        {
            if (clavebox.Text == "")
            {
                clavebox.Text = "Contraseña";
                clavebox.ForeColor = Color.Gray;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 Fm = new Form1();

            this.Hide();
            Fm.ShowDialog();
            this.Close();

        }





        private void Apellidousuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
