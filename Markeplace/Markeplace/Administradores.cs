using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-LALT64T; database=Markeplace; integrated security= true ");


        private void Administradores_Load(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Close();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idbox.Text = dataGridView2.SelectedCells[0].Value.ToString();
            namebox.Text = dataGridView2.SelectedCells[1].Value.ToString();
            lastnamebox.Text = dataGridView2.SelectedCells[2].Value.ToString();
            emailbox.Text = dataGridView2.SelectedCells[3].Value.ToString();
            userbox.Text = dataGridView2.SelectedCells[4].Value.ToString();
            clavebox.Text = dataGridView2.SelectedCells[5].Value.ToString();
            //  datebbox.Text = dataGridView2.SelectedCells[6].Value.ToString();


        }

        private void llenar_tabla()
        {

            string consulta = "select*from Usuarios";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void actualizar_Click(object sender, EventArgs e)
        {

            conexion.Open();
            string consulta = "UPDATE Usuarios SET Nombre = @Nombre, Apellido = @Apellido, Correo = @Correo, Usuario = @Usuario, Clave = @Clave WHERE id = @ID";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@ID", idbox.Text);
            comando.Parameters.AddWithValue("@Nombre", namebox.Text);
            comando.Parameters.AddWithValue("@Apellido", lastnamebox.Text);
            comando.Parameters.AddWithValue("@Correo", emailbox.Text);
            comando.Parameters.AddWithValue("@Usuario", userbox.Text);
            comando.Parameters.AddWithValue("@Clave", clavebox.Text);

            int cant;
            cant = comando.ExecuteNonQuery();

            if (cant > 0)
            {
                MessageBox.Show("Datos actualizados");
            }
            llenar_tabla();
            conexion.Close();




        }
















        // los efectos 

        private void Nombreusuario_Enter(object sender, EventArgs e)
        {
            if (namebox.Text == "Nombre")
            {
                namebox.Text = "";
                namebox.ForeColor = Color.Black;
            }

        }

        private void Nombreusuario_Leave(object sender, EventArgs e)
        {
            if (namebox.Text == "")
            {
                namebox.Text = "Nombre";
                namebox.ForeColor = Color.Gray;
            }
        }

        private void Apellidousuario_Enter(object sender, EventArgs e)
        {
            if (lastnamebox.Text == "Apellido")
            {
                lastnamebox.Text = "";
                lastnamebox.ForeColor = Color.Black;
            }
        }

        private void Apellidousuario_Leave(object sender, EventArgs e)
        {
            if (lastnamebox.Text == "")
            {
                lastnamebox.Text = "Apellido";
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

        private void User_Leave(object sender, EventArgs e)
        {
            if (userbox.Text == " ")
            {
                userbox.Text = "Usuario";
                userbox.ForeColor = Color.Gray;
            }
        }

        private void user_Enter(object sender, EventArgs e)
        {
            if (userbox.Text == "Usuario")
            {
                userbox.Text = " ";
                userbox.ForeColor = Color.Black;
            }
        }

        private void llenardatos_Click(object sender, EventArgs e)
        {
            llenar_tabla();
        }

        private void clavebox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
