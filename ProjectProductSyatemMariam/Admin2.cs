using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectProductSyatemMariam
{
    public partial class Admin2 : Form
    {
        Good Good = new Good();
        ElectronicMarketAppEntities3 Context = new ElectronicMarketAppEntities3();
       // LoginUser login = new LoginUser();
        public Admin2()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            FillDataGradView();
            //DateTime expirationDate = DateTime.Now.AddDays(21);
            //DateTime now = DateTime.Now;
            //TimeSpan diff = expirationDate - now;
            //int days = diff.Days; // This would give 20
            //DateTime _expiryDate = DateTime.Now + TimeSpan.FromDays(30);

            //ArrayList arrayList = new ArrayList();
            foreach (var item in Context.Goods)
            {
                if (item.Expire_Date < DateTime.Now)
                {
                     //   arrayList.Add(item.ToString());
                    MessageBox.Show($"All Expire Product \n Name :{item.Name}\n Expire Date :{item.Expire_Date}\n");
                }

            }
           // MessageBox.Show($"All Expire Product Name :{arrayList}\n");

            //var expire = (from ee in Context.Goods
            //              where ee.Expire_Date < DateTime.Now//.AddDays(20)
            //              select ee).FirstOrDefault();
            //if (expire != null)
            //        MessageBox.Show($"All Expire Product \n Name :{expire.Name}\n Expire Date :{expire.Expire_Date}\n");

        }

        //===========
        void Clear()
        {
            txtName.Text = txtID.Text = txtPrice.Text = txtQuantity.Text = txtIDOffers.Text = txtExpireDate.Text = txtSize.Text = "";
            btnAddProduct.Text = "Insert";
            btnDelete.Enabled = false;
            Good.ID = 0;
        }

        void FillDataGradView()
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.DataSource = Context.Goods.ToList<Good>();
        }
        //====================
        private void Admin2_Load(object sender, EventArgs e)
        {
           // login.Close();
            Clear();

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            if (txtID.Text != string.Empty && txtName.Text != string.Empty && txtPrice.Text != string.Empty && txtQuantity.Text != string.Empty && txtSize.Text != string.Empty && txtExpireDate.Text != string.Empty)
            {

                if (txtIDOffers.Text == "")
                {
                    Good.IDOffers = default;
                }
                else
                    Good.IDOffers = Convert.ToInt32(txtIDOffers.Text.Trim());
                Good.IDG = Convert.ToInt32(txtID.Text.Trim());
                Good.Name = txtName.Text.Trim();
                Good.Quantity = Convert.ToInt32(txtQuantity.Text.Trim());
                Good.Price = Convert.ToInt32(txtPrice.Text.Trim());
                Good.Expire_Date = Convert.ToDateTime(txtExpireDate.Text.Trim());
                Good.Size = txtSize.Text.Trim();

                if (Good.ID == 0)//insert Add product
                {
                    Context.Goods.Add(Good);
                    MessageBox.Show("Success Added Product ");
                }

                else
                {
                    // Update
                    Context.Entry(Good).State = EntityState.Modified;
                    MessageBox.Show("Success Updated Product ");
                }
                Context.SaveChanges();
                Clear();

                FillDataGradView();
            }

            else
                MessageBox.Show("Please Fill Empty Element !!");

        }

        private void dgvProducts_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow.Index != -1)
            {
                Good.ID = Convert.ToInt32(dgvProducts.CurrentRow.Cells["ID"].Value);
                Good = Context.Goods.Where(x => x.ID == Good.ID).FirstOrDefault();

                if (txtIDOffers.Text == "")
                {
                    txtIDOffers.Text = default;
                }
                else
                    txtIDOffers.Text = Good.IDOffers.ToString();

                txtID.Text = Good.IDG.ToString();
                txtName.Text = Good.Name;
                txtPrice.Text = Good.Price.ToString();
                txtQuantity.Text = Good.Quantity.ToString();
                txtSize.Text = Good.Size.ToString();
                txtExpireDate.Text = Good.Expire_Date.ToString();
            }

            btnAddProduct.Text = "Update";
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To delete Item", "IF you want click yes", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var data = Context.Entry(Good);
                if (data.State == EntityState.Detached)
                    Context.Goods.Attach(Good);
                Context.Goods.Remove(Good);
                Context.SaveChanges();
                MessageBox.Show("Deleted Success");
                FillDataGradView();
                Clear();
            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtExpireDate_TextChanged(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex regexExpire = new System.Text.RegularExpressions.Regex(@"^(\d{4})-(\d{1,2})-(\d{1,2})$");

            if (txtExpireDate.Text == string.Empty || ! regexExpire.IsMatch(txtExpireDate.Text))
            {
                ErrorExpireDate.Text = "Enter Your Date YYYY-MM-DD !";
                ErrorExpireDate.ForeColor = Color.Red;
            }
            else
            {
                ErrorExpireDate.Text = "";
            }
        }
    }
}
