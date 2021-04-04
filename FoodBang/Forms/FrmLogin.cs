using FoodBang.Forms.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodBang.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (Engine.Login(txtUsuario.Text, txtPass.Text))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void btn_registrarse_Click(object sender, EventArgs e)
        {
            FrmCrearCuenta f = new FrmCrearCuenta();
            f.ShowDialog();
        }
    }
}
