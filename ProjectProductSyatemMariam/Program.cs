using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectProductSyatemMariam
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
            //Application.Run(new TraderMarket());
           Application.Run(new Admin2());
            //Application.Run(new Admin());
           //Application.Run(new LoginUser());
            //Application.Run(new RegisterUser());
            //Application.Run(new Bills());
        }
    }
}
