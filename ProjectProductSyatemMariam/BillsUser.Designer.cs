
namespace ProjectProductSyatemMariam
{
    partial class BillsUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbName = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.dataGridViewBills = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceForPic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatePayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBills)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(88, 18);
            this.lbName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(79, 25);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name:";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.BackColor = System.Drawing.Color.Transparent;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(88, 67);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(105, 25);
            this.lbAddress.TabIndex = 2;
            this.lbAddress.Text = "Address:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(220, 28);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 25);
            this.labelName.TabIndex = 3;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(220, 77);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(0, 25);
            this.labelAddress.TabIndex = 4;
            // 
            // dataGridViewBills
            // 
            this.dataGridViewBills.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NameProduct,
            this.Quantity,
            this.PriceForPic,
            this.DatePayment});
            this.dataGridViewBills.Location = new System.Drawing.Point(-1, 109);
            this.dataGridViewBills.Name = "dataGridViewBills";
            this.dataGridViewBills.Size = new System.Drawing.Size(576, 223);
            this.dataGridViewBills.TabIndex = 5;
            this.dataGridViewBills.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBills_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // NameProduct
            // 
            this.NameProduct.DataPropertyName = "Name";
            this.NameProduct.HeaderText = "Name";
            this.NameProduct.Name = "NameProduct";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // PriceForPic
            // 
            this.PriceForPic.DataPropertyName = "PriceForPic";
            this.PriceForPic.HeaderText = "PriceForPic";
            this.PriceForPic.Name = "PriceForPic";
            // 
            // DatePayment
            // 
            this.DatePayment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatePayment.DataPropertyName = "DatePayment";
            this.DatePayment.HeaderText = "DatePayment";
            this.DatePayment.Name = "DatePayment";
            // 
            // BillsUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::ProjectProductSyatemMariam.Properties.Resources._7;
            this.ClientSize = new System.Drawing.Size(575, 332);
            this.Controls.Add(this.dataGridViewBills);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "BillsUser";
            this.Text = "Bills";
            this.Load += new System.EventHandler(this.BillsUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.DataGridView dataGridViewBills;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceForPic;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatePayment;
    }
}