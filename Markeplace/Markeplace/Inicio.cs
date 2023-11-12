using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Markeplace
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            personalizardiseño();
        }
        private void personalizardiseño()
        {
            panelsubmenu1.Visible = false;
            panelsubmenu2.Visible = false;
            panelsubmenu3.Visible = false;
        }

        private void hidesubmenu()
        {
            if (panelsubmenu1.Visible == true)
                panelsubmenu1.Visible = false;
            if (panelsubmenu2.Visible == true)
                panelsubmenu2.Visible = false;
            if (panelsubmenu3.Visible == true)
                panelsubmenu3.Visible = false;

        }

        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Perfil Dats = new Perfil();
            Dats.Show();
            Hide();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void Submenu1_Click(object sender, EventArgs e)
        {
            showsubmenu(panelsubmenu1);
        }

        private void comida_Click(object sender, EventArgs e)
        {
            //..
            //aca meter los comandos para mostrar la info de la base de datos
            //..
            hidesubmenu();
        }

        private void utensilio_Click(object sender, EventArgs e)
        {
            //..
            //aca meter los comandos para mostrar la info de la base de datos
            //..
            hidesubmenu();
        }

        private void Submenu2_Click(object sender, EventArgs e)
        {
            showsubmenu(panelsubmenu2);
        }

        private void electrodomesticos_Click(object sender, EventArgs e)
        {
            //..
            //aca meter los comandos para mostrar la info de la base de datos
            //..
            hidesubmenu();
        }

        private void tecnologia_Click(object sender, EventArgs e)
        {
            //..
            //aca meter los comandos para mostrar la info de la base de datos
            //..
            hidesubmenu();
        }

        private void Submenu3_Click(object sender, EventArgs e)
        {
            showsubmenu(panelsubmenu3);
        }

        private void camas_Click(object sender, EventArgs e)
        {
            //..
            //aca meter los comandos para mostrar la info de la base de datos
            //..
            hidesubmenu();
        }

        private void muebles_Click(object sender, EventArgs e)
        {
            //..
            //aca meter los comandos para mostrar la info de la base de datos
            //..
            hidesubmenu();
        }

        private void comedor_Click(object sender, EventArgs e)
        {
            //..
            //aca meter los comandos para mostrar la info de la base de datos
            //..
            hidesubmenu();
        }
        private Form activeForm = null;
        private void openChildForm(Form ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelcontenedor.Controls.Add(ChildForm);
            panelcontenedor.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
    }
}
