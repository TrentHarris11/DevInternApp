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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDebtor = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDebtors
            // 
            this.cmbDebtors.FormattingEnabled = true;
            this.cmbDebtors.Location = new System.Drawing.Point(112, 9);
            this.cmbDebtors.Name = "cmbDebtors";
            this.cmbDebtors.Size = new System.Drawing.Size(121, 24);
            this.cmbDebtors.TabIndex = 0;
            this.cmbDebtors.SelectedIndexChanged += new System.EventHandler(this.cmbDebtors_SelectedIndexChanged);
            // 
            // dtpInvoice
            // 
            this.dtpInvoice.Location = new System.Drawing.Point(557, 9);
            this.dtpInvoice.Name = "dtpInvoice";
            this.dtpInvoice.Size = new System.Drawing.Size(231, 22);
            this.dtpInvoice.TabIndex = 1;
            // 
            // dataGridViewDisplay
            // 
            this.dataGridViewDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplay.Location = new System.Drawing.Point(12, 56);
            this.dataGridViewDisplay.Name = "dataGridViewDisplay";
            this.dataGridViewDisplay.RowHeadersWidth = 51;
            this.dataGridViewDisplay.RowTemplate.Height = 24;
            this.dataGridViewDisplay.Size = new System.Drawing.Size(776, 262);
            this.dataGridViewDisplay.TabIndex = 2;
            this.dataGridViewDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDisplay_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 363);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 47);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(216, 363);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 47);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save Invoice";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(437, 363);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(130, 47);
            this.btnPrint.TabIndex = 22;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(659, 363);
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
            this.lblDebtor.Location = new System.Drawing.Point(30, 12);
            this.lblDebtor.Name = "lblDebtor";
            this.lblDebtor.Size = new System.Drawing.Size(48, 16);
            this.lblDebtor.TabIndex = 24;
            this.lblDebtor.Text = "Debtor";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Location = new System.Drawing.Point(451, 12);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(82, 16);
            this.lblInvoiceDate.TabIndex = 25;
            this.lblInvoiceDate.Text = "Invoice Date";
            // 
            // frmInvoicing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInvoiceDate);
            this.Controls.Add(this.lblDebtor);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
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
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDebtor;
        private System.Windows.Forms.Label lblInvoiceDate;
    }
}