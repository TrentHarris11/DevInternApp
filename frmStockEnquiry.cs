using System;
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
    public partial class frmStockEnquiry : Form
    {
        public frmStockEnquiry()
        {
            InitializeComponent();
        }

        private void PopulateStockDataGridView()
        {
            string connectionString = "data source=user\\SQLEXPRESS;initial catalog=xact1;trusted_connection=true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string selectQuery = "SELECT StockCode, StockDescription, Cost, SellingPrice, TotalPurchasesExclVat, TotalSalesExclVat, QtyPurchased, QtySold, StockOnHand FROM StockMaster";

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

        // Method to search for specific stocks
        private void SearchStocks(string searchTerm)
        {
            string connectionString = "data source=user\\SQLEXPRESS;initial catalog=xact1;trusted_connection=true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string selectQuery = "SELECT StockCode, StockDescription, Cost, SellingPrice, TotalPurchasesExclVat, TotalSalesExclVat, QtyPurchased, QtySold, StockOnHand FROM StockMaster WHERE StockCode LIKE @SearchTerm";

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

        private void frmStockEnquiry_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txbSearch.Text;
            SearchStocks(searchTerm);
        }

        private void btnViewTransaction_Click(object sender, EventArgs e)
        {
            if (dataGridViewDisplay.CurrentRow != null)
            {
                string selectedStockCode = dataGridViewDisplay.CurrentRow.Cells["StockCode"].Value.ToString();
                decimal unitCost = Convert.ToDecimal(dataGridViewDisplay.CurrentRow.Cells["Cost"].Value);
                decimal unitSell = Convert.ToDecimal(dataGridViewDisplay.CurrentRow.Cells["SellingPrice"].Value);

                // Use the new constructor that accepts all three parameters
                frmStockTransactions transactionsForm = new frmStockTransactions(selectedStockCode, unitCost, unitSell);
                transactionsForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a stock item to view transactions.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateStockDataGridView();
            dataGridViewDisplay.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}