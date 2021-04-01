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
    public partial class FrmConsultarU : Form
    {
        public FrmConsultarU()
        {
            InitializeComponent();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            dgUser.DataSource = Engine.ConsultarUsuario(txtUser.Text);
        }

        private void BtnAll_Click(object sender, EventArgs e)
        {
            AllUsers f = new AllUsers();
            f.ShowDialog();
        }
    }
}
