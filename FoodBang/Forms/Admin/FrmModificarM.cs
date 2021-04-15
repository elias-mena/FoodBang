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

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int rest = cbxRest.SelectedIndex;
            dgvMenu.DataSource = Engine.ConsultarMenu(rest + 1);
        }
    }
}
