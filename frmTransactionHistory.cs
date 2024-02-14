using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevInternApp
{
    public partial class frmTransactionHistory : Form
    {
        private readonly int _accountCode; // Field to store account code

        public frmTransactionHistory(int accountCode)
        {
            InitializeComponent();
            _accountCode = accountCode;
            txbAccountCode.Text = _accountCode.ToString();
            txbAccountCode.ReadOnly = true;
            PopulateTransactionHistoryDataGridView();
        }

       

        private void PopulateTransactionHistoryDataGridView()
        {
            DataTable transactionData = GetTransactionData(_accountCode);
            dataGridViewDisplay.DataSource = transactionData;
        }

        private DataTable GetTransactionData(int accountCode)
        {
            DataTable transactionData = new DataTable();
            string connectionString = "data source=user\\SQLEXPRESS;initial catalog=xact1;trusted_connection=true";

            string selectQuery = @"
        SELECT AccountCode, Date, TransactionType, DocumentNo, GrossTransactionValue, VatValue 
        FROM DebtorsTransaction 
        WHERE AccountCode = @AccountCode";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@AccountCode", accountCode);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    transactionData.Load(reader);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving transaction data: " + ex.Message);
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            // Use the private readonly field _accountCode
            int accountCode = this._accountCode;
            DateTime date = dtpDate.Value;
            string transactionType = cmbTransactionType.SelectedItem.ToString();
            string documentNo = txbDocumentNo.Text;
            decimal grossTransactionValue = decimal.Parse(txbGrossTransaction.Text);
            decimal vatValue = decimal.Parse(txbVat.Text);

            string connectionString = @"data source=user\SQLEXPRESS;initial catalog=xact1;trusted_connection=true";
            string insertQuery = @"
INSERT INTO DebtorsTransaction (AccountCode, Date, TransactionType, DocumentNo, GrossTransactionValue, VatValue)
VALUES (@AccountCode, @Date, @TransactionType, @DocumentNo, @GrossTransactionValue, @VatValue)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@AccountCode", accountCode);
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@TransactionType", transactionType);
                command.Parameters.AddWithValue("@DocumentNo", documentNo);
                command.Parameters.AddWithValue("@GrossTransactionValue", grossTransactionValue);
                command.Parameters.AddWithValue("@VatValue", vatValue);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Transaction added successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            // Refresh the DataGridView to show the new transaction
            PopulateTransactionHistoryDataGridView();
        }

        private void PopulateDataGridView(int accountCode)
        {
            string connectionString = @"data source=user\SQLEXPRESS;initial catalog=xact1;trusted_connection=true";
            string selectQuery = @"
        SELECT * FROM DebtorsTransaction
        WHERE AccountCode = @AccountCode";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@AccountCode", accountCode);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    dataGridViewDisplay.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while fetching transaction data: " + ex.Message);
                }
            }
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            // Check if there is any selected row first
            if (dataGridViewDisplay.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a transaction to add an invoice.");
                return; // Exit the method if no row is selected
            }

            // Now we can safely assume that there is at least one selected row
            var selectedRow = dataGridViewDisplay.SelectedRows[0];

            // Use _accountCode directly since it's not part of the DataGridView
            int accountCode = _accountCode;

            string documentNo = selectedRow.Cells["DocumentNo"].Value.ToString();
            DateTime date = (DateTime)selectedRow.Cells["Date"].Value;
            decimal totalSellExclVat = (decimal)selectedRow.Cells["GrossTransactionValue"].Value;
            decimal vat = (decimal)selectedRow.Cells["VatValue"].Value;

            // Open frmInvoicing with the selected data
            frmInvoicing invoicingForm = new frmInvoicing(accountCode, documentNo, date, totalSellExclVat, vat);
            invoicingForm.Show(); 
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txbGrossTransaction.Text, out decimal grossTransaction))
            {
                decimal vat = grossTransaction * 0.15m;

                // Populate the Vat textbox with the calculated value, formatted as currency without the symbol
                txbVat.Text = vat.ToString("C", CultureInfo.CreateSpecificCulture("en-ZA")).Substring(1).Trim();
            }
            else
            {
                MessageBox.Show("Please enter a valid amount in Gross Transaction.");
            }
        }
    }
}
