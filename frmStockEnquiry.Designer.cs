namespace DevInternApp
{
    partial class frmStockEnquiry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockEnquiry));
            this.btnViewTransaction = new System.Windows.Forms.Button();
            this.dataGridViewDisplay = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewTransaction
            // 
            this.btnViewTransaction.Location = new System.Drawing.Point(80, 188);
            this.btnViewTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewTransaction.Name = "btnViewTransaction";
            this.btnViewTransaction.Size = new System.Drawing.Size(116, 41);
            this.btnViewTransaction.TabIndex = 11;
            this.btnViewTransaction.Text = "View Transaction";
            this.btnViewTransaction.UseVisualStyleBackColor = true;
            this.btnViewTransaction.Click += new System.EventHandler(this.btnViewTransaction_Click);
            // 
            // dataGridViewDisplay
            // 
            this.dataGridViewDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplay.Location = new System.Drawing.Point(9, 48);
            this.dataGridViewDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDisplay.Name = "dataGridViewDisplay";
            this.dataGridViewDisplay.RowHeadersWidth = 51;
            this.dataGridViewDisplay.RowTemplate.Height = 24;
            this.dataGridViewDisplay.Size = new System.Drawing.Size(586, 122);
            this.dataGridViewDisplay.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(405, 188);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 41);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(241, 188);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(116, 41);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Load";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(524, 10);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 19);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(9, 10);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(512, 20);
            this.txbSearch.TabIndex = 6;
            // 
            // frmStockEnquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(606, 366);
            this.Controls.Add(this.btnViewTransaction);
            this.Controls.Add(this.dataGridViewDisplay);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbSearch);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmStockEnquiry";
            this.Text = "frmStockEnquiry";
            this.Load += new System.EventHandler(this.frmStockEnquiry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewTransaction;
        private System.Windows.Forms.DataGridView dataGridViewDisplay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}