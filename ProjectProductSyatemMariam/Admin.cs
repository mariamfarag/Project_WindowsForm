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
    public partial class Admin : Form
    {
        InsertProduct InsertPro=new InsertProduct();
        UpdateProduct UpdatePro=new UpdateProduct();
        DeleteProduct DeletePro=new DeleteProduct();

        public Admin()
        {
            InitializeComponent();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //InsertPro.ShowDialog();
            //if (InsertPro == null || InsertPro.IsDisposed)
            //{
            //    InsertPro = new InsertProduct();
            //}

            InsertPro.Show();
            // InsertPro.MdiParent = this;
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (UpdatePro == null || UpdatePro.IsDisposed)
            //{
            //    UpdatePro = new UpdateProduct();
            //}
           
            //this.Close();
            UpdatePro.Show();
            // UpdatePro.MdiParent = this;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (DeletePro == null || DeletePro.IsDisposed)
            //{
            //    DeletePro = new DeleteProduct();
            //}
            DeletePro.Show();
            
            //DeletePro.MdiParent = this;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
          
        }
    }
}
