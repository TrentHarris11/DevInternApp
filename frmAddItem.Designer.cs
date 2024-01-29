namespace DevInternApp
{
    partial class frmAddItem
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
            this.cmbStock = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txbQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblUnitCost = new System.Windows.Forms.Label();
            this.txbUnitCost = new System.Windows.Forms.TextBox();
            this.lblUnitSell = new System.Windows.Forms.Label();
            this.txbUnitSellingPrice = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txbDiscount = new System.Windows.Forms.TextBox();
            this.lblTotalCosts = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbStock
            // 
            this.cmbStock.FormattingEnabled = true;
            this.cmbStock.Location = new System.Drawing.Point(228, 12);
            this.cmbStock.Name = "cmbStock";
            this.cmbStock.Size = new System.Drawing.Size(104, 24);
            this.cmbStock.TabIndex = 0;
            this.cmbStock.SelectedIndexChanged += new System.EventHandler(this.cmbStock_SelectedIndexChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(384, 20);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(94, 20);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // txbQuantity
            // 
            this.txbQuantity.Location = new System.Drawing.Point(387, 100);
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Size = new System.Drawing.Size(98, 22);
            this.txbQuantity.TabIndex = 2;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(225, 100);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(55, 16);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblUnitCost
            // 
            this.lblUnitCost.AutoSize = true;
            this.lblUnitCost.Location = new System.Drawing.Point(224, 137);
            this.lblUnitCost.Name = "lblUnitCost";
            this.lblUnitCost.Size = new System.Drawing.Size(60, 16);
            this.lblUnitCost.TabIndex = 5;
            this.lblUnitCost.Text = "Unit Cost";
            // 
            // txbUnitCost
            // 
            this.txbUnitCost.Location = new System.Drawing.Point(387, 137);
            this.txbUnitCost.Name = "txbUnitCost";
            this.txbUnitCost.Size = new System.Drawing.Size(98, 22);
            this.txbUnitCost.TabIndex = 4;
            // 
            // lblUnitSell
            // 
            this.lblUnitSell.AutoSize = true;
            this.lblUnitSell.Location = new System.Drawing.Point(224, 178);
            this.lblUnitSell.Name = "lblUnitSell";
            this.lblUnitSell.Size = new System.Drawing.Size(108, 16);
            this.lblUnitSell.TabIndex = 7;
            this.lblUnitSell.Text = "Unit Selling Price";
            // 
            // txbUnitSellingPrice
            // 
            this.txbUnitSellingPrice.Location = new System.Drawing.Point(387, 178);
            this.txbUnitSellingPrice.Name = "txbUnitSellingPrice";
            this.txbUnitSellingPrice.Size = new System.Drawing.Size(98, 22);
            this.txbUnitSellingPrice.TabIndex = 6;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(225, 225);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(59, 16);
            this.lblDiscount.TabIndex = 9;
            this.lblDiscount.Text = "Discount";
            // 
            // txbDiscount
            // 
            this.txbDiscount.Location = new System.Drawing.Point(387, 225);
            this.txbDiscount.Name = "txbDiscount";
            this.txbDiscount.Size = new System.Drawing.Size(98, 22);
            this.txbDiscount.TabIndex = 8;
            // 
            // lblTotalCosts
            // 
            this.lblTotalCosts.AutoSize = true;
            this.lblTotalCosts.Location = new System.Drawing.Point(223, 279);
            this.lblTotalCosts.Name = "lblTotalCosts";
            this.lblTotalCosts.Size = new System.Drawing.Size(78, 16);
            this.lblTotalCosts.TabIndex = 10;
            this.lblTotalCosts.Text = "Total Costs ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(219, 334);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 39);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(381, 334);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 39);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 406);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTotalCosts);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.txbDiscount);
            this.Controls.Add(this.lblUnitSell);
            this.Controls.Add(this.txbUnitSellingPrice);
            this.Controls.Add(this.lblUnitCost);
            this.Controls.Add(this.txbUnitCost);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txbQuantity);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.cmbStock);
            this.Name = "frmAddItem";
            this.Text = "frmAddItem";
            this.Load += new System.EventHandler(this.frmAddItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStock;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txbQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblUnitCost;
        private System.Windows.Forms.TextBox txbUnitCost;
        private System.Windows.Forms.Label lblUnitSell;
        private System.Windows.Forms.TextBox txbUnitSellingPrice;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txbDiscount;
        private System.Windows.Forms.Label lblTotalCosts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}