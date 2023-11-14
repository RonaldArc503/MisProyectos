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

        private void llenar_tabla()
        {

            string consulta = "select*from Usuarios";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            datauser.DataSource = dt;

        }

        private void llenar_tablaadmin()
        {

            string consulta2 = "select*from Administradores";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta2, conexion);
            DataTable dt1 = new DataTable();
            adaptador.Fill(dt1);
            dataadmins.DataSource = dt1;

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

            conexion.Close();




        }


        private void actualizar_Clickadmin(object sender, EventArgs e)
        {

            conexion.Open();
            string consulta = "UPDATE Administradores SET Nombre = @Nombre, Apellido = @Apellido, Correo = @Correo, Super_Usuario = @Usuario, Clave = @Clave WHERE id = @ID";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@ID", idboxAdmins.Text);
            comando.Parameters.AddWithValue("@Nombre", nameboxAdmins.Text);
            comando.Parameters.AddWithValue("@Apellido", lastnboxAdmins.Text);
            comando.Parameters.AddWithValue("@Correo", emailboxAdmins.Text);
            comando.Parameters.AddWithValue("@Usuario", s_userbox.Text);
            comando.Parameters.AddWithValue("@Clave", s_clavebox.Text);

            int cant;
            cant = comando.ExecuteNonQuery();

            if (cant > 0)
            {
                MessageBox.Show("Datos actualizados");
            }

            conexion.Close();




        }




        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idboxAdmins.Text = dataadmins.SelectedCells[0].Value.ToString();
            nameboxAdmins.Text = dataadmins.SelectedCells[1].Value.ToString();
            lastnboxAdmins.Text = dataadmins.SelectedCells[2].Value.ToString();
            emailboxAdmins.Text = dataadmins.SelectedCells[3].Value.ToString();
            s_userbox.Text = dataadmins.SelectedCells[4].Value.ToString();
            s_clavebox.Text = dataadmins.SelectedCells[5].Value.ToString();
            //  datebbox.Text = dataGridView2.SelectedCells[6].Value.ToString();


        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idbox.Text = datauser.SelectedCells[0].Value.ToString();
            namebox.Text = datauser.SelectedCells[1].Value.ToString();
            lastnamebox.Text = datauser.SelectedCells[2].Value.ToString();
            emailbox.Text = datauser.SelectedCells[3].Value.ToString();
            userbox.Text = datauser.SelectedCells[4].Value.ToString();
            clavebox.Text = datauser.SelectedCells[5].Value.ToString();
            //  datebbox.Text = dataGridView2.SelectedCells[6].Value.ToString();


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

        private void verdatosactualizados_Click(object sender, EventArgs e)
        {
            llenar_tabla();
        }

        private void clavebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            usuariosview.Visible = !usuariosview.Visible;
            viewadmin.Visible = false;
        }

        private void adminsvisible_Click(object sender, EventArgs e)
        {
            viewadmin.Visible = !viewadmin.Visible;
            usuariosview.Visible = false;
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void verdatosactualizadosadmin_Click(object sender, EventArgs e)
        {
            llenar_tablaadmin();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
