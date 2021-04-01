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
    public partial class FrmAgregarU : Form
    {
        public FrmAgregarU()
        {
            InitializeComponent();
        }

        private void FrmAgregarU_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            string edad = txt_edad.Text;
            string user = txt_usuario.Text;
            string passw = txt_passw.Text;
            string tipo = cbx_tipo.Text;
            if(tipo == "Administrador")
            {
                tipo = "A";
            }
            else
            {
                tipo = "U";
            }
            Engine.InsertarUser(nombre, edad, tipo, user, passw);
        }
    }
}
