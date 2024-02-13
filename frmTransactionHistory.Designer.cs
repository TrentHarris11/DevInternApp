namespace DevInternApp
{
    partial class frmTransactionHistory
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
            this.dataGridViewDisplay = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTransactionType = new System.Windows.Forms.Label();
            this.lblDocumentNo = new System.Windows.Forms.Label();
            this.lblTransactionValue = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.txbDocumentNo = new System.Windows.Forms.TextBox();
            this.txbGrossTransaction = new System.Windows.Forms.TextBox();
            this.txbVat = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbTransactionType = new System.Windows.Forms.ComboBox();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.lblAccountCode = new System.Windows.Forms.Label();
            this.txbAccountCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDisplay
            // 
            this.dataGridViewDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplay.Location = new System.Drawing.Point(90, 250);
            this.dataGridViewDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDisplay.Name = "dataGridViewDisplay";
            this.dataGridViewDisplay.RowHeadersWidth = 51;
            this.dataGridViewDisplay.RowTemplate.Height = 24;
            this.dataGridViewDisplay.Size = new System.Drawing.Size(524, 229);
            this.dataGridViewDisplay.TabIndex = 0;
            this.dataGridViewDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDisplay_CellContentClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(295, 493);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 46);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Location = new System.Drawing.Point(113, 493);
            this.btnAddTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(114, 46);
            this.btnAddTransaction.TabIndex = 2;
            this.btnAddTransaction.Text = "Add Transaction";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 52);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 16);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            // 
            // lblTransactionType
            // 
            this.lblTransactionType.AutoSize = true;
            this.lblTransactionType.Location = new System.Drawing.Point(12, 123);
            this.lblTransactionType.Name = "lblTransactionType";
            this.lblTransactionType.Size = new System.Drawing.Size(113, 16);
            this.lblTransactionType.TabIndex = 4;
            this.lblTransactionType.Text = "Transaction Type";
            // 
            // lblDocumentNo
            // 
            this.lblDocumentNo.AutoSize = true;
            this.lblDocumentNo.Location = new System.Drawing.Point(12, 82);
            this.lblDocumentNo.Name = "lblDocumentNo";
            this.lblDocumentNo.Size = new System.Drawing.Size(89, 16);
            this.lblDocumentNo.TabIndex = 5;
            this.lblDocumentNo.Text = "Document No";
            // 
            // lblTransactionValue
            // 
            this.lblTransactionValue.AutoSize = true;
            this.lblTransactionValue.Location = new System.Drawing.Point(12, 156);
            this.lblTransactionValue.Name = "lblTransactionValue";
            this.lblTransactionValue.Size = new System.Drawing.Size(116, 16);
            this.lblTransactionValue.TabIndex = 6;
            this.lblTransactionValue.Text = "Transaction Value";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Location = new System.Drawing.Point(32, 196);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(27, 16);
            this.lblVat.TabIndex = 7;
            this.lblVat.Text = "Vat";
            // 
            // txbDocumentNo
            // 
            this.txbDocumentNo.Location = new System.Drawing.Point(113, 79);
            this.txbDocumentNo.Name = "txbDocumentNo";
            this.txbDocumentNo.Size = new System.Drawing.Size(200, 22);
            this.txbDocumentNo.TabIndex = 9;
            // 
            // txbGrossTransaction
            // 
            this.txbGrossTransaction.Location = new System.Drawing.Point(113, 153);
            this.txbGrossTransaction.Name = "txbGrossTransaction";
            this.txbGrossTransaction.Size = new System.Drawing.Size(200, 22);
            this.txbGrossTransaction.TabIndex = 10;
            // 
            // txbVat
            // 
            this.txbVat.Location = new System.Drawing.Point(113, 193);
            this.txbVat.Name = "txbVat";
            this.txbVat.Size = new System.Drawing.Size(200, 22);
            this.txbVat.TabIndex = 11;
            this.txbVat.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(113, 45);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 12;
            // 
            // cmbTransactionType
            // 
            this.cmbTransactionType.FormattingEnabled = true;
            this.cmbTransactionType.Items.AddRange(new object[] {
            "Purchase",
            "Credit"});
            this.cmbTransactionType.Location = new System.Drawing.Point(113, 120);
            this.cmbTransactionType.Name = "cmbTransactionType";
            this.cmbTransactionType.Size = new System.Drawing.Size(200, 21);
            this.cmbTransactionType.TabIndex = 14;
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Location = new System.Drawing.Point(463, 493);
            this.btnAddInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(114, 46);
            this.btnAddInvoice.TabIndex = 15;
            this.btnAddInvoice.Text = "Add Invoice";
            this.btnAddInvoice.UseVisualStyleBackColor = true;
            this.btnAddInvoice.Click += new System.EventHandler(this.btnAddInvoice_Click);
            // 
            // lblAccountCode
            // 
            this.lblAccountCode.AutoSize = true;
            this.lblAccountCode.Location = new System.Drawing.Point(10, 19);
            this.lblAccountCode.Name = "lblAccountCode";
            this.lblAccountCode.Size = new System.Drawing.Size(91, 16);
            this.lblAccountCode.TabIndex = 16;
            this.lblAccountCode.Text = "Account Code";
            // 
            // txbAccountCode
            // 
            this.txbAccountCode.Location = new System.Drawing.Point(113, 13);
            this.txbAccountCode.Name = "txbAccountCode";
            this.txbAccountCode.ReadOnly = true;
            this.txbAccountCode.Size = new System.Drawing.Size(200, 22);
            this.txbAccountCode.TabIndex = 17;
            // 
            // frmTransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 551);
            this.Controls.Add(this.txbAccountCode);
            this.Controls.Add(this.lblAccountCode);
            this.Controls.Add(this.btnAddInvoice);
            this.Controls.Add(this.cmbTransactionType);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txbVat);
            this.Controls.Add(this.txbGrossTransaction);
            this.Controls.Add(this.txbDocumentNo);
            this.Controls.Add(this.lblVat);
            this.Controls.Add(this.lblTransactionValue);
            this.Controls.Add(this.lblDocumentNo);
            this.Controls.Add(this.lblTransactionType);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnAddTransaction);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridViewDisplay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTransactionHistory";
            this.Text = "frmTransactionHistory";
            this.Load += new System.EventHandler(this.frmTransactionHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDisplay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTransactionType;
        private System.Windows.Forms.Label lblDocumentNo;
        private System.Windows.Forms.Label lblTransactionValue;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.TextBox txbDocumentNo;
        private System.Windows.Forms.TextBox txbGrossTransaction;
        private System.Windows.Forms.TextBox txbVat;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbTransactionType;
        private System.Windows.Forms.Button btnAddInvoice;
        private System.Windows.Forms.Label lblAccountCode;
        private System.Windows.Forms.TextBox txbAccountCode;
    }
}