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
    public partial class LoginUser : Form
    {
        Register register = new Register();
        ElectronicMarketAppEntities2 context = new ElectronicMarketAppEntities2();
        TraderMarket trader = new TraderMarket();
        public LoginUser()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text!=string.Empty&& txtPassword.Text!=string.Empty)
            {
                var log = (from ee in context.Registers
                           where ee.Email == txtUserName.Text
                           && ee.Password == txtPassword.Text
                           select ee).FirstOrDefault();
                if(log!=null)
                MessageBox.Show("Hello in Marker Application");
                trader.ShowDialog();
               // this.Close();
            }
            else
                MessageBox.Show("Please Try Agin");


        }
    }
}
