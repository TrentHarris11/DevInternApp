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
            this.cmbDebtors = new System.Windows.Forms.ComboBox();
            this.dtpInvoice = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewDisplay = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDebtors
            // 
            this.cmbDebtors.FormattingEnabled = true;
            this.cmbDebtors.Location = new System.Drawing.Point(175, 332);
            this.cmbDebtors.Name = "cmbDebtors";
            this.cmbDebtors.Size = new System.Drawing.Size(302, 24);
            this.cmbDebtors.TabIndex = 0;
            this.cmbDebtors.SelectedIndexChanged += new System.EventHandler(this.cmbDebtors_SelectedIndexChanged);
            // 
            // dtpInvoice
            // 
            this.dtpInvoice.Location = new System.Drawing.Point(600, 331);
            this.dtpInvoice.Name = "dtpInvoice";
            this.dtpInvoice.Size = new System.Drawing.Size(255, 22);
            this.dtpInvoice.TabIndex = 1;
            // 
            // dataGridViewDisplay
            // 
            this.dataGridViewDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplay.Location = new System.Drawing.Point(124, 379);
            this.dataGridViewDisplay.Name = "dataGridViewDisplay";
            this.dataGridViewDisplay.RowHeadersWidth = 51;
            this.dataGridViewDisplay.RowTemplate.Height = 24;
            this.dataGridViewDisplay.Size = new System.Drawing.Size(731, 262);
            this.dataGridViewDisplay.TabIndex = 2;
            this.dataGridViewDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDisplay_CellContentClick);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(124, 686);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(130, 47);
            this.btnView.TabIndex = 20;
            this.btnView.Text = "View Details";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(332, 686);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 47);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save Invoice";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(533, 686);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(130, 47);
            this.btnPrint.TabIndex = 22;
            this.btnPrint.Text = "Print Invoice";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(725, 686);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 47);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDebtor
            // 
            this.lblDebtor.AutoSize = true;
            this.lblDebtor.Location = new System.Drawing.Point(121, 335);
            this.lblDebtor.Name = "lblDebtor";
            this.lblDebtor.Size = new System.Drawing.Size(48, 16);
            this.lblDebtor.TabIndex = 24;
            this.lblDebtor.Text = "Debtor";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Location = new System.Drawing.Point(499, 336);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(82, 16);
            this.lblInvoiceDate.TabIndex = 25;
            this.lblInvoiceDate.Text = "Invoice Date";
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Location = new System.Drawing.Point(37, 34);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(71, 16);
            this.lblInvoiceNo.TabIndex = 26;
            this.lblInvoiceNo.Text = "Invoice No";
            // 
            // lblAccountCode
            // 
            this.lblAccountCode.AutoSize = true;
            this.lblAccountCode.Location = new System.Drawing.Point(37, 72);
            this.lblAccountCode.Name = "lblAccountCode";
            this.lblAccountCode.Size = new System.Drawing.Size(91, 16);
            this.lblAccountCode.TabIndex = 27;
            this.lblAccountCode.Text = "Account Code";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(37, 120);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 16);
            this.lblDate.TabIndex = 28;
            this.lblDate.Text = "Date";
            // 
            // lblTotalSellAmountExclVat
            // 
            this.lblTotalSellAmountExclVat.AutoSize = true;
            this.lblTotalSellAmountExclVat.Location = new System.Drawing.Point(542, 34);
            this.lblTotalSellAmountExclVat.Name = "lblTotalSellAmountExclVat";
            this.lblTotalSellAmountExclVat.Size = new System.Drawing.Size(171, 16);
            this.lblTotalSellAmountExclVat.TabIndex = 29;
            this.lblTotalSellAmountExclVat.Text = "Total Sell Amount (Excl Vat)";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Location = new System.Drawing.Point(542, 72);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(27, 16);
            this.lblVat.TabIndex = 30;
            this.lblVat.Text = "Vat";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(542, 117);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(68, 16);
            this.lblTotalCost.TabIndex = 31;
            this.lblTotalCost.Text = "Total Cost";
            this.lblTotalCost.Click += new System.EventHandler(this.lblTotalCost_Click);
            // 
            // txbInvoiceNo
            // 
            this.txbInvoiceNo.Location = new System.Drawing.Point(175, 28);
            this.txbInvoiceNo.Name = "txbInvoiceNo";
            this.txbInvoiceNo.Size = new System.Drawing.Size(135, 22);
            this.txbInvoiceNo.TabIndex = 32;
            // 
            // txbAccCode
            // 
            this.txbAccCode.Location = new System.Drawing.Point(175, 66);
            this.txbAccCode.Name = "txbAccCode";
            this.txbAccCode.Size = new System.Drawing.Size(135, 22);
            this.txbAccCode.TabIndex = 33;
            // 
            // txbTotalCost
            // 
            this.txbTotalCost.Location = new System.Drawing.Point(744, 120);
            this.txbTotalCost.Name = "txbTotalCost";
            this.txbTotalCost.Size = new System.Drawing.Size(135, 22);
            this.txbTotalCost.TabIndex = 34;
            // 
            // txbVat
            // 
            this.txbVat.Location = new System.Drawing.Point(745, 75);
            this.txbVat.Name = "txbVat";
            this.txbVat.Size = new System.Drawing.Size(135, 22);
            this.txbVat.TabIndex = 35;
            // 
            // txbTotalSellExclVat
            // 
            this.txbTotalSellExclVat.Location = new System.Drawing.Point(745, 28);
            this.txbTotalSellExclVat.Name = "txbTotalSellExclVat";
            this.txbTotalSellExclVat.Size = new System.Drawing.Size(135, 22);
            this.txbTotalSellExclVat.TabIndex = 36;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(175, 120);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(244, 22);
            this.dtpDate.TabIndex = 37;
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Location = new System.Drawing.Point(360, 206);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(130, 46);
            this.btnAddInvoice.TabIndex = 38;
            this.btnAddInvoice.Text = "Add Invoice";
            this.btnAddInvoice.UseVisualStyleBackColor = true;
            this.btnAddInvoice.Click += new System.EventHandler(this.btnAddInvoice_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(533, 206);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 46);
            this.btnClear.TabIndex = 39;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmInvoicing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 767);
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
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dataGridViewDisplay);
            this.Controls.Add(this.dtpInvoice);
            this.Controls.Add(this.cmbDebtors);
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
        private System.Windows.Forms.Button btnSave;
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
    }
}