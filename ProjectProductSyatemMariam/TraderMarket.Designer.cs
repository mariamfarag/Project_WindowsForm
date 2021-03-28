
namespace ProjectProductSyatemMariam
{
    partial class TraderMarket
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.lbProduct = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.txQuantity = new System.Windows.Forms.TextBox();
            this.dataGridViewShowAllData = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expire_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDOffers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShowBills = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowAllData)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(113, 22);
            this.comboBoxProduct.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(234, 26);
            this.comboBoxProduct.TabIndex = 0;
            // 
            // lbProduct
            // 
            this.lbProduct.AutoSize = true;
            this.lbProduct.BackColor = System.Drawing.Color.Transparent;
            this.lbProduct.Location = new System.Drawing.Point(37, 22);
            this.lbProduct.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(72, 18);
            this.lbProduct.TabIndex = 1;
            this.lbProduct.Text = "Product:";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lbQuantity.Location = new System.Drawing.Point(35, 65);
            this.lbQuantity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(75, 18);
            this.lbQuantity.TabIndex = 2;
            this.lbQuantity.Text = "Quantity:";
            // 
            // txQuantity
            // 
            this.txQuantity.Location = new System.Drawing.Point(113, 65);
            this.txQuantity.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txQuantity.Name = "txQuantity";
            this.txQuantity.Size = new System.Drawing.Size(234, 24);
            this.txQuantity.TabIndex = 3;
            // 
            // dataGridViewShowAllData
            // 
            this.dataGridViewShowAllData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShowAllData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewShowAllData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowAllData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IDG,
            this.NameProduct,
            this.Quantity,
            this.SizeProduct,
            this.Price,
            this.Expire_Date,
            this.IDOffers});
            this.dataGridViewShowAllData.Location = new System.Drawing.Point(399, -1);
            this.dataGridViewShowAllData.Name = "dataGridViewShowAllData";
            this.dataGridViewShowAllData.Size = new System.Drawing.Size(647, 514);
            this.dataGridViewShowAllData.TabIndex = 5;
            this.dataGridViewShowAllData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShowAllData_CellContentClick);
            this.dataGridViewShowAllData.DoubleClick += new System.EventHandler(this.dataGridViewShowAllData_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // IDG
            // 
            this.IDG.DataPropertyName = "IDG";
            this.IDG.HeaderText = "IDG";
            this.IDG.Name = "IDG";
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
            // SizeProduct
            // 
            this.SizeProduct.DataPropertyName = "Size";
            this.SizeProduct.HeaderText = "Size";
            this.SizeProduct.Name = "SizeProduct";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Expire_Date
            // 
            this.Expire_Date.DataPropertyName = "Expire_Date";
            this.Expire_Date.HeaderText = "Expire_Date";
            this.Expire_Date.Name = "Expire_Date";
            // 
            // IDOffers
            // 
            this.IDOffers.DataPropertyName = "IDOffers";
            this.IDOffers.HeaderText = "IDOffers";
            this.IDOffers.Name = "IDOffers";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAdd.Location = new System.Drawing.Point(38, 166);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 56);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShowBills
            // 
            this.btnShowBills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnShowBills.ForeColor = System.Drawing.Color.Black;
            this.btnShowBills.Location = new System.Drawing.Point(203, 166);
            this.btnShowBills.Name = "btnShowBills";
            this.btnShowBills.Size = new System.Drawing.Size(159, 56);
            this.btnShowBills.TabIndex = 7;
            this.btnShowBills.Text = "Show Bills";
            this.btnShowBills.UseVisualStyleBackColor = false;
            this.btnShowBills.Click += new System.EventHandler(this.btnShowBills_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(-3, 239);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(405, 274);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(113, 110);
            this.txtID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(234, 24);
            this.txtID.TabIndex = 10;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.Color.Transparent;
            this.lbID.Location = new System.Drawing.Point(53, 110);
            this.lbID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(29, 18);
            this.lbID.TabIndex = 9;
            this.lbID.Text = "ID:";
            // 
            // TraderMarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectProductSyatemMariam.Properties.Resources._7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1046, 514);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnShowBills);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridViewShowAllData);
            this.Controls.Add(this.txQuantity);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbProduct);
            this.Controls.Add(this.comboBoxProduct);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "TraderMarket";
            this.Text = "Trader";
            this.Load += new System.EventHandler(this.TraderMarket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowAllData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Label lbProduct;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.TextBox txQuantity;
        private System.Windows.Forms.DataGridView dataGridViewShowAllData;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShowBills;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expire_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDOffers;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbID;
    }
}

