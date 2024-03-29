﻿namespace DevInternApp
{
    partial class frmStockTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockTransactions));
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridViewDisplay = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTransactionType = new System.Windows.Forms.Label();
            this.lblDocumentNo = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblUnitCost = new System.Windows.Forms.Label();
            this.lblUnitSell = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txbDocumentNo = new System.Windows.Forms.TextBox();
            this.txbQty = new System.Windows.Forms.TextBox();
            this.txbUnitCost = new System.Windows.Forms.TextBox();
            this.txbUnitSell = new System.Windows.Forms.TextBox();
            this.cmbTransactionType = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(419, 433);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 46);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridViewDisplay
            // 
            this.dataGridViewDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplay.Location = new System.Drawing.Point(23, 189);
            this.dataGridViewDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDisplay.Name = "dataGridViewDisplay";
            this.dataGridViewDisplay.RowHeadersWidth = 51;
            this.dataGridViewDisplay.RowTemplate.Height = 24;
            this.dataGridViewDisplay.Size = new System.Drawing.Size(737, 229);
            this.dataGridViewDisplay.TabIndex = 2;
            this.dataGridViewDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDisplay_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(290, 433);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 46);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(26, 22);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // lblTransactionType
            // 
            this.lblTransactionType.AutoSize = true;
            this.lblTransactionType.Location = new System.Drawing.Point(26, 66);
            this.lblTransactionType.Name = "lblTransactionType";
            this.lblTransactionType.Size = new System.Drawing.Size(90, 13);
            this.lblTransactionType.TabIndex = 6;
            this.lblTransactionType.Text = "Transaction Type";
            // 
            // lblDocumentNo
            // 
            this.lblDocumentNo.AutoSize = true;
            this.lblDocumentNo.Location = new System.Drawing.Point(26, 115);
            this.lblDocumentNo.Name = "lblDocumentNo";
            this.lblDocumentNo.Size = new System.Drawing.Size(73, 13);
            this.lblDocumentNo.TabIndex = 7;
            this.lblDocumentNo.Text = "Document No";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(489, 15);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(23, 13);
            this.lblQty.TabIndex = 8;
            this.lblQty.Text = "Qty";
            // 
            // lblUnitCost
            // 
            this.lblUnitCost.AutoSize = true;
            this.lblUnitCost.Location = new System.Drawing.Point(483, 59);
            this.lblUnitCost.Name = "lblUnitCost";
            this.lblUnitCost.Size = new System.Drawing.Size(50, 13);
            this.lblUnitCost.TabIndex = 9;
            this.lblUnitCost.Text = "Unit Cost";
            // 
            // lblUnitSell
            // 
            this.lblUnitSell.AutoSize = true;
            this.lblUnitSell.Location = new System.Drawing.Point(483, 107);
            this.lblUnitSell.Name = "lblUnitSell";
            this.lblUnitSell.Size = new System.Drawing.Size(46, 13);
            this.lblUnitSell.TabIndex = 10;
            this.lblUnitSell.Text = "Unit Sell";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(138, 15);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(215, 20);
            this.dtpDate.TabIndex = 11;
            // 
            // txbDocumentNo
            // 
            this.txbDocumentNo.Location = new System.Drawing.Point(138, 112);
            this.txbDocumentNo.Name = "txbDocumentNo";
            this.txbDocumentNo.Size = new System.Drawing.Size(215, 20);
            this.txbDocumentNo.TabIndex = 13;
            // 
            // txbQty
            // 
            this.txbQty.Location = new System.Drawing.Point(545, 16);
            this.txbQty.Name = "txbQty";
            this.txbQty.Size = new System.Drawing.Size(215, 20);
            this.txbQty.TabIndex = 14;
            // 
            // txbUnitCost
            // 
            this.txbUnitCost.Location = new System.Drawing.Point(545, 56);
            this.txbUnitCost.Name = "txbUnitCost";
            this.txbUnitCost.Size = new System.Drawing.Size(215, 20);
            this.txbUnitCost.TabIndex = 15;
            // 
            // txbUnitSell
            // 
            this.txbUnitSell.Location = new System.Drawing.Point(545, 102);
            this.txbUnitSell.Name = "txbUnitSell";
            this.txbUnitSell.Size = new System.Drawing.Size(215, 20);
            this.txbUnitSell.TabIndex = 16;
            // 
            // cmbTransactionType
            // 
            this.cmbTransactionType.FormattingEnabled = true;
            this.cmbTransactionType.Items.AddRange(new object[] {
            "Purchase ",
            "Sale"});
            this.cmbTransactionType.Location = new System.Drawing.Point(138, 66);
            this.cmbTransactionType.Name = "cmbTransactionType";
            this.cmbTransactionType.Size = new System.Drawing.Size(215, 21);
            this.cmbTransactionType.TabIndex = 17;
            this.cmbTransactionType.SelectedIndexChanged += new System.EventHandler(this.cmbTransactionType_SelectedIndexChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(359, 112);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 18;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(620, 165);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 20);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(23, 165);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(593, 20);
            this.txbSearch.TabIndex = 19;
            // 
            // frmStockTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(771, 522);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.cmbTransactionType);
            this.Controls.Add(this.txbUnitSell);
            this.Controls.Add(this.txbUnitCost);
            this.Controls.Add(this.txbQty);
            this.Controls.Add(this.txbDocumentNo);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblUnitSell);
            this.Controls.Add(this.lblUnitCost);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblDocumentNo);
            this.Controls.Add(this.lblTransactionType);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridViewDisplay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmStockTransactions";
            this.Text = "frmStockTransactions";
            this.Load += new System.EventHandler(this.frmStockTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridViewDisplay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTransactionType;
        private System.Windows.Forms.Label lblDocumentNo;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblUnitCost;
        private System.Windows.Forms.Label lblUnitSell;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txbDocumentNo;
        private System.Windows.Forms.TextBox txbQty;
        private System.Windows.Forms.TextBox txbUnitCost;
        private System.Windows.Forms.TextBox txbUnitSell;
        private System.Windows.Forms.ComboBox cmbTransactionType;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbSearch;
    }
}