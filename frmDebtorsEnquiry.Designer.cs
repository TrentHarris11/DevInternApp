namespace DevInternApp
{
    partial class frmDebtorsEnquiry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDebtorsEnquiry));
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridViewDisplay = new System.Windows.Forms.DataGridView();
            this.btnViewTransaction = new System.Windows.Forms.Button();
            this.btnUpdateDebtors = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(9, 10);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(512, 20);
            this.txbSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(524, 10);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 19);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(159, 202);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(115, 41);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Load";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(463, 202);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 41);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridViewDisplay
            // 
            this.dataGridViewDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplay.Location = new System.Drawing.Point(9, 40);
            this.dataGridViewDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDisplay.Name = "dataGridViewDisplay";
            this.dataGridViewDisplay.RowHeadersWidth = 51;
            this.dataGridViewDisplay.RowTemplate.Height = 24;
            this.dataGridViewDisplay.Size = new System.Drawing.Size(589, 122);
            this.dataGridViewDisplay.TabIndex = 4;
            this.dataGridViewDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDisplay_CellContentClick);
            // 
            // btnViewTransaction
            // 
            this.btnViewTransaction.Location = new System.Drawing.Point(11, 202);
            this.btnViewTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewTransaction.Name = "btnViewTransaction";
            this.btnViewTransaction.Size = new System.Drawing.Size(115, 41);
            this.btnViewTransaction.TabIndex = 5;
            this.btnViewTransaction.Text = "Transaction History";
            this.btnViewTransaction.UseVisualStyleBackColor = true;
            this.btnViewTransaction.Click += new System.EventHandler(this.btnViewTransaction_Click);
            // 
            // btnUpdateDebtors
            // 
            this.btnUpdateDebtors.Location = new System.Drawing.Point(310, 202);
            this.btnUpdateDebtors.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateDebtors.Name = "btnUpdateDebtors";
            this.btnUpdateDebtors.Size = new System.Drawing.Size(115, 41);
            this.btnUpdateDebtors.TabIndex = 6;
            this.btnUpdateDebtors.Text = "Update Debtor";
            this.btnUpdateDebtors.UseVisualStyleBackColor = true;
            this.btnUpdateDebtors.Click += new System.EventHandler(this.btnUpdateDebtors_Click);
            // 
            // frmDebtorsEnquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnUpdateDebtors);
            this.Controls.Add(this.btnViewTransaction);
            this.Controls.Add(this.dataGridViewDisplay);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbSearch);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDebtorsEnquiry";
            this.Text = "frmDebtorsEnquiry";
            this.Load += new System.EventHandler(this.frmDebtorsEnquiry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridViewDisplay;
        private System.Windows.Forms.Button btnViewTransaction;
        private System.Windows.Forms.Button btnUpdateDebtors;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}