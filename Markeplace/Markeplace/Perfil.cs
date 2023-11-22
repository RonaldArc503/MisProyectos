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

        private string connectionString = "Server=DESKTOP-LALT64T; database=Markeplace; integrated security=true";

        public int ID { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        private void Perfil_Load(object sender, EventArgs e)
        {
            // lblname.Text = Nombre;
            //  lbluser.Text = Usuario;
            //  lbllastname.Text = Apellido;



            int idUsuario = ID;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, Nombre, Apellido, Usuario, Correo FROM Usuarios WHERE ID = @Id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", idUsuario);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        //lblID.Text = $"ID: {reader["ID"]}";
                        lblname.Text = $"Nombre: {reader["Nombre"]}";
                        lbllastname.Text = $"Apellido: {reader["Apellido"]}";
                        lbluser.Text = $"Usuario: {reader["Usuario"]}";
                        lblcorreo.Text = $"Correo: {reader["Correo"]}";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }










        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            editdatos.Visible = true;
        }
    }


}