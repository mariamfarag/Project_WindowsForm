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
    public partial class BillsUser : Form
    {
        ElectronicMarketAppEntities3 context = new ElectronicMarketAppEntities3();
        Bill bill = new Bill();
        public BillsUser()
        {
            InitializeComponent();
        }

        private void dataGridViewBills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BillsUser_Load(object sender, EventArgs e)
        {
            //TraderMarket trader = new TraderMarket();
            //BillsUser billsUser = new BillsUser();
            Register register = new Register();
             int id=Convert.ToInt32( TraderMarket.SetValueForText1);
            //int id = 10;
            var items = (from ee in context.Registers
                         where ee.ID == id
                         select ee).FirstOrDefault();
            var itemstrader = (from ee in context.Bills
                         where ee.IDTrade == id
                         select ee).FirstOrDefault();
            var itemstrader2 = (from ee in context.BillForYous
                               where ee.IDReg == id
                               select ee).FirstOrDefault();

            lbName.Text = TraderMarket.SetValueForText1;
            if (items!=null)
            {
                labelName.Text = items.FName;
                labelAddress.Text = items.Address;
                if (itemstrader!=null)
                {
                    //foreach (var item in context.BillForYous)
                    //{
                    //    if (id == itemstrader2.IDReg)
                        {
                            dataGridViewBills.AutoGenerateColumns = false;
                        dataGridViewBills.DataSource =  context.BillForYous.ToList<BillForYou>();
                        }
                   // }
                    
                      //  FillDataGradView();



                }

            }
        }

        void FillDataGradView()
        {
          
            dataGridViewBills.AutoGenerateColumns = false;
            dataGridViewBills.DataSource = context.BillForYous.ToList<BillForYou>();
        }

        //public void PassValue(string strName, string strAddress)
        //{
        //    lbName.Text = strName;
        //    lbAddress.Text = strAddress;
        //}
    }
}
