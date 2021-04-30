using FoodBang.Forms;
using FoodBang.Forms.Admin;
using FoodBang.Forms.User;
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

            Engine.UserMenu();
            while (true)
            {
                if(Engine.logO == true)
                {
                    FrmLogin f2 = new FrmLogin();
                    f2.ShowDialog();

                    Engine.UserMenu();
                }
            }
            

        }
    }
}
