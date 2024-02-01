namespace DevInternApp
{
    partial class frmInvoiceHeader
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
            this.lblInvoiceHeader = new System.Windows.Forms.Label();
            this.lblInvoiceDetails = new System.Windows.Forms.Label();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.lblAccountCode = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalSellExclVat = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInvoiceHeader
            // 
            this.lblInvoiceHeader.AutoSize = true;
            this.lblInvoiceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceHeader.Location = new System.Drawing.Point(354, 9);
            this.lblInvoiceHeader.Name = "lblInvoiceHeader";
            this.lblInvoiceHeader.Size = new System.Drawing.Size(189, 29);
            this.lblInvoiceHeader.TabIndex = 0;
            this.lblInvoiceHeader.Text = "Invoice Header";
            // 
            // lblInvoiceDetails
            // 
            this.lblInvoiceDetails.AutoSize = true;
            this.lblInvoiceDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceDetails.Location = new System.Drawing.Point(354, 262);
            this.lblInvoiceDetails.Name = "lblInvoiceDetails";
            this.lblInvoiceDetails.Size = new System.Drawing.Size(184, 29);
            this.lblInvoiceDetails.TabIndex = 1;
            this.lblInvoiceDetails.Text = "Invoice Details";
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNo.Location = new System.Drawing.Point(153, 70);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(87, 20);
            this.lblInvoiceNo.TabIndex = 2;
            this.lblInvoiceNo.Text = "Invoice No";
            // 
            // lblAccountCode
            // 
            this.lblAccountCode.AutoSize = true;
            this.lblAccountCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountCode.Location = new System.Drawing.Point(153, 120);
            this.lblAccountCode.Name = "lblAccountCode";
            this.lblAccountCode.Size = new System.Drawing.Size(114, 20);
            this.lblAccountCode.TabIndex = 3;
            this.lblAccountCode.Text = "Account Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date";
            // 
            // lblTotalSellExclVat
            // 
            this.lblTotalSellExclVat.AutoSize = true;
            this.lblTotalSellExclVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSellExclVat.Location = new System.Drawing.Point(540, 70);
            this.lblTotalSellExclVat.Name = "lblTotalSellExclVat";
            this.lblTotalSellExclVat.Size = new System.Drawing.Size(215, 20);
            this.lblTotalSellExclVat.TabIndex = 5;
            this.lblTotalSellExclVat.Text = "Total Sell Amount Excl VAT";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(540, 120);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(86, 20);
            this.lblTotalCost.TabIndex = 6;
            this.lblTotalCost.Text = "Total Cost";
            // 
            // frmInvoiceHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 408);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblTotalSellExclVat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAccountCode);
            this.Controls.Add(this.lblInvoiceNo);
            this.Controls.Add(this.lblInvoiceDetails);
            this.Controls.Add(this.lblInvoiceHeader);
            this.Name = "frmInvoiceHeader";
            this.Text = "frmInvoiceHeader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInvoiceHeader;
        private System.Windows.Forms.Label lblInvoiceDetails;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Label lblAccountCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalSellExclVat;
        private System.Windows.Forms.Label lblTotalCost;
    }
}