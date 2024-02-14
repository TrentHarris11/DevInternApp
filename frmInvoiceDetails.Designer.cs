namespace DevInternApp
{
    partial class frmInvoiceDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoiceDetails));
            this.dataGridViewDisplay = new System.Windows.Forms.DataGridView();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.txbInvoiceNo = new System.Windows.Forms.TextBox();
            this.txbItemNo = new System.Windows.Forms.TextBox();
            this.lblItemNo = new System.Windows.Forms.Label();
            this.lblStockCode = new System.Windows.Forms.Label();
            this.txbQtySold = new System.Windows.Forms.TextBox();
            this.lblQtySold = new System.Windows.Forms.Label();
            this.txbUnitCost = new System.Windows.Forms.TextBox();
            this.lblUnitCost = new System.Windows.Forms.Label();
            this.txbUnitSell = new System.Windows.Forms.TextBox();
            this.lblUnitSell = new System.Windows.Forms.Label();
            this.txbDiscount = new System.Windows.Forms.TextBox();
            this.lblDisc = new System.Windows.Forms.Label();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbStockCode = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDisplay
            // 
            this.dataGridViewDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplay.Location = new System.Drawing.Point(66, 195);
            this.dataGridViewDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDisplay.Name = "dataGridViewDisplay";
            this.dataGridViewDisplay.RowHeadersWidth = 51;
            this.dataGridViewDisplay.RowTemplate.Height = 24;
            this.dataGridViewDisplay.Size = new System.Drawing.Size(604, 169);
            this.dataGridViewDisplay.TabIndex = 0;
            this.dataGridViewDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDisplay_CellContentClick);
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Location = new System.Drawing.Point(63, 30);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(59, 13);
            this.lblInvoiceNo.TabIndex = 1;
            this.lblInvoiceNo.Text = "Invoice No";
            // 
            // txbInvoiceNo
            // 
            this.txbInvoiceNo.Location = new System.Drawing.Point(133, 27);
            this.txbInvoiceNo.Name = "txbInvoiceNo";
            this.txbInvoiceNo.Size = new System.Drawing.Size(134, 20);
            this.txbInvoiceNo.TabIndex = 2;
            // 
            // txbItemNo
            // 
            this.txbItemNo.Location = new System.Drawing.Point(133, 53);
            this.txbItemNo.Name = "txbItemNo";
            this.txbItemNo.Size = new System.Drawing.Size(134, 20);
            this.txbItemNo.TabIndex = 4;
            // 
            // lblItemNo
            // 
            this.lblItemNo.AutoSize = true;
            this.lblItemNo.Location = new System.Drawing.Point(63, 56);
            this.lblItemNo.Name = "lblItemNo";
            this.lblItemNo.Size = new System.Drawing.Size(44, 13);
            this.lblItemNo.TabIndex = 3;
            this.lblItemNo.Text = "Item No";
            // 
            // lblStockCode
            // 
            this.lblStockCode.AutoSize = true;
            this.lblStockCode.Location = new System.Drawing.Point(63, 91);
            this.lblStockCode.Name = "lblStockCode";
            this.lblStockCode.Size = new System.Drawing.Size(63, 13);
            this.lblStockCode.TabIndex = 5;
            this.lblStockCode.Text = "Stock Code";
            // 
            // txbQtySold
            // 
            this.txbQtySold.Location = new System.Drawing.Point(133, 127);
            this.txbQtySold.Name = "txbQtySold";
            this.txbQtySold.Size = new System.Drawing.Size(134, 20);
            this.txbQtySold.TabIndex = 8;
            // 
            // lblQtySold
            // 
            this.lblQtySold.AutoSize = true;
            this.lblQtySold.Location = new System.Drawing.Point(63, 130);
            this.lblQtySold.Name = "lblQtySold";
            this.lblQtySold.Size = new System.Drawing.Size(47, 13);
            this.lblQtySold.TabIndex = 7;
            this.lblQtySold.Text = "Qty Sold";
            // 
            // txbUnitCost
            // 
            this.txbUnitCost.Location = new System.Drawing.Point(478, 27);
            this.txbUnitCost.Name = "txbUnitCost";
            this.txbUnitCost.Size = new System.Drawing.Size(134, 20);
            this.txbUnitCost.TabIndex = 10;
            // 
            // lblUnitCost
            // 
            this.lblUnitCost.AutoSize = true;
            this.lblUnitCost.Location = new System.Drawing.Point(408, 30);
            this.lblUnitCost.Name = "lblUnitCost";
            this.lblUnitCost.Size = new System.Drawing.Size(50, 13);
            this.lblUnitCost.TabIndex = 9;
            this.lblUnitCost.Text = "Unit Cost";
            // 
            // txbUnitSell
            // 
            this.txbUnitSell.Location = new System.Drawing.Point(478, 56);
            this.txbUnitSell.Name = "txbUnitSell";
            this.txbUnitSell.Size = new System.Drawing.Size(134, 20);
            this.txbUnitSell.TabIndex = 12;
            // 
            // lblUnitSell
            // 
            this.lblUnitSell.AutoSize = true;
            this.lblUnitSell.Location = new System.Drawing.Point(408, 59);
            this.lblUnitSell.Name = "lblUnitSell";
            this.lblUnitSell.Size = new System.Drawing.Size(46, 13);
            this.lblUnitSell.TabIndex = 11;
            this.lblUnitSell.Text = "Unit Sell";
            // 
            // txbDiscount
            // 
            this.txbDiscount.Location = new System.Drawing.Point(478, 88);
            this.txbDiscount.Name = "txbDiscount";
            this.txbDiscount.Size = new System.Drawing.Size(134, 20);
            this.txbDiscount.TabIndex = 14;
            this.txbDiscount.Text = "l";
            // 
            // lblDisc
            // 
            this.lblDisc.AutoSize = true;
            this.lblDisc.Location = new System.Drawing.Point(408, 91);
            this.lblDisc.Name = "lblDisc";
            this.lblDisc.Size = new System.Drawing.Size(49, 13);
            this.lblDisc.TabIndex = 13;
            this.lblDisc.Text = "Discount";
            // 
            // txbTotal
            // 
            this.txbTotal.Location = new System.Drawing.Point(478, 130);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(134, 20);
            this.txbTotal.TabIndex = 16;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(408, 130);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total";
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Location = new System.Drawing.Point(166, 378);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(113, 40);
            this.btnAddInvoice.TabIndex = 17;
            this.btnAddInvoice.Text = "Add To Invoice";
            this.btnAddInvoice.UseVisualStyleBackColor = true;
            this.btnAddInvoice.Click += new System.EventHandler(this.btnAddInvoice_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(457, 378);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 40);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbStockCode
            // 
            this.cmbStockCode.FormattingEnabled = true;
            this.cmbStockCode.Location = new System.Drawing.Point(133, 87);
            this.cmbStockCode.Name = "cmbStockCode";
            this.cmbStockCode.Size = new System.Drawing.Size(134, 21);
            this.cmbStockCode.TabIndex = 19;
            this.cmbStockCode.SelectedIndexChanged += new System.EventHandler(this.cmbStockCode_SelectedIndexChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(310, 378);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(113, 40);
            this.btnPrint.TabIndex = 20;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmInvoiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(723, 502);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cmbStockCode);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddInvoice);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txbDiscount);
            this.Controls.Add(this.lblDisc);
            this.Controls.Add(this.txbUnitSell);
            this.Controls.Add(this.lblUnitSell);
            this.Controls.Add(this.txbUnitCost);
            this.Controls.Add(this.lblUnitCost);
            this.Controls.Add(this.txbQtySold);
            this.Controls.Add(this.lblQtySold);
            this.Controls.Add(this.lblStockCode);
            this.Controls.Add(this.txbItemNo);
            this.Controls.Add(this.lblItemNo);
            this.Controls.Add(this.txbInvoiceNo);
            this.Controls.Add(this.lblInvoiceNo);
            this.Controls.Add(this.dataGridViewDisplay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInvoiceDetails";
            this.Text = "frmInvoiceDetails";
            this.Load += new System.EventHandler(this.frmInvoiceHeader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDisplay;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.TextBox txbInvoiceNo;
        private System.Windows.Forms.TextBox txbItemNo;
        private System.Windows.Forms.Label lblItemNo;
        private System.Windows.Forms.Label lblStockCode;
        private System.Windows.Forms.TextBox txbQtySold;
        private System.Windows.Forms.Label lblQtySold;
        private System.Windows.Forms.TextBox txbUnitCost;
        private System.Windows.Forms.Label lblUnitCost;
        private System.Windows.Forms.TextBox txbUnitSell;
        private System.Windows.Forms.Label lblUnitSell;
        private System.Windows.Forms.TextBox txbDiscount;
        private System.Windows.Forms.Label lblDisc;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAddInvoice;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbStockCode;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}