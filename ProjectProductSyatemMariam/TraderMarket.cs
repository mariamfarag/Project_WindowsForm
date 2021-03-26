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
        ElectronicMarketAppEntities2 context = new ElectronicMarketAppEntities2();
        //DBModels2 context = new DBModels2();
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
                var xx = (from ee in context.Bills
                          select ee).FirstOrDefault();
                var xxx = (from eee in context.Goods
                           where eee.IDG == comboBoxProduct.SelectedIndex
                           select eee).FirstOrDefault();
                richTextBox1.AppendText("Name : "+comboBoxProduct.Text.Trim()+"   ");
                richTextBox1.AppendText("Quantity : "+txQuantity.Text.Trim() + "\n");

                if( xxx.IDG==comboBoxProduct.SelectedIndex)
                {
                   // xx.IDGoods = comboBoxProduct.SelectedIndex;
                    xx.Quantity = Convert.ToInt32(txQuantity.Text.Trim());
                    xx.PriceForPic = Convert.ToInt32(txQuantity.Text.Trim()) * xxx.Price;
                    xx.DatePayment = DateTime.Now;
                    //xx.IDTrade = Convert.ToInt32(txtID.Text.Trim());
                   // context.SaveChanges();
                    if (xxx.Quantity > Convert.ToInt32(txQuantity.Text.Trim()))
                    {
                        xxx.Quantity = Convert.ToInt32(xx.Quantity) - Convert.ToInt32(txQuantity.Text.Trim());
                    }
                  // context.Entry(xx).State = EntityState.Modified;
                    context.Bills.Add(xx);
                    context.SaveChanges();
                }

            }
        }

        private void dataGridViewShowAllData_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
