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
    public partial class FrmConsultarC : Form
    {
        public FrmConsultarC()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvComida.DataSource = Engine.ConsultarComidas();
        }

        private void FrmConsultarC_Load(object sender, EventArgs e)
        {
            cbxCategorias.DataSource = Engine.Categorias();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int categoria = cbxCategorias.SelectedIndex;
            dgvComida.DataSource = Engine.ConsultarComidasCategoria(categoria+1);
        }
    }
}
