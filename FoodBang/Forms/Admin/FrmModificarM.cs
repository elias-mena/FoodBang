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
    public partial class FrmModificarM : Form
    {
        public FrmModificarM()
        {
            InitializeComponent();
        }

        private void FrmModificarMenu_Load(object sender, EventArgs e)
        {
            cbxRest.DataSource = Engine.Restaurantes();
            cbxRest2.DataSource = Engine.Restaurantes();


        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int rest = cbxRest.SelectedIndex + 1;
            dgvMenu.DataSource = Engine.ConsultarMenu(rest);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int rest = cbxRest.SelectedIndex + 1;
            dgvInfo.DataSource = Engine.ConsultarComidasDisponibles(rest);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int comida = (int)txtEliminar.Value;
            int rest = cbxRest.SelectedIndex + 1;
            Engine.EliminarComidaM(rest,comida);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int rest = cbxRest.SelectedIndex + 1;
            int comida = (int) txtAgregar.Value;
            int precio = int.Parse(txtPrecio.Text);
            Engine.InsertarComidaM(rest,comida,precio);
        }

  
    }
}
