using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectProductSyatemMariam
{
    public partial class TraderMarket : Form
    {
        ElectronicMarketAppEntities3 context = new ElectronicMarketAppEntities3();
        //DBModels2 context = new DBModels2();
        public static string SetValueForText1 = "";
        public TraderMarket()
        {
            InitializeComponent();
        }

        private void dataGridViewShowAllData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void TraderMarket_Load(object sender, EventArgs e)
        {
            FillDataGradView();

        }
        //===========
        void FillDataGradView()
        {
            var xx = from ee in context.Goods
                     select ee.Name;
            dataGridViewShowAllData.AutoGenerateColumns = false;
            dataGridViewShowAllData.DataSource = context.Goods.ToList<Good>();
            comboBoxProduct.DataSource = xx.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           

            if (txQuantity.Text!=string.Empty&& comboBoxProduct.SelectedItem!=null)
            {
               
                var xxx = (from eee in context.Goods
                           where eee.Name == comboBoxProduct.SelectedItem.ToString()
                           select eee).FirstOrDefault();
                richTextBox1.AppendText("Name : "+comboBoxProduct.Text.Trim()+"   ");
                richTextBox1.AppendText("Quantity : "+txQuantity.Text.Trim() + "\n");
                if (xxx != null)
                {
                    Bill bill = new Bill();
                    //if (xxx.ID == comboBoxProduct.SelectedIndex)
                    //{
                    if (xxx.Quantity > Convert.ToInt32(txQuantity.Text.Trim()))
                    {
                        xxx.Quantity = Convert.ToInt32(xxx.Quantity) - Convert.ToInt32(txQuantity.Text.Trim());
                        //context.SaveChanges();
                    }
                    bill.IDGoods = xxx.IDG;// comboBoxProduct.SelectedIndex;
                    bill.Quantity = Convert.ToInt32(txQuantity.Text.Trim());
                    bill.PriceForPic = Convert.ToInt32(txQuantity.Text.Trim()) * xxx.Price;
                    bill.DatePayment = DateTime.Now;
                    bill.IDTrade = Convert.ToInt32(txtID.Text.Trim());
                        context.Bills.Add(bill);
                        context.SaveChanges();
                    //}
                }
            }
        }

        private void dataGridViewShowAllData_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnShowBills_Click(object sender, EventArgs e)
        {
            //BillsUser billsUser = new BillsUser();
            //Register register = new Register();
            //string name,address;
            //if(register.ID==Convert.ToInt32( txtID.Text))
            //{
            //    name = register.FName;
            //    address = register.Address;
            //    billsUser.PassValue(name,address);
            //    billsUser.ShowDialog();
            //}
            if (txtID != null)
            {
                SetValueForText1 = txtID.Text;
                BillsUser frm2 = new BillsUser();
                frm2.Show();
            }
            else
                MessageBox.Show("Enter Your Id Please");
        }
    }
}
