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
    public partial class frmTransactionHistory : Form
    {
        private string selectedAccountCode;

        public frmTransactionHistory(string accountCode)
        {
            InitializeComponent();
            selectedAccountCode = accountCode;
            PopulateTransactionHistoryDataGridView();
        }

        private void PopulateTransactionHistoryDataGridView()
        {
            
            DataTable transactionData = GetTransactionData(selectedAccountCode); // Method to retrieve transaction data

            // Bind the transaction data to the DataGridView
            dataGridViewDisplay.DataSource = transactionData;
        }

        private DataTable GetTransactionData(string accountCode)
        {
            DataTable transactionData = new DataTable();

            
            string connectionString = "data source=user\\SQLEXPRESS;initial catalog=xact1;trusted_connection=true";

            // SQL query to retrieve transaction details based on the account code
            string selectQuery = "SELECT Date, TransactionType, DocumentNo, GrossTransactionValue, VatValue FROM DebtorsTransaction WHERE AccountCode = @AccountCode";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@AccountCode", accountCode);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        transactionData.Load(reader); // Load data directly from the SqlDataReader
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception, e.g., display an error message
                        MessageBox.Show("An error occurred while retrieving transaction data: " + ex.Message);
                    }
                }
            }

            return transactionData;
        }


        private void frmTransactionHistory_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the frmTransactionHistory form
        }

        private void dataGridViewDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
