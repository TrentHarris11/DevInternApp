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
    public partial class frmStockTransactions : Form
    {
        private string selectedStockCode;
        public frmStockTransactions(string stockCode)
        {
            InitializeComponent();
            selectedStockCode = stockCode;
            PopulateStockTransactionsDataGridView();
        }

        private void PopulateStockTransactionsDataGridView()
        {
            // Populate the DataGridView with transaction details based on the selected account code
            DataTable stockData = GetStockData(selectedStockCode); // Method to retrieve transaction data

            // Bind the transaction data to the DataGridView
            dataGridViewDisplay.DataSource = stockData;
        }

        private DataTable GetStockData(string stockCode)
        {
            DataTable stockData = new DataTable();

            
            string connectionString = "data source=user\\SQLEXPRESS;initial catalog=xact1;trusted_connection=true";

            // SQL query to retrieve transaction details based on the account code
            string selectQuery = "SELECT StockCode, Date, TransactionType, DocumentNo, Qty, UnitCost, UnitSell FROM StockTransaction WHERE StockCode = @StockCode";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@StockCode", stockCode);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        stockData.Load(reader); // Load data directly from the SqlDataReader
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception, e.g., display an error message
                        MessageBox.Show("An error occurred while retrieving stock data: " + ex.Message);
                    }
                }
            }

            return stockData;
        }



        private void frmStockTransactions_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
