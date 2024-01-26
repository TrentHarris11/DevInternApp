namespace DevInternApp
{
    partial class frmDebtorsMaster
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
            this.txbAccountCode = new System.Windows.Forms.TextBox();
            this.nudBalance = new System.Windows.Forms.NumericUpDown();
            this.nudCostYear = new System.Windows.Forms.NumericUpDown();
            this.nudSalesYear = new System.Windows.Forms.NumericUpDown();
            this.txbAddress1 = new System.Windows.Forms.TextBox();
            this.txbAddress2 = new System.Windows.Forms.TextBox();
            this.txbAddress3 = new System.Windows.Forms.TextBox();
            this.lblAccountCode = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblSalesYearToDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMainScreen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalesYear)).BeginInit();
            this.SuspendLayout();
            // 
            // txbAccountCode
            // 
            this.txbAccountCode.Location = new System.Drawing.Point(155, 41);
            this.txbAccountCode.Name = "txbAccountCode";
            this.txbAccountCode.Size = new System.Drawing.Size(188, 28);
            this.txbAccountCode.TabIndex = 0;
            // 
            // nudBalance
            // 
            this.nudBalance.Location = new System.Drawing.Point(531, 45);
            this.nudBalance.Name = "nudBalance";
            this.nudBalance.Size = new System.Drawing.Size(188, 22);
            this.nudBalance.TabIndex = 1;
            // 
            // nudCostYear
            // 
            this.nudCostYear.Location = new System.Drawing.Point(531, 179);
            this.nudCostYear.Name = "nudCostYear";
            this.nudCostYear.Size = new System.Drawing.Size(188, 22);
            this.nudCostYear.TabIndex = 2;
            // 
            // nudSalesYear
            // 
            this.nudSalesYear.Location = new System.Drawing.Point(531, 104);
            this.nudSalesYear.Name = "nudSalesYear";
            this.nudSalesYear.Size = new System.Drawing.Size(188, 22);
            this.nudSalesYear.TabIndex = 3;
            // 
            // txbAddress1
            // 
            this.txbAddress1.Location = new System.Drawing.Point(155, 103);
            this.txbAddress1.Name = "txbAddress1";
            this.txbAddress1.Size = new System.Drawing.Size(188, 28);
            this.txbAddress1.TabIndex = 4;
            // 
            // txbAddress2
            // 
            this.txbAddress2.Location = new System.Drawing.Point(155, 173);
            this.txbAddress2.Name = "txbAddress2";
            this.txbAddress2.Size = new System.Drawing.Size(188, 28);
            this.txbAddress2.TabIndex = 5;
            // 
            // txbAddress3
            // 
            this.txbAddress3.Location = new System.Drawing.Point(155, 232);
            this.txbAddress3.Name = "txbAddress3";
            this.txbAddress3.Size = new System.Drawing.Size(188, 28);
            this.txbAddress3.TabIndex = 6;
            // 
            // lblAccountCode
            // 
            this.lblAccountCode.AutoSize = true;
            this.lblAccountCode.Location = new System.Drawing.Point(12, 41);
            this.lblAccountCode.Name = "lblAccountCode";
            this.lblAccountCode.Size = new System.Drawing.Size(114, 20);
            this.lblAccountCode.TabIndex = 7;
            this.lblAccountCode.Text = "Account Code";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 109);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(73, 20);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(12, 179);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(29, 16);
            this.lblCity.TabIndex = 9;
            this.lblCity.Text = "City";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(12, 238);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(101, 20);
            this.lblPostalCode.TabIndex = 10;
            this.lblPostalCode.Text = "Postal Code";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(377, 47);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(71, 20);
            this.lblBalance.TabIndex = 11;
            this.lblBalance.Text = "Balance";
            // 
            // lblSalesYearToDate
            // 
            this.lblSalesYearToDate.AutoSize = true;
            this.lblSalesYearToDate.Location = new System.Drawing.Point(377, 109);
            this.lblSalesYearToDate.Name = "lblSalesYearToDate";
            this.lblSalesYearToDate.Size = new System.Drawing.Size(129, 16);
            this.lblSalesYearToDate.TabIndex = 12;
            this.lblSalesYearToDate.Text = "Sales Year To Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cost Year To Date";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(60, 341);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 47);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(237, 341);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 47);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(421, 341);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 47);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMainScreen
            // 
            this.btnMainScreen.Location = new System.Drawing.Point(599, 341);
            this.btnMainScreen.Name = "btnMainScreen";
            this.btnMainScreen.Size = new System.Drawing.Size(130, 47);
            this.btnMainScreen.TabIndex = 17;
            this.btnMainScreen.Text = "Main Screen";
            this.btnMainScreen.UseVisualStyleBackColor = true;
            this.btnMainScreen.Click += new System.EventHandler(this.btnMainScreen_Click);
            // 
            // frmDebtorsMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMainScreen);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSalesYearToDate);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblPostalCode);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblAccountCode);
            this.Controls.Add(this.txbAddress3);
            this.Controls.Add(this.txbAddress2);
            this.Controls.Add(this.txbAddress1);
            this.Controls.Add(this.nudSalesYear);
            this.Controls.Add(this.nudCostYear);
            this.Controls.Add(this.nudBalance);
            this.Controls.Add(this.txbAccountCode);
            this.Name = "frmDebtorsMaster";
            this.Text = "frmDebtorsMaster";
            this.Load += new System.EventHandler(this.frmDebtorsMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalesYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbAccountCode;
        private System.Windows.Forms.NumericUpDown nudBalance;
        private System.Windows.Forms.NumericUpDown nudCostYear;
        private System.Windows.Forms.NumericUpDown nudSalesYear;
        private System.Windows.Forms.TextBox txbAddress1;
        private System.Windows.Forms.TextBox txbAddress2;
        private System.Windows.Forms.TextBox txbAddress3;
        private System.Windows.Forms.Label lblAccountCode;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblSalesYearToDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMainScreen;
    }
}