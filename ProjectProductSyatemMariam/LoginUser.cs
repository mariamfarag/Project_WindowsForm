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
        ElectronicMarketAppEntities3 context = new ElectronicMarketAppEntities3();
        TraderMarket trader = new TraderMarket();
        Admin2 admin = new Admin2();
        //LoginUser login = new LoginUser();
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
                {
                    if(log.ID==1)
                    {
                        MessageBox.Show($"Hello in Marker Application: {log.FName} {log.LName}");
                       //// login.Close();
                        admin.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show($"Hello in Marker Application: {log.FName} {log.LName}\n Your ID :{log.ID}");
                        ////login.Close();
                        trader.ShowDialog();
                    }
                }
               
                
               // this.Close();
            }
            else
                MessageBox.Show("Please Try Agin");


        }
    }
}
