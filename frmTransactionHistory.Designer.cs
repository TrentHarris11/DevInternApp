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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactionHistory));
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDisplay
            // 
            this.dataGridViewDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplay.Location = new System.Drawing.Point(30, 192);
            this.dataGridViewDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDisplay.Name = "dataGridViewDisplay";
            this.dataGridViewDisplay.RowHeadersWidth = 51;
            this.dataGridViewDisplay.RowTemplate.Height = 24;
            this.dataGridViewDisplay.Size = new System.Drawing.Size(652, 229);
            this.dataGridViewDisplay.TabIndex = 0;
            this.dataGridViewDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDisplay_CellContentClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(307, 439);
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
            this.btnAddTransaction.Location = new System.Drawing.Point(159, 438);
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
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            // 
            // lblTransactionType
            // 
            this.lblTransactionType.AutoSize = true;
            this.lblTransactionType.Location = new System.Drawing.Point(334, 20);
            this.lblTransactionType.Name = "lblTransactionType";
            this.lblTransactionType.Size = new System.Drawing.Size(90, 13);
            this.lblTransactionType.TabIndex = 4;
            this.lblTransactionType.Text = "Transaction Type";
            // 
            // lblDocumentNo
            // 
            this.lblDocumentNo.AutoSize = true;
            this.lblDocumentNo.Location = new System.Drawing.Point(12, 82);
            this.lblDocumentNo.Name = "lblDocumentNo";
            this.lblDocumentNo.Size = new System.Drawing.Size(73, 13);
            this.lblDocumentNo.TabIndex = 5;
            this.lblDocumentNo.Text = "Document No";
            // 
            // lblTransactionValue
            // 
            this.lblTransactionValue.AutoSize = true;
            this.lblTransactionValue.Location = new System.Drawing.Point(334, 51);
            this.lblTransactionValue.Name = "lblTransactionValue";
            this.lblTransactionValue.Size = new System.Drawing.Size(93, 13);
            this.lblTransactionValue.TabIndex = 6;
            this.lblTransactionValue.Text = "Transaction Value";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Location = new System.Drawing.Point(355, 82);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(23, 13);
            this.lblVat.TabIndex = 7;
            this.lblVat.Text = "Vat";
            // 
            // txbDocumentNo
            // 
            this.txbDocumentNo.Location = new System.Drawing.Point(113, 79);
            this.txbDocumentNo.Name = "txbDocumentNo";
            this.txbDocumentNo.Size = new System.Drawing.Size(200, 20);
            this.txbDocumentNo.TabIndex = 9;
            // 
            // txbGrossTransaction
            // 
            this.txbGrossTransaction.Location = new System.Drawing.Point(435, 48);
            this.txbGrossTransaction.Name = "txbGrossTransaction";
            this.txbGrossTransaction.Size = new System.Drawing.Size(183, 20);
            this.txbGrossTransaction.TabIndex = 10;
            // 
            // txbVat
            // 
            this.txbVat.Location = new System.Drawing.Point(435, 79);
            this.txbVat.Name = "txbVat";
            this.txbVat.Size = new System.Drawing.Size(183, 20);
            this.txbVat.TabIndex = 11;
            this.txbVat.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(113, 45);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 12;
            // 
            // cmbTransactionType
            // 
            this.cmbTransactionType.FormattingEnabled = true;
            this.cmbTransactionType.Items.AddRange(new object[] {
            "Purchase"});
            this.cmbTransactionType.Location = new System.Drawing.Point(435, 17);
            this.cmbTransactionType.Name = "cmbTransactionType";
            this.cmbTransactionType.Size = new System.Drawing.Size(183, 21);
            this.cmbTransactionType.TabIndex = 14;
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Location = new System.Drawing.Point(468, 438);
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
            this.lblAccountCode.Size = new System.Drawing.Size(75, 13);
            this.lblAccountCode.TabIndex = 16;
            this.lblAccountCode.Text = "Account Code";
            // 
            // txbAccountCode
            // 
            this.txbAccountCode.Location = new System.Drawing.Point(113, 13);
            this.txbAccountCode.Name = "txbAccountCode";
            this.txbAccountCode.ReadOnly = true;
            this.txbAccountCode.Size = new System.Drawing.Size(200, 20);
            this.txbAccountCode.TabIndex = 17;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(624, 79);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(607, 159);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 19);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(30, 158);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(573, 20);
            this.txbSearch.TabIndex = 19;
            // 
            // frmTransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(715, 551);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.btnCalculate);
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
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}