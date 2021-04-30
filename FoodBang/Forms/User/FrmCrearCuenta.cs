using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodBang.Forms.User
{
    public partial class FrmCrearCuenta : Form
    {
        public FrmCrearCuenta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = txtName.Text;
            string edad = txtEdad.Text;
            string user = txtUser.Text;
            string pass = txtPass.Text;

            if (nombre.Length > 1 & edad.Length > 0 & user.Length > 1 & pass.Length > 1)
            {
                Engine.InsertarUser(nombre, edad, user, pass);
            }
            else
            {
                MessageBox.Show("Datos incompletos");
            }
            
        }
    }
}
