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
using System.Data.SqlClient;



namespace Markeplace
{
    public partial class Marketplace : Form


    {
        public int ID { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }




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


        public Marketplace()
        {
            InitializeComponent();


            // IntPtr perfilimageRegion = CreateRoundRectRgn(0, 0, perfilimage.Width, perfilimage.Height, 60, 60);
            IntPtr busRegion = CreateRoundRectRgn(0, 0, buscador.Width, buscador.Height, 30, 30);


            buscador.Region = System.Drawing.Region.FromHrgn(busRegion);
            //  perfilimage.Region = System.Drawing.Region.FromHrgn(perfilimageRegion);

        }




        private void Marketplace_Load(object sender, EventArgs e)
        {
            string nombreCompleto = Nombre + " " + Apellido;
            userdata.Text = nombreCompleto;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Home hm = new Home();
            Hide();
            hm.ShowDialog();
            Close();
        }

        private void salirapp_Click(object sender, EventArgs e)
        {
            Perfil perfilForm = new Perfil();
            perfilForm.ID = this.ID;
            perfilForm.Usuario = this.Usuario; // Pasar el nombre de usuario al formulario Perfil
            perfilForm.Nombre = this.Nombre; // Pasar el nombre al formulario Perfil
            perfilForm.Apellido = this.Apellido; // Pasar el apellido al formulario Perfil
            Hide();
            perfilForm.ShowDialog(); // Mostrar el formulario Perfil



            Close();

        }

        private void perfilimage_Click(object sender, EventArgs e)
        {
            




            
            Perfil perfilForm = new Perfil();
            perfilForm.Usuario = this.Usuario; // Pasar el nombre de usuario al formulario Perfil
            perfilForm.Nombre = this.Nombre; // Pasar el nombre al formulario Perfil
            perfilForm.Apellido = this.Apellido; // Pasar el apellido al formulario Perfil
            Hide();
            perfilForm.ShowDialog(); // Mostrar el formulario Perfil

          
            
            Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

