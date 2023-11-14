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
        //sql conectado a ServerR
        // SqlConnection conexion = new SqlConnection("Server=LAPTOP-CC25DF46; database=Markeplace; integrated security= true ");  //erick
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-LALT64T; database=Markeplace; integrated security= true ");      //ronald
        private void RegistrarBD(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(namebox.Text) ||
                 string.IsNullOrWhiteSpace(lastnamebox.Text) ||
                 string.IsNullOrWhiteSpace(emailbox.Text) ||
                 string.IsNullOrWhiteSpace(userbox.Text) ||
                 string.IsNullOrWhiteSpace(clavebox.Text) ||
                 string.IsNullOrWhiteSpace(daybox.Text) ||
                 string.IsNullOrWhiteSpace(monthbox.Text) ||
                 string.IsNullOrWhiteSpace(yearbox.Text) ||
                (namebox.Text == "Nombre" || lastnamebox.Text == "Apellido" || emailbox.Text == "Correo electronico" ||
                 userbox.Text == "Usuario" || clavebox.Text == "Contraseña")
                 )
                {


                    MessageBox.Show("Faltan datos por llenar");
                }

                else
                {

                    conexion.Open();

                    string name = namebox.Text;
                    string lastn = lastnamebox.Text;
                    string email = emailbox.Text;
                    string user = userbox.Text;
                    string clave = clavebox.Text;

                    int day = int.Parse(daybox.Text);
                    int month = int.Parse(monthbox.Text);
                    int year = int.Parse(yearbox.Text);
                    // string genero = genderbox.Text;



                    DateTime fechaNacimiento = new DateTime(year, month, day);



                    string consulta = "INSERT INTO Usuarios (Nombre, Apellido, Correo, Usuario,Clave,fecha_nacimiento) " +
                                        "VALUES (@Name, @Lastn, @Email, @User,@Clave,@FechaNacimiento )";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Name", name);
                        comando.Parameters.AddWithValue("@Lastn", lastn);
                        comando.Parameters.AddWithValue("@Email", email);
                        comando.Parameters.AddWithValue("@User", user);
                        comando.Parameters.AddWithValue("@Clave", clave);
                        comando.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                        //    comando.Parameters.AddWithValue("@Genero", genero);
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Usted se ha Registrado, Gracias.");


                        Form1 Fm = new Form1();

                        this.Hide();
                        Fm.ShowDialog();
                        this.Close();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lo siento, ya se Registro o vuela a intentarlo mas tarde");
            }




        }

        private void LoginYatengocuenta(object sender, EventArgs e)
        {
            Form1 Fm = new Form1();

            this.Hide();
            Fm.ShowDialog();
            this.Close();

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
            if (userbox.Text == "")
            {
                userbox.Text = "Usuario";
                userbox.ForeColor = Color.Gray;
            }
        }

        private void user_Enter(object sender, EventArgs e)
        {
            if (userbox.Text == "Usuario")
            {
                userbox.Text = "";
                userbox.ForeColor = Color.Black;
            }
        }


    }
}
