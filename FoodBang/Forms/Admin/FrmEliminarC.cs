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
    public partial class FrmEliminarC : Form
    {
        public FrmEliminarC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvInfo.DataSource = Engine.ConsultarComidasID();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int comida = (int) txtID.Value;
            Engine.EliminarComida(comida);
        }
    }
}
