namespace DevInternApp
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pictureBoxXACT = new System.Windows.Forms.PictureBox();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.btnDebtors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxXACT)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxXACT
            // 
            this.pictureBoxXACT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxXACT.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxXACT.Image")));
            this.pictureBoxXACT.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxXACT.Name = "pictureBoxXACT";
            this.pictureBoxXACT.Size = new System.Drawing.Size(949, 200);
            this.pictureBoxXACT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxXACT.TabIndex = 0;
            this.pictureBoxXACT.TabStop = false;
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.Gold;
            this.btnStock.Location = new System.Drawing.Point(449, 286);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(165, 55);
            this.btnStock.TabIndex = 2;
            this.btnStock.Text = "Stocks";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnInvoices
            // 
            this.btnInvoices.BackColor = System.Drawing.Color.LimeGreen;
            this.btnInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoices.ForeColor = System.Drawing.Color.Gold;
            this.btnInvoices.Location = new System.Drawing.Point(701, 286);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(159, 55);
            this.btnInvoices.TabIndex = 3;
            this.btnInvoices.Text = "Invoices";
            this.btnInvoices.UseVisualStyleBackColor = false;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // btnDebtors
            // 
            this.btnDebtors.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDebtors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebtors.ForeColor = System.Drawing.Color.Gold;
            this.btnDebtors.Location = new System.Drawing.Point(174, 286);
            this.btnDebtors.Name = "btnDebtors";
            this.btnDebtors.Size = new System.Drawing.Size(165, 55);
            this.btnDebtors.TabIndex = 4;
            this.btnDebtors.Text = "Debtors";
            this.btnDebtors.UseVisualStyleBackColor = false;
            this.btnDebtors.Click += new System.EventHandler(this.btnDebtors_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(949, 450);
            this.Controls.Add(this.btnDebtors);
            this.Controls.Add(this.btnInvoices);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.pictureBoxXACT);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxXACT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxXACT;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.Button btnDebtors;
    }
}

