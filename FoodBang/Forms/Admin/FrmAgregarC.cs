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
    public partial class FrmAgregarC : Form
    {
        public FrmAgregarC()
        {
            InitializeComponent();
        }

        private void FrmAgregarC_Load(object sender, EventArgs e)
        {
            cbxCategorias.DataSource = Engine.Categorias();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            int categoria = cbxCategorias.SelectedIndex;
            Engine.InsertarComida(nombre,categoria+1);
            this.Close();

        }
    }
}
