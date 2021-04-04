using FoodBang.Forms;
using FoodBang.Forms.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodBang
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmWelcome());
            FrmLogin f = new FrmLogin();
            f.ShowDialog();
            if (Engine.entrar)
            {
                MenuAdmin f1 = new MenuAdmin();
                f1.ShowDialog();

            }
        }
    }
}
