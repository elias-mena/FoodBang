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
    public partial class AllUsers : Form
    {
        public AllUsers()
        {
            InitializeComponent();
        }

        private void AllUsers_Load(object sender, EventArgs e)
        {
            dgv_user.DataSource = Engine.ConsultarUsuarios();
        }
    }
}
