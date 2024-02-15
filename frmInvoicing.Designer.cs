namespace DevInternApp
{
    partial class frmInvoicing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoicing));
            this.cmbDebtors = new System.Windows.Forms.ComboBox();
            this.dtpInvoice = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewDisplay = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDebtor = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.lblAccountCode = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTotalSellAmountExclVat = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.txbInvoiceNo = new System.Windows.Forms.TextBox();
            this.txbAccCode = new System.Windows.Forms.TextBox();
            this.txbTotalCost = new System.Windows.Forms.TextBox();
            this.txbVat = new System.Windows.Forms.TextBox();
            this.txbTotalSellExclVat = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDebtors
            // 
            this.cmbDebtors.FormattingEnabled = true;
            this.cmbDebtors.Location = new System.Drawing.Point(131, 270);
            this.cmbDebtors.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDebtors.Name = "cmbDebtors";
            this.cmbDebtors.Size = new System.Drawing.Size(228, 21);
            this.cmbDebtors.TabIndex = 0;
            this.cmbDebtors.SelectedIndexChanged += new System.EventHandler(this.cmbDebtors_SelectedIndexChanged);
            // 
            // dtpInvoice
            // 
            this.dtpInvoice.Location = new System.Drawing.Point(450, 269);
            this.dtpInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.dtpInvoice.Name = "dtpInvoice";
            this.dtpInvoice.Size = new System.Drawing.Size(192, 20);
            this.dtpInvoice.TabIndex = 1;
            // 
            // dataGridViewDisplay
            // 
            this.dataGridViewDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplay.Location = new System.Drawing.Point(31, 308);
            this.dataGridViewDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDisplay.Name = "dataGridViewDisplay";
            this.dataGridViewDisplay.RowHeadersWidth = 51;
            this.dataGridViewDisplay.RowTemplate.Height = 24;
            this.dataGridViewDisplay.Size = new System.Drawing.Size(630, 213);
            this.dataGridViewDisplay.TabIndex = 2;
            this.dataGridViewDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDisplay_CellContentClick);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(118, 557);
            this.btnView.Margin = new System.Windows.Forms.Padding(2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(98, 38);
            this.btnView.TabIndex = 20;
            this.btnView.Text = "View Details";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(350, 557);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(98, 38);
            this.btnPrint.TabIndex = 22;
            this.btnPrint.Text = "Print Invoice";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(478, 557);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 38);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDebtor
            // 
            this.lblDebtor.AutoSize = true;
            this.lblDebtor.Location = new System.Drawing.Point(91, 272);
            this.lblDebtor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDebtor.Name = "lblDebtor";
            this.lblDebtor.Size = new System.Drawing.Size(44, 15);
            this.lblDebtor.TabIndex = 24;
            this.lblDebtor.Text = "Debtor";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Location = new System.Drawing.Point(374, 273);
            this.lblInvoiceDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(74, 15);
            this.lblInvoiceDate.TabIndex = 25;
            this.lblInvoiceDate.Text = "Invoice Date";
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Location = new System.Drawing.Point(28, 28);
            this.lblInvoiceNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(64, 15);
            this.lblInvoiceNo.TabIndex = 26;
            this.lblInvoiceNo.Text = "Invoice No";
            // 
            // lblAccountCode
            // 
            this.lblAccountCode.AutoSize = true;
            this.lblAccountCode.Location = new System.Drawing.Point(28, 58);
            this.lblAccountCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountCode.Name = "lblAccountCode";
            this.lblAccountCode.Size = new System.Drawing.Size(82, 15);
            this.lblAccountCode.TabIndex = 27;
            this.lblAccountCode.Text = "Account Code";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(28, 98);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 15);
            this.lblDate.TabIndex = 28;
            this.lblDate.Text = "Date";
            // 
            // lblTotalSellAmountExclVat
            // 
            this.lblTotalSellAmountExclVat.AutoSize = true;
            this.lblTotalSellAmountExclVat.Location = new System.Drawing.Point(406, 28);
            this.lblTotalSellAmountExclVat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalSellAmountExclVat.Name = "lblTotalSellAmountExclVat";
            this.lblTotalSellAmountExclVat.Size = new System.Drawing.Size(157, 15);
            this.lblTotalSellAmountExclVat.TabIndex = 29;
            this.lblTotalSellAmountExclVat.Text = "Total Sell Amount (Excl Vat)";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Location = new System.Drawing.Point(406, 58);
            this.lblVat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(24, 15);
            this.lblVat.TabIndex = 30;
            this.lblVat.Text = "Vat";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(406, 95);
            this.lblTotalCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(61, 15);
            this.lblTotalCost.TabIndex = 31;
            this.lblTotalCost.Text = "Total Cost";
            this.lblTotalCost.Click += new System.EventHandler(this.lblTotalCost_Click);
            // 
            // txbInvoiceNo
            // 
            this.txbInvoiceNo.Location = new System.Drawing.Point(131, 23);
            this.txbInvoiceNo.Margin = new System.Windows.Forms.Padding(2);
            this.txbInvoiceNo.Name = "txbInvoiceNo";
            this.txbInvoiceNo.Size = new System.Drawing.Size(102, 20);
            this.txbInvoiceNo.TabIndex = 32;
            // 
            // txbAccCode
            // 
            this.txbAccCode.Location = new System.Drawing.Point(131, 54);
            this.txbAccCode.Margin = new System.Windows.Forms.Padding(2);
            this.txbAccCode.Name = "txbAccCode";
            this.txbAccCode.Size = new System.Drawing.Size(102, 20);
            this.txbAccCode.TabIndex = 33;
            // 
            // txbTotalCost
            // 
            this.txbTotalCost.Location = new System.Drawing.Point(558, 98);
            this.txbTotalCost.Margin = new System.Windows.Forms.Padding(2);
            this.txbTotalCost.Name = "txbTotalCost";
            this.txbTotalCost.Size = new System.Drawing.Size(102, 20);
            this.txbTotalCost.TabIndex = 34;
            // 
            // txbVat
            // 
            this.txbVat.Location = new System.Drawing.Point(559, 61);
            this.txbVat.Margin = new System.Windows.Forms.Padding(2);
            this.txbVat.Name = "txbVat";
            this.txbVat.Size = new System.Drawing.Size(102, 20);
            this.txbVat.TabIndex = 35;
            // 
            // txbTotalSellExclVat
            // 
            this.txbTotalSellExclVat.Location = new System.Drawing.Point(559, 23);
            this.txbTotalSellExclVat.Margin = new System.Windows.Forms.Padding(2);
            this.txbTotalSellExclVat.Name = "txbTotalSellExclVat";
            this.txbTotalSellExclVat.Size = new System.Drawing.Size(102, 20);
            this.txbTotalSellExclVat.TabIndex = 36;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(131, 96);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(184, 20);
            this.dtpDate.TabIndex = 37;
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Location = new System.Drawing.Point(270, 167);
            this.btnAddInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(98, 37);
            this.btnAddInvoice.TabIndex = 38;
            this.btnAddInvoice.Text = "Add Invoice";
            this.btnAddInvoice.UseVisualStyleBackColor = true;
            this.btnAddInvoice.Click += new System.EventHandler(this.btnAddInvoice_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(400, 167);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 37);
            this.btnClear.TabIndex = 39;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(232, 557);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(98, 38);
            this.btnRefresh.TabIndex = 41;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmInvoicing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 623);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddInvoice);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txbTotalSellExclVat);
            this.Controls.Add(this.txbVat);
            this.Controls.Add(this.txbTotalCost);
            this.Controls.Add(this.txbAccCode);
            this.Controls.Add(this.txbInvoiceNo);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblVat);
            this.Controls.Add(this.lblTotalSellAmountExclVat);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblAccountCode);
            this.Controls.Add(this.lblInvoiceNo);
            this.Controls.Add(this.lblInvoiceDate);
            this.Controls.Add(this.lblDebtor);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dataGridViewDisplay);
            this.Controls.Add(this.dtpInvoice);
            this.Controls.Add(this.cmbDebtors);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInvoicing";
            this.Text = "frmInvoicing";
            this.Load += new System.EventHandler(this.frmInvoicing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDebtors;
        private System.Windows.Forms.DateTimePicker dtpInvoice;
        private System.Windows.Forms.DataGridView dataGridViewDisplay;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDebtor;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Label lblAccountCode;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTotalSellAmountExclVat;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.TextBox txbInvoiceNo;
        private System.Windows.Forms.TextBox txbAccCode;
        private System.Windows.Forms.TextBox txbTotalCost;
        private System.Windows.Forms.TextBox txbVat;
        private System.Windows.Forms.TextBox txbTotalSellExclVat;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnAddInvoice;
        private System.Windows.Forms.Button btnClear;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnRefresh;
    }
}