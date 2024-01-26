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

        // Method to populate the Debtors DataGridView with data from the database
        // Method to populate the Debtors DataGridView with data from the database
        private void PopulateDebtorsDataGridView()
        {
            string connectionString = "data source=user\\SQLEXPRESS;initial catalog=xact1;trusted_connection=true"; // Replace with your actual connection string

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
            string connectionString = "data source=user\\SQLEXPRESS;initial catalog=xact1;trusted_connection=true"; // Replace with your actual connection string

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

        }

        // Event handler for Search Button click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txbSearch.Text;
            SearchDebtors(searchTerm);
        }

        private void btnViewTransaction_Click(object sender, EventArgs e)
        {
            // Get the selected debtor's account code from the Debtors DataGridView
            string selectedAccountCode = dataGridViewDisplay.CurrentRow.Cells["AccountCode"].Value.ToString();

            // Open the frmTransactionHistory form and pass the selected account code
            frmTransactionHistory transactionHistoryForm = new frmTransactionHistory(selectedAccountCode);
            transactionHistoryForm.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateDebtorsDataGridView();
            dataGridViewDisplay.Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form (frmDebtorsEnquiry)
            //frmMain mainForm = new frmMain();
            //mainForm.Show(); // Show the main form (frmMain)
        }
    }
}