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
    public partial class FrmEliminarU : Form
    {
        public FrmEliminarU()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgUser.DataSource = Engine.ConsultarUsuario(txtUser.Text);
            if(dgUser.Rows.Count > 1)
            {
                btnEliminar.Enabled =true;

            }
            else
            {
                MessageBox.Show("No existe nadie con ese nombre de usuario");
                btnEliminar.Enabled = false;
             
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Engine.EliminarUser(txtUser.Text);
            txtUser.Text = "";
        }
    }
}
