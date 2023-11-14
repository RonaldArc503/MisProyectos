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
            logeo frm = new logeo();
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

            llenar_tablaadmin();

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




        private void verdatosactualizados_Click(object sender, EventArgs e)
        {
            llenar_tabla();
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


        private void verdatosactualizadosadmin_Click(object sender, EventArgs e)
        {
            llenar_tablaadmin();
        }



        private void eliminar_registro_admins(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "delete from Administradores where ID = " + idboxAdmins.Text + "";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro eliminado");
            llenar_tablaadmin();
            conexion.Close();

        }
        private void eliminar_registro_usuario(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "delete from Usuarios where ID = " + idbox.Text + "";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro eliminado");
            llenar_tabla();
            conexion.Close();

        }








        private void RegistrarBDA(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(nameboxAdmins.Text) ||
                 string.IsNullOrWhiteSpace(lastnboxAdmins.Text) ||
                 string.IsNullOrWhiteSpace(emailboxAdmins.Text) ||
                 string.IsNullOrWhiteSpace(s_userbox.Text) ||
                 string.IsNullOrWhiteSpace(s_userbox.Text) ||
                 string.IsNullOrWhiteSpace(s_clavebox.Text)

                 )
                {


                    MessageBox.Show("Faltan datos por llenar");
                }

                else
                {

                    conexion.Open();

                    string name = nameboxAdmins.Text;
                    string lastn = lastnboxAdmins.Text;
                    string email = emailboxAdmins.Text;
                    string user = s_userbox.Text;
                    string clave = s_clavebox.Text;









                    string consulta = "INSERT INTO Administradores (Nombre, Apellido, Correo, Super_Usuario,Clave) " +
                                        "VALUES (@Name, @Lastn, @Email, @User,@Clave )";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Name", name);
                        comando.Parameters.AddWithValue("@Lastn", lastn);
                        comando.Parameters.AddWithValue("@Email", email);
                        comando.Parameters.AddWithValue("@User", user);
                        comando.Parameters.AddWithValue("@Clave", clave);


                        comando.ExecuteNonQuery();

                        MessageBox.Show("Usted se ha Registrado, Gracias.");

                        llenar_tablaadmin();

                        idboxAdmins.Clear();
                        nameboxAdmins.Clear();
                        lastnboxAdmins.Clear();
                        emailboxAdmins.Clear();
                        s_userbox.Clear();
                        s_clavebox.Clear();

                        conexion.Close();
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("  ");
            }




        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            Hide();
            hm.ShowDialog();
            Close();
        }
    }
}
