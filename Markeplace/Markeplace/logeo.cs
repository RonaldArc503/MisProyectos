using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Markeplace
{
    public partial class logeo : Form
    {
        public logeo()
        {
            InitializeComponent();
            IntPtr perfilimageRegion = CreateRoundRectRgn(0, 0, Login.Width, Login.Height, 50, 50);
            // IntPtr busRegion = CreateRoundRectRgn(0, 0, password.Width, password.Height, 30, 30);


            //user.Region = System.Drawing.Region.FromHrgn(busRegion);
            Login.Region = System.Drawing.Region.FromHrgn(perfilimageRegion);

        }


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
                (
                    int nLeftRect,
                    int nTopRect,
                    int nRightRect,
                    int nBottomRect,
                    int nWidthEllipse,
                    int nHeightEllipse
                );

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            registro rg = new registro();

            this.Hide();

            rg.ShowDialog();

            this.Close();





        }

        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = user.Text;
                string contraseña = password.Text;

                //conectado a server R
                //string connectionString = "Server=LAPTOP-CC25DF46; database=Markeplace; Integrated security= true ";     // base erik
                string connectionString = "Server=DESKTOP-LALT64T; database=Markeplace; integrated security= true ";        // ronald db

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    //los admins
                    string consultaAdmin = "SELECT COUNT(*) FROM Administradores WHERE Super_usuario = @SUsuario AND Clave = @Clave";
                    using (SqlCommand comando = new SqlCommand(consultaAdmin, conexion))
                    {
                        comando.Parameters.AddWithValue("@SUsuario", usuario);
                        comando.Parameters.AddWithValue("@Clave", contraseña);

                        int resultadoAdmin = (int)comando.ExecuteScalar();



                        if (resultadoAdmin > 0)
                        {
                            //yo

                            Administradores Admins = new Administradores();
                            Hide();
                            Admins.ShowDialog();
                            Close();


                        }
                    }

                    string consultaUsuario = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario AND Clave = @Contraseña";
                    string consultaDatosUsuario = "SELECT ID, Nombre, Apellido FROM Usuarios WHERE Usuario = @Usuario AND Clave = @Contraseña";

                    using (SqlCommand comando = new SqlCommand(consultaUsuario, conexion))
                    {
                        comando.Parameters.AddWithValue("@Usuario", usuario);
                        comando.Parameters.AddWithValue("@Contraseña", contraseña);

                        int resultadoUsuario = (int)comando.ExecuteScalar();

                        if (resultadoUsuario > 0)
                        {
                            using (SqlCommand comandoDatosUsuario = new SqlCommand(consultaDatosUsuario, conexion))
                            {
                                comandoDatosUsuario.Parameters.AddWithValue("@Usuario", usuario);
                                comandoDatosUsuario.Parameters.AddWithValue("@Contraseña", contraseña);

                                using (SqlDataReader lector = comandoDatosUsuario.ExecuteReader())
                                {
                                    if (lector.Read())
                                    {
                                        int id = (int)lector["ID"];
                                        //  string id = lector["ID"].ToString();
                                        string nombre = lector["Nombre"].ToString();
                                        string apellido = lector["Apellido"].ToString();


                                        Marketplace Finicio = new Marketplace();
                                        Finicio.ID = id;
                                        Finicio.Usuario = usuario;
                                        Finicio.Nombre = nombre;
                                        Finicio.Apellido = apellido;

                                        Hide();
                                        Finicio.ShowDialog();
                                        Close();
                                    }
                                }
                            }
                        }



                        else
                        {
                            MessageBox.Show("No existe cuenta");
                        }

                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("error vuelva a intentar");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {


            if (password.PasswordChar == '*')
            {

                password.PasswordChar = '\0';
            }
            else
            {

                password.PasswordChar = '*';
            }
        }




    }
}