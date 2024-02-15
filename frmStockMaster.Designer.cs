namespace DevInternApp
{
    partial class frmStockMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockMaster));
            this.txbStockCode = new System.Windows.Forms.TextBox();
            this.txbStockDescription = new System.Windows.Forms.TextBox();
            this.nudSellingP = new System.Windows.Forms.NumericUpDown();
            this.nudPurchasesExclVat = new System.Windows.Forms.NumericUpDown();
            this.nudSalesExclVat = new System.Windows.Forms.NumericUpDown();
            this.nudQtyPurchased = new System.Windows.Forms.NumericUpDown();
            this.nudQtySold = new System.Windows.Forms.NumericUpDown();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.nudCost = new System.Windows.Forms.NumericUpDown();
            this.lblStockCode = new System.Windows.Forms.Label();
            this.lblStockDescription = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblSellingPrice = new System.Windows.Forms.Label();
            this.lblTotalExclVat = new System.Windows.Forms.Label();
            this.lblSalesExclVat = new System.Windows.Forms.Label();
            this.lblQtyPurchased = new System.Windows.Forms.Label();
            this.lblQtySold = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMainScreen = new System.Windows.Forms.Button();
            this.btnStockMaster = new System.Windows.Forms.Button();
            this.btnCalcPurchases = new System.Windows.Forms.Button();
            this.btnCalculateTotalSales = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSellingP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchasesExclVat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalesExclVat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtyPurchased)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtySold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).BeginInit();
            this.SuspendLayout();
            // 
            // txbStockCode
            // 
            this.txbStockCode.Location = new System.Drawing.Point(152, 11);
            this.txbStockCode.Margin = new System.Windows.Forms.Padding(2);
            this.txbStockCode.Name = "txbStockCode";
            this.txbStockCode.Size = new System.Drawing.Size(91, 20);
            this.txbStockCode.TabIndex = 0;
            // 
            // txbStockDescription
            // 
            this.txbStockDescription.Location = new System.Drawing.Point(152, 51);
            this.txbStockDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txbStockDescription.Name = "txbStockDescription";
            this.txbStockDescription.Size = new System.Drawing.Size(91, 20);
            this.txbStockDescription.TabIndex = 1;
            // 
            // nudSellingP
            // 
            this.nudSellingP.Location = new System.Drawing.Point(152, 150);
            this.nudSellingP.Margin = new System.Windows.Forms.Padding(2);
            this.nudSellingP.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSellingP.Name = "nudSellingP";
            this.nudSellingP.Size = new System.Drawing.Size(90, 20);
            this.nudSellingP.TabIndex = 2;
            // 
            // nudPurchasesExclVat
            // 
            this.nudPurchasesExclVat.Location = new System.Drawing.Point(152, 193);
            this.nudPurchasesExclVat.Margin = new System.Windows.Forms.Padding(2);
            this.nudPurchasesExclVat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPurchasesExclVat.Name = "nudPurchasesExclVat";
            this.nudPurchasesExclVat.Size = new System.Drawing.Size(90, 20);
            this.nudPurchasesExclVat.TabIndex = 3;
            // 
            // nudSalesExclVat
            // 
            this.nudSalesExclVat.Location = new System.Drawing.Point(152, 236);
            this.nudSalesExclVat.Margin = new System.Windows.Forms.Padding(2);
            this.nudSalesExclVat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSalesExclVat.Name = "nudSalesExclVat";
            this.nudSalesExclVat.Size = new System.Drawing.Size(90, 20);
            this.nudSalesExclVat.TabIndex = 4;
            // 
            // nudQtyPurchased
            // 
            this.nudQtyPurchased.Location = new System.Drawing.Point(490, 11);
            this.nudQtyPurchased.Margin = new System.Windows.Forms.Padding(2);
            this.nudQtyPurchased.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudQtyPurchased.Name = "nudQtyPurchased";
            this.nudQtyPurchased.Size = new System.Drawing.Size(90, 20);
            this.nudQtyPurchased.TabIndex = 5;
            // 
            // nudQtySold
            // 
            this.nudQtySold.Location = new System.Drawing.Point(490, 52);
            this.nudQtySold.Margin = new System.Windows.Forms.Padding(2);
            this.nudQtySold.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudQtySold.Name = "nudQtySold";
            this.nudQtySold.Size = new System.Drawing.Size(90, 20);
            this.nudQtySold.TabIndex = 6;
            // 
            // nudStock
            // 
            this.nudStock.Location = new System.Drawing.Point(490, 102);
            this.nudStock.Margin = new System.Windows.Forms.Padding(2);
            this.nudStock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(90, 20);
            this.nudStock.TabIndex = 7;
            // 
            // nudCost
            // 
            this.nudCost.Location = new System.Drawing.Point(152, 111);
            this.nudCost.Margin = new System.Windows.Forms.Padding(2);
            this.nudCost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCost.Name = "nudCost";
            this.nudCost.Size = new System.Drawing.Size(90, 20);
            this.nudCost.TabIndex = 8;
            // 
            // lblStockCode
            // 
            this.lblStockCode.AutoSize = true;
            this.lblStockCode.Location = new System.Drawing.Point(9, 15);
            this.lblStockCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockCode.Name = "lblStockCode";
            this.lblStockCode.Size = new System.Drawing.Size(69, 15);
            this.lblStockCode.TabIndex = 9;
            this.lblStockCode.Text = "Stock Code";
            // 
            // lblStockDescription
            // 
            this.lblStockDescription.AutoSize = true;
            this.lblStockDescription.Location = new System.Drawing.Point(9, 57);
            this.lblStockDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockDescription.Name = "lblStockDescription";
            this.lblStockDescription.Size = new System.Drawing.Size(102, 15);
            this.lblStockDescription.TabIndex = 10;
            this.lblStockDescription.Text = "Stock Description";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(9, 116);
            this.lblCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(31, 15);
            this.lblCost.TabIndex = 11;
            this.lblCost.Text = "Cost";
            // 
            // lblSellingPrice
            // 
            this.lblSellingPrice.AutoSize = true;
            this.lblSellingPrice.Location = new System.Drawing.Point(9, 155);
            this.lblSellingPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSellingPrice.Name = "lblSellingPrice";
            this.lblSellingPrice.Size = new System.Drawing.Size(76, 15);
            this.lblSellingPrice.TabIndex = 12;
            this.lblSellingPrice.Text = "Selling Price";
            // 
            // lblTotalExclVat
            // 
            this.lblTotalExclVat.AutoSize = true;
            this.lblTotalExclVat.Location = new System.Drawing.Point(9, 193);
            this.lblTotalExclVat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalExclVat.Name = "lblTotalExclVat";
            this.lblTotalExclVat.Size = new System.Drawing.Size(149, 15);
            this.lblTotalExclVat.TabIndex = 13;
            this.lblTotalExclVat.Text = "Total Purchases (Excl Vat)";
            // 
            // lblSalesExclVat
            // 
            this.lblSalesExclVat.AutoSize = true;
            this.lblSalesExclVat.Location = new System.Drawing.Point(9, 240);
            this.lblSalesExclVat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalesExclVat.Name = "lblSalesExclVat";
            this.lblSalesExclVat.Size = new System.Drawing.Size(122, 15);
            this.lblSalesExclVat.TabIndex = 14;
            this.lblSalesExclVat.Text = "Total Sales (Excl Vat)";
            // 
            // lblQtyPurchased
            // 
            this.lblQtyPurchased.AutoSize = true;
            this.lblQtyPurchased.Location = new System.Drawing.Point(380, 15);
            this.lblQtyPurchased.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQtyPurchased.Name = "lblQtyPurchased";
            this.lblQtyPurchased.Size = new System.Drawing.Size(113, 15);
            this.lblQtyPurchased.TabIndex = 15;
            this.lblQtyPurchased.Text = "Quantity Purchased";
            // 
            // lblQtySold
            // 
            this.lblQtySold.AutoSize = true;
            this.lblQtySold.Location = new System.Drawing.Point(380, 56);
            this.lblQtySold.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQtySold.Name = "lblQtySold";
            this.lblQtySold.Size = new System.Drawing.Size(79, 15);
            this.lblQtySold.TabIndex = 16;
            this.lblQtySold.Text = "Quantity Sold";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(380, 107);
            this.lblStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(87, 15);
            this.lblStock.TabIndex = 17;
            this.lblStock.Text = "Stock on Hand";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(11, 305);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 38);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(124, 305);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 38);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(245, 305);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 38);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMainScreen
            // 
            this.btnMainScreen.Location = new System.Drawing.Point(482, 305);
            this.btnMainScreen.Margin = new System.Windows.Forms.Padding(2);
            this.btnMainScreen.Name = "btnMainScreen";
            this.btnMainScreen.Size = new System.Drawing.Size(98, 38);
            this.btnMainScreen.TabIndex = 22;
            this.btnMainScreen.Text = "Main Screen";
            this.btnMainScreen.UseVisualStyleBackColor = true;
            this.btnMainScreen.Click += new System.EventHandler(this.btnMainScreen_Click);
            // 
            // btnStockMaster
            // 
            this.btnStockMaster.Location = new System.Drawing.Point(365, 305);
            this.btnStockMaster.Margin = new System.Windows.Forms.Padding(2);
            this.btnStockMaster.Name = "btnStockMaster";
            this.btnStockMaster.Size = new System.Drawing.Size(98, 38);
            this.btnStockMaster.TabIndex = 23;
            this.btnStockMaster.Text = "View Stocks";
            this.btnStockMaster.UseVisualStyleBackColor = true;
            this.btnStockMaster.Click += new System.EventHandler(this.btnStockMaster_Click);
            // 
            // btnCalcPurchases
            // 
            this.btnCalcPurchases.Location = new System.Drawing.Point(257, 193);
            this.btnCalcPurchases.Name = "btnCalcPurchases";
            this.btnCalcPurchases.Size = new System.Drawing.Size(75, 20);
            this.btnCalcPurchases.TabIndex = 24;
            this.btnCalcPurchases.Text = "Calculate";
            this.btnCalcPurchases.UseVisualStyleBackColor = true;
            this.btnCalcPurchases.Click += new System.EventHandler(this.btnCalcPurchases_Click);
            // 
            // btnCalculateTotalSales
            // 
            this.btnCalculateTotalSales.Location = new System.Drawing.Point(257, 236);
            this.btnCalculateTotalSales.Name = "btnCalculateTotalSales";
            this.btnCalculateTotalSales.Size = new System.Drawing.Size(75, 20);
            this.btnCalculateTotalSales.TabIndex = 25;
            this.btnCalculateTotalSales.Text = "Calculate";
            this.btnCalculateTotalSales.UseVisualStyleBackColor = true;
            this.btnCalculateTotalSales.Click += new System.EventHandler(this.btnCalculateTotalSales_Click);
            // 
            // frmStockMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnCalculateTotalSales);
            this.Controls.Add(this.btnCalcPurchases);
            this.Controls.Add(this.btnStockMaster);
            this.Controls.Add(this.btnMainScreen);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblQtySold);
            this.Controls.Add(this.lblQtyPurchased);
            this.Controls.Add(this.lblSalesExclVat);
            this.Controls.Add(this.lblTotalExclVat);
            this.Controls.Add(this.lblSellingPrice);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblStockDescription);
            this.Controls.Add(this.lblStockCode);
            this.Controls.Add(this.nudCost);
            this.Controls.Add(this.nudStock);
            this.Controls.Add(this.nudQtySold);
            this.Controls.Add(this.nudQtyPurchased);
            this.Controls.Add(this.nudSalesExclVat);
            this.Controls.Add(this.nudPurchasesExclVat);
            this.Controls.Add(this.nudSellingP);
            this.Controls.Add(this.txbStockDescription);
            this.Controls.Add(this.txbStockCode);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmStockMaster";
            this.Text = "frmStockMaster";
            this.Load += new System.EventHandler(this.frmStockMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSellingP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchasesExclVat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalesExclVat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtyPurchased)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtySold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbStockCode;
        private System.Windows.Forms.TextBox txbStockDescription;
        private System.Windows.Forms.NumericUpDown nudSellingP;
        private System.Windows.Forms.NumericUpDown nudPurchasesExclVat;
        private System.Windows.Forms.NumericUpDown nudSalesExclVat;
        private System.Windows.Forms.NumericUpDown nudQtyPurchased;
        private System.Windows.Forms.NumericUpDown nudQtySold;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.NumericUpDown nudCost;
        private System.Windows.Forms.Label lblStockCode;
        private System.Windows.Forms.Label lblStockDescription;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblSellingPrice;
        private System.Windows.Forms.Label lblTotalExclVat;
        private System.Windows.Forms.Label lblSalesExclVat;
        private System.Windows.Forms.Label lblQtyPurchased;
        private System.Windows.Forms.Label lblQtySold;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMainScreen;
        private System.Windows.Forms.Button btnStockMaster;
        private System.Windows.Forms.Button btnCalcPurchases;
        private System.Windows.Forms.Button btnCalculateTotalSales;
    }
}