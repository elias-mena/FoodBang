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
    public partial class FrmMenuUser : Form
    {
        public static int rest;
        public static int totalPedido = 0;
        public FrmMenuUser()
        {
            InitializeComponent();
            totalPedido = 0;
        }

        private void FrmMenuUser_Load(object sender, EventArgs e)
        {

        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            this.Close();
            string inf = "";
            List<string> info = Engine.infoPedido;
            for (int i = 0; i < info.Count; i++)
            {
                inf = inf + info[i].ToString() + "\n";
            }
            FrmPreparando f1 = new FrmPreparando(inf);
            f1.ShowDialog();
        }

        private void btnMac_Click(object sender, EventArgs e)
        {
            rest = 1;
            label1.Text = "Menú McDonals";
            dgvInfo.DataSource = Engine.ConsultarMenu(rest);
        }
        private void btnPH_Click(object sender, EventArgs e)
        {
            int rest = 2;
            label1.Text = "Menú Pizza Hut";
            dgvInfo.DataSource = Engine.ConsultarMenu(rest);
        }
        private void btnTB_Click(object sender, EventArgs e)
        {
            int rest = 3;
            label1.Text = "Menú Taco Bell";
            dgvInfo.DataSource = Engine.ConsultarMenu(rest);
        }
        private void btnOG_Click(object sender, EventArgs e)
        {
            int rest = 4;
            label1.Text = "Menú Olive Garden";
            dgvInfo.DataSource = Engine.ConsultarMenu(rest);
        }
        private void btnNA_Click(object sender, EventArgs e)
        {
            int rest = 5;
            label1.Text = "Menú Novillo Alegre";
            dgvInfo.DataSource = Engine.ConsultarMenu(rest);
        }
        private void btnOB_Click(object sender, EventArgs e)
        {
            int rest = 6;
            label1.Text = "Menú OutBack";
            dgvInfo.DataSource = Engine.ConsultarMenu(rest);
        }
       

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            string infoCarrito = "";
            for (int i = 0; i < Engine.infoPedido.Count(); i++)
            {
                infoCarrito = infoCarrito + Engine.infoPedido[i].ToString() + "\n";
            }
            infoCarrito = infoCarrito + "Total: " + Engine.totalPedido.ToString();
            MessageBox.Show(infoCarrito);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int comida = (int)txtId.Value;
            Engine.InfoComida(rest, comida);
        }
    }
}
