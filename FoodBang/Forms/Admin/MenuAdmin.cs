using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodBang.Forms.Admin
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarU f = new FrmAgregarU();
            f.ShowDialog();
        }

        private void consultarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarU f = new FrmConsultarU();
            f.ShowDialog();
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminarU f = new FrmEliminarU(); 
            f.ShowDialog();
        }

        private void agregarComidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarC f = new FrmAgregarC();
            f.ShowDialog(); 
        }

        private void consultarComidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarC f = new FrmConsultarC();
            f.ShowDialog();

        }

        private void eliminarComidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminarC f = new FrmEliminarC();
            f.ShowDialog(); 
        }

        private void GestionarMenusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarM f = new FrmConsultarM();
            f.ShowDialog();
        }

        private void modificarMenusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificarM f = new FrmModificarM();
            f.ShowDialog();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Engine.Logout();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
