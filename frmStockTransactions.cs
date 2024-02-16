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
        private decimal unitCost;
        private decimal unitSell;

        // Combine the parameters into one constructor
        public frmStockTransactions(string stockCode, decimal unitCost, decimal unitSell)
        {
            InitializeComponent();
            selectedStockCode = stockCode;
            this.unitCost = unitCost;
            this.unitSell = unitSell;

            // Now set the text boxes with the values passed in
            txbUnitCost.Text = unitCost.ToString();
            txbUnitSell.Text = unitSell.ToString();

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
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(cmbTransactionType, "Number Used To Link To Debtor Transactions");

            ToolTip toolTip2 = new ToolTip();
            toolTip1.SetToolTip(txbSearch, "Search For Transactions via DocumentNo");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertNewStockTransaction()
        {
            string connectionString = "data source=user\\SQLEXPRESS;initial catalog=xact1;trusted_connection=true";
            string insertQuery = @"INSERT INTO StockTransaction (StockCode, Date, TransactionType, DocumentNo, Qty, UnitCost, UnitSell)
                           VALUES (@StockCode, @Date, @TransactionType, @DocumentNo, @Qty, @UnitCost, @UnitSell);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                // Add parameter values from form controls
                command.Parameters.AddWithValue("@StockCode", selectedStockCode);
                command.Parameters.AddWithValue("@Date", dtpDate.Value);
                command.Parameters.AddWithValue("@TransactionType", cmbTransactionType.Text);
                command.Parameters.AddWithValue("@DocumentNo", txbDocumentNo.Text);
                command.Parameters.AddWithValue("@Qty", Convert.ToInt32(txbQty.Text)); // 
                command.Parameters.AddWithValue("@UnitCost", Convert.ToDecimal(txbUnitCost.Text));
                command.Parameters.AddWithValue("@UnitSell", Convert.ToDecimal(txbUnitSell.Text));

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while inserting a new stock transaction: " + ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string stockCode = selectedStockCode; // The stock code selected from the previous form
            string transactionType = cmbTransactionType.SelectedItem.ToString(); // The transaction type selected from the ComboBox
            int quantity; // The quantity entered by the user
            decimal unitCost; // The unit cost entered by the user for a purchase
            decimal unitSell; // The unit sell amount entered by the user for a sale

            // Convert and validate quantity, unit cost, and unit sell inputs
            if (!int.TryParse(txbQty.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than 0.");
                return;
            }

            if (!decimal.TryParse(txbUnitCost.Text, out unitCost))
            {
                MessageBox.Show("Please enter a valid unit cost.");
                return;
            }

            if (!decimal.TryParse(txbUnitSell.Text, out unitSell))
            {
                MessageBox.Show("Please enter a valid unit sell amount.");
                return;
            }

            InsertNewStockTransaction();
            PopulateStockTransactionsDataGridView();

            // Call the method to update the StockMaster table
            UpdateStockMaster(stockCode, transactionType, quantity, unitCost, unitSell);
        }

        private void UpdateStockMaster(string stockCode, string transactionType, int qty, decimal unitCost, decimal unitSell)
        {
            // Trim the transactionType to remove any leading/trailing whitespaces
            transactionType = transactionType.Trim();

            // Debugging line to check the actual transaction type value
            System.Diagnostics.Debug.WriteLine("Transaction Type: " + transactionType);

            string connectionString = "data source=user\\SQLEXPRESS;initial catalog=xact1;trusted_connection=true";
            string updateQuery = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (transactionType.Equals("Sale", StringComparison.OrdinalIgnoreCase))
                {
                    updateQuery = @"
                UPDATE StockMaster
                SET QtySold = QtySold + @Qty,
                    TotalSalesExclVat = TotalSalesExclVat + (@Qty * @UnitSell),
                    StockOnHand = StockOnHand - @Qty
                WHERE StockCode = @StockCode";
                }
                else if (transactionType.Equals("Purchase", StringComparison.OrdinalIgnoreCase))
                {
                    updateQuery = @"
                UPDATE StockMaster
                SET QtyPurchased = QtyPurchased + @Qty,
                    TotalPurchasesExclVat = TotalPurchasesExclVat + (@Qty * @UnitCost),
                    StockOnHand = StockOnHand + @Qty
                WHERE StockCode = @StockCode";
                }

                // If the query is not set, no valid transaction type was selected
                if (string.IsNullOrEmpty(updateQuery))
                {
                    MessageBox.Show("Invalid transaction type selected.");
                    return;
                }

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@StockCode", stockCode);
                    command.Parameters.AddWithValue("@Qty", qty);
                    command.Parameters.AddWithValue("@UnitCost", unitCost);
                    command.Parameters.AddWithValue("@UnitSell", unitSell);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while updating the stock: " + ex.Message);
                    }
                }
            }
        }

        private void cmbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAttach_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string documentNo = GenerateDocumentNo(selectedStockCode);
            txbDocumentNo.Text = documentNo; // Assume you have a TextBox for Document No
        }

        private string GenerateDocumentNo(string stockCode)
        {
            string stockDescription = GetStockDescription(stockCode);

            // Check the length of the stock description to determine the docPrefix
            string docPrefix;
            if (stockDescription.Length <= 3)
            {
                // If stock description is three letters or less, use the stock description itself
                docPrefix = stockDescription.ToUpper();
            }
            else
            {
                // If stock description is more than four letters, take the first four letters
                docPrefix = stockDescription.Substring(0, 4).ToUpper();
            }

            // Generate a random 4-digit number
            Random random = new Random();
            int randomNumber = random.Next(1000, 10000); // Generates a number between 1000 and 9999

            // Concatenate and return the DocumentNo
            return docPrefix + randomNumber.ToString();
        }

        private string GetStockDescription(string stockCode)
        {
            string connectionString = "data source=user\\SQLEXPRESS;initial catalog=xact1;trusted_connection=true";
            string stockDescription = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT StockDescription FROM StockMaster WHERE StockCode = @StockCode";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StockCode", stockCode);

                try
                {
                    connection.Open();
                    stockDescription = command.ExecuteScalar()?.ToString() ?? "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return stockDescription;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txbSearch.Text;
            SearchStockTransactions(searchTerm);
        }

        private void SearchStockTransactions(string searchTerm)
        {
            string connectionString = "data source=user\\SQLEXPRESS;initial catalog=xact1;trusted_connection=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string selectQuery = "SELECT * FROM StockTransaction WHERE DocumentNo LIKE @SearchTerm";
                SqlCommand command = new SqlCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridViewDisplay.DataSource = dataTable; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}