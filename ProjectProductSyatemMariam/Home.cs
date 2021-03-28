using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectProductSyatemMariam
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            LoginUser login = new LoginUser();
            login.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterUser register = new RegisterUser();
            register.ShowDialog();
        }
    }
}
