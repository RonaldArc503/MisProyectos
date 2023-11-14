using System.Data.SqlClient;

namespace Markeplace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
                string contraseņa = password.Text;

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
                        comando.Parameters.AddWithValue("@Clave", contraseņa);

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


                    string consultaUsuario = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario AND Clave = @Contraseņa";
                    using (SqlCommand comando = new SqlCommand(consultaUsuario, conexion))
                    {
                        comando.Parameters.AddWithValue("@Usuario", usuario);
                        comando.Parameters.AddWithValue("@Contraseņa", contraseņa);

                        int resultadoUsuario = (int)comando.ExecuteScalar();

                        if (resultadoUsuario > 0)
                        {
                            // user normales

                            Marketplace Finicio = new Marketplace();
                            Hide();
                            Finicio.ShowDialog();
                            Close();


                        }
                        
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("error vuelva a intentar");
            }
        }

    }
}