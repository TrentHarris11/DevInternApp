﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevInternApp
{
    public partial class frmDebtorsEnquiry : Form
    {
        public frmDebtorsEnquiry()
        {
            InitializeComponent();
        }

        private void PopulateDebtorsDataGridView()
        {
            string connectionString = "data source=user\\SQLEXPRESS;initial catalog=xact1;trusted_connection=true"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string selectQuery = "SELECT AccountCode, Address1, Address2, Address3, Balance, SalesYearToDate, CostYearToDate FROM DebtorsMaster";

                SqlCommand command = new SqlCommand(selectQuery, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Create a DataTable to hold the data
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader); // Load data directly from the SqlDataReader

                    // Bind the DataTable to the DataGridView
                    dataGridViewDisplay.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        // Method to search for specific debtors
        private void SearchDebtors(string searchTerm)
        {
            string connectionString = "data source=user\\SQLEXPRESS;initial catalog=xact1;trusted_connection=true"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string selectQuery = "SELECT AccountCode, Address1, Address2, Address3, Balance, SalesYearToDate, CostYearToDate FROM DebtorsMaster WHERE AccountCode LIKE @SearchTerm";

                SqlCommand command = new SqlCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Create a DataTable to hold the search results
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader); // Load search results directly from the SqlDataReader

                    // Bind the search results to the DataGridView
                    dataGridViewDisplay.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void frmDebtorsEnquiry_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(btnViewTransaction, "Create or View The Transaction History of Selected Debtor");

            ToolTip toolTip2 = new ToolTip();
            toolTip1.SetToolTip(txbSearch, "Search For A Debtor via Account Code");
        }

        // Event handler for Search Button click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txbSearch.Text;
            SearchDebtors(searchTerm);
        }

        private void btnViewTransaction_Click(object sender, EventArgs e)
        {
            // Check if a row is actually selected
            if (dataGridViewDisplay.CurrentRow == null)
            {
                MessageBox.Show("Please select a debtor to view transactions.");
                return;
            }

            // Get the selected debtor's account code from the Debtors DataGridView
            int selectedAccountCode = Convert.ToInt32(dataGridViewDisplay.CurrentRow.Cells["AccountCode"].Value);

            // Open the frmTransactionHistory form and pass the selected account code
            frmTransactionHistory transactionHistoryForm = new frmTransactionHistory(selectedAccountCode);
            transactionHistoryForm.Show(); // Show the form as a modal dialog
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateDebtorsDataGridView();
            dataGridViewDisplay.Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void dataGridViewDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdateDebtors_Click(object sender, EventArgs e)
        {
            if (dataGridViewDisplay.CurrentRow != null)
            {
                // Retrieve data from the selected row
                var selectedRow = dataGridViewDisplay.CurrentRow;
                int accountCode = Convert.ToInt32(selectedRow.Cells["AccountCode"].Value);
                string address1 = selectedRow.Cells["Address1"].Value.ToString();
                string address2 = selectedRow.Cells["Address2"].Value.ToString();
                string address3 = selectedRow.Cells["Address3"].Value.ToString();
                decimal balance = Convert.ToDecimal(selectedRow.Cells["Balance"].Value);
                decimal salesYearToDate = Convert.ToDecimal(selectedRow.Cells["SalesYearToDate"].Value);
                decimal costYearToDate = Convert.ToDecimal(selectedRow.Cells["CostYearToDate"].Value);

                // Open frmDebtorsMaster with the data
                frmDebtorsMaster masterForm = new frmDebtorsMaster();
                masterForm.PopulateFields(accountCode, address1, address2, address3, balance, salesYearToDate, costYearToDate);
                masterForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a debtor to update.");
            }
        }
    }
}
