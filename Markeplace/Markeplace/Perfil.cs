using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Markeplace
{
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }

        public void MostrarNombreApellido(string nombre, string apellido)
        {
            //   label1.Text = $"Nombre: {nombre} {apellido}";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void Perfil_Load(object sender, EventArgs e)
        {

        }
        private void loadUserData()
        {
            try
            {
                string connectionString = "Server=DESKTOP-LALT64T; database=Markeplace; integrated security= true ";
                string usuario = lbluser.Text;
                string nombre = lblname.Text;
                string apellido = lbllastname.Text;
                string correo = lblemail.Text;
                string user = txtusername.Text;
                string nome = txtfirstname.Text;
                string lastname = txtlastname.Text;
                string email = txtemail.Text;


                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    string consultaUsuario = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario, @Name = @Name, @Lastname = @Lastname, @Correo = @Correo";
                    using (SqlCommand comando = new SqlCommand(consultaUsuario, conexion))
                    {
                        comando.Parameters.AddWithValue("@Usuario", usuario);
                        comando.Parameters.AddWithValue("@Name", nombre);
                        comando.Parameters.AddWithValue("@Lastname", apellido);
                        comando.Parameters.AddWithValue("@Correo", correo);

                        int resultadoUsuario = (int)comando.ExecuteScalar();
                    }


                }
            }
            catch (SqlException)
            {
                MessageBox.Show("error vuelva a intentar");
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            //if (txtcontra.Text == txtconfirmarcontra.Text)
            {
                //if (txtactualcontra.Text == //contraseña actual segun el sql server//
                {
                    //var ((meter aca los mismos valores ingresador de donde se enviara la info desde sql aca))//
                    //var  result = userModel.editUserProfile();
                    //MessageBox.Show(result);
                   // ocupa comando reset para reiniciar todo pero no me detecta ningun comando asi a mi  (reset();)
                    //Panel1.Visible = False;

                }
                //else
                    MessageBox.Show("Contraseña actual incorrecta, por favor vuelve a intentar");
            }
           // else
                MessageBox.Show("Las contraseñas no coinciden, reviselo y vuela a intentarlo");
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible=false;
          // aca tambien ocupa el reset
        }
    }
}




