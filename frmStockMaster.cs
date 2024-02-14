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
    public partial class frmStockMaster : Form
    {
        public frmStockMaster()
        {
            InitializeComponent();
        }

        // Method to populate the form with stock data
        private void PopulateStockData(string stockCode)
        {
            string connectionString = "data source=user\\SQLEXPRESS;initial catalog=xact1;trusted_connection=true"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string selectQuery = "SELECT * FROM StockMaster WHERE StockCode = @StockCode";

                SqlCommand command = new SqlCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@StockCode", stockCode);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Populate the input fields with the retrieved data
                        txbStockCode.Text = reader["StockCode"].ToString();
                        txbStockDescription.Text = reader["Description"].ToString();
                        nudCost.Value = Convert.ToDecimal(reader["Cost"]);
                        nudSellingP.Value = Convert.ToDecimal(reader["SellingPrice"]);
                        nudPurchasesExclVat.Value = Convert.ToDecimal(reader["TotalPurchasesExclVAT"]);
                        nudSalesExclVat.Value = Convert.ToDecimal(reader["TotalSalesExclVAT"]);
                        nudQtyPurchased.Value = Convert.ToInt32(reader["QtyPurchased"]);
                        nudQtySold.Value = Convert.ToInt32(reader["QtySold"]);
                        nudStock.Value = Convert.ToInt32(reader["StockOnHand"]);
                    }
                    else
                    {
                        MessageBox.Show("Stock item not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Collect data from input fields
            string stockCode = txbStockCode.Text;
            string description = txbStockDescription.Text;
            decimal cost = nudCost.Value;
            decimal sellingPrice = nudSellingP.Value; // Correct control for selling price
            decimal totalPurchasesExclVAT = cost * Convert.ToInt32(nudQtyPurchased.Value); // Cost multiplied by quantity purchased
            decimal totalSalesExclVAT = 0; // Since no sales have been made yet
            int qtyPurchased = Convert.ToInt32(nudQtyPurchased.Value);
            int qtySold = 0; // Since no sales have been made yet
            int stockOnHand = qtyPurchased - qtySold; // Initially, stock on hand will be equal to quantity purchased

            // Insert a new record into the database
            string connectionString = "data source=user\\SQLEXPRESS;initial catalog=xact1;trusted_connection=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string insertQuery = "INSERT INTO StockMaster (StockCode, StockDescription, Cost, SellingPrice, TotalPurchasesExclVAT, TotalSalesExclVAT, QtyPurchased, QtySold, StockOnHand) " +
                            "VALUES (@StockCode, @StockDescription, @Cost, @SellingPrice, @TotalPurchasesExclVAT, @TotalSalesExclVAT, @QtyPurchased, @QtySold, @StockOnHand)";

                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@StockCode", stockCode);
                command.Parameters.AddWithValue("@StockDescription", description); 
                command.Parameters.AddWithValue("@Cost", cost);
                command.Parameters.AddWithValue("@SellingPrice", sellingPrice);
                command.Parameters.AddWithValue("@TotalPurchasesExclVAT", totalPurchasesExclVAT);
                command.Parameters.AddWithValue("@TotalSalesExclVAT", totalSalesExclVAT);
                command.Parameters.AddWithValue("@QtyPurchased", qtyPurchased);
                command.Parameters.AddWithValue("@QtySold", qtySold);
                command.Parameters.AddWithValue("@StockOnHand", stockOnHand);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Stock record added successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add stock record. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void frmStockMaster_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Collect data from input fields
            string stockCode = txbStockCode.Text;
            string description = txbStockDescription.Text;
            decimal cost = nudCost.Value;
            decimal sellingPrice = nudSellingP.Value;
            decimal totalPurchasesExclVAT = nudPurchasesExclVat.Value;
            decimal totalSalesExclVAT = nudSalesExclVat.Value;
            int qtyPurchased = Convert.ToInt32(nudQtyPurchased.Value);
            int qtySold = Convert.ToInt32(nudQtySold.Value);
            int stockOnHand = Convert.ToInt32(nudStock.Value);

            // Update the corresponding record in the database
            string connectionString = "data source=user\\SQLEXPRESS;initial catalog=xact1;trusted_connection=true"; 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string updateQuery = "UPDATE StockMaster " +
                                     "SET StockDescription = @StockDescription, Cost = @Cost, SellingPrice = @SellingPrice, " +
                                     "TotalPurchasesExclVAT = @TotalPurchasesExclVAT, TotalSalesExclVAT = @TotalSalesExclVAT, " +
                                     "QtyPurchased = @QtyPurchased, QtySold = @QtySold, StockOnHand = @StockOnHand " +
                                     "WHERE StockCode = @StockCode";

                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@StockCode", stockCode);
                command.Parameters.AddWithValue("@StockDescription", description);
                command.Parameters.AddWithValue("@Cost", cost);
                command.Parameters.AddWithValue("@SellingPrice", sellingPrice);
                command.Parameters.AddWithValue("@TotalPurchasesExclVAT", totalPurchasesExclVAT);
                command.Parameters.AddWithValue("@TotalSalesExclVAT", totalSalesExclVAT);
                command.Parameters.AddWithValue("@QtyPurchased", qtyPurchased);
                command.Parameters.AddWithValue("@QtySold", qtySold);
                command.Parameters.AddWithValue("@StockOnHand", stockOnHand);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Stock record updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update stock record. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Confirm with the user if they want to proceed with the deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this stock record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Delete the corresponding record from the database
                string stockCode = txbStockCode.Text; //Stock code is used to identify the stock record

                string connectionString = "data source=user\\SQLEXPRESS;initial catalog=xact1;trusted_connection=true"; 
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string deleteQuery = "DELETE FROM StockMaster WHERE StockCode = @StockCode";

                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@StockCode", stockCode);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Stock record deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete stock record. Please try again.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void btnMainScreen_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnStockMaster_Click(object sender, EventArgs e)
        {
            frmStockEnquiry stockEnquiry = new frmStockEnquiry();
            stockEnquiry.Show();
            this.Close();
        }
    }
}
