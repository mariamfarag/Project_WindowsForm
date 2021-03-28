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
    public partial class RegisterUser : Form
    {
        ElectronicMarketAppEntities3 context = new ElectronicMarketAppEntities3();
        TraderMarket TraderMarket = new TraderMarket();
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text != string.Empty && txtEmail.Text != string.Empty && txtNameShop.Text != string.Empty && txtPassword.Text != string.Empty && txtPhone.Text != string.Empty && txtLName.Text != string.Empty)
            {
                var xx = (from ee in context.Registers
                          select ee).FirstOrDefault();
                //if(modelstate.isvalid)
                xx.FName = txtFName.Text;
                xx.LName = txtLName.Text;
                xx.Password = txtPassword.Text;
                xx.Email = txtEmail.Text;
                xx.Phone = txtPhone.Text;
                xx.Address = txtAddress.Text;
                xx.ShopeName = txtNameShop.Text;
                context.Registers.Add(xx);
                context.SaveChanges();
                MessageBox.Show($"Thanks For Registraion {xx.FName} {xx.LName}\nYour ID :{xx.ID}");
                TraderMarket.ShowDialog();
            }
            else
            {
                MessageBox.Show("Fill all Data");
            }


            //=================

            //if ( txtFName.Text == string.Empty ||
            //     txtLName.Text == string.Empty ||
            //     txtPassword.Text == string.Empty ||
            //     txtPhone.Text == string.Empty ||
            //     txtPhone.Text == string.Empty ||
            //     txtEmail.Text == string.Empty ||
            //     txtNameShop.Text == string.Empty)
            //{
            //    ErrorRegister.Text = "Enter You Empty Date";
            //    ErrorRegister.ForeColor = Color.Red;
            //}
            //else
            //{
            //    ErrorRegister.Text = "Register Successfully !!";
            //    ErrorRegister.ForeColor = Color.Green;
            //    MessageBox.Show("Well Done THANKS !!!!! ");
            //}
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {
            // System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]")
            if (txtFName.Text == string.Empty|| txtFName.TextLength<=2 )
            {
                ErrorFName.Text = "Enter Your FName  at Least 3 Char !";
                ErrorFName.ForeColor = Color.Red;
            }
            else
            {
                ErrorFName.Text = "";
               // ErrorFName.ForeColor = Color.Red;
            }
            
        }

        private void RegisterUser_Load(object sender, EventArgs e)
        {
            //var x = txtFName.Text = txtLName.Text = txtPassword.Text = txtPhone.Text = txtPhone.Text =
            //    txtNameShop.Text;
            //if(x==string.Empty)
            //{
            //    ErrorRegister.Text = "Enter You Empty Date";
            //    ErrorRegister.ForeColor = Color.Red;
            //}
            //else
            //{
            //    ErrorRegister.Text = "Register Successfully !!";
            //    ErrorRegister.ForeColor = Color.Green;
            //    MessageBox.Show("Well Done THANKS !!!!! ");
            //}

        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            if (txtLName.Text == string.Empty || txtLName.TextLength <= 2)
            {
                ErrorLName.Text = "Enter Your LName  at Least 3 Char !";
                ErrorLName.ForeColor = Color.Red;
            }
            else
            {
                ErrorLName.Text = "";
                // ErrorFName.ForeColor = Color.Red;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty || txtPassword.TextLength <= 7)
            {
                ErrorPassword.Text = "Enter Your Password  at Least 7 Char - Num !";
                ErrorPassword.ForeColor = Color.Red;
            }
            else
            {
                ErrorPassword.Text = "";
                // ErrorFName.ForeColor = Color.Red;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (txtEmail.Text == string.Empty || !rEMail.IsMatch(txtEmail.Text))
            {
                ErrorEmail.Text = "Please Enter Like Format Mariam@mail.com";
                ErrorEmail.ForeColor = Color.Red;
            }
            else
            {
                ErrorEmail.Text = "";
            }

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex regexPhone = new System.Text.RegularExpressions.Regex(@"^(\d{3})\d{4}\d{4}$");
            if (txtPhone.Text == string.Empty || !regexPhone.IsMatch(txtPhone.Text))
            {
                ErrorPhone.Text = "Please Enter Like Format Mariam@mail.com";
                ErrorPhone.ForeColor = Color.Red;
            }
            else
            {
                ErrorPhone.Text = "";
            }

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text == string.Empty)
            {
                ErrorAddress.Text = "Enter Your Password  at Least 7 Char - Num !";
                ErrorAddress.ForeColor = Color.Red;
            }
            else
            {
                ErrorAddress.Text = "";
            }
        }

        private void txtNameShop_TextChanged(object sender, EventArgs e)
        {
            if (txtNameShop.Text == string.Empty || txtNameShop.TextLength<3)
            {
                ErrorShopName.Text = "Enter Your Password  at Least 7 Char - Num !";
                ErrorShopName.ForeColor = Color.Red;
            }
            else
            {
                ErrorShopName.Text = "";
            }
        }
    }
}
