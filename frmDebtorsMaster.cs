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
    public partial class frmDebtorsMaster : Form
    {
        public frmDebtorsMaster()
        {
            InitializeComponent();
        }

        // Method to populate the form with debtor data
        private void PopulateDebtorData(int accountCode)
        {
            string connectionString = "data source=user\\SQLEXPRESS;initial catalog=xact1;trusted_connection=true"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string selectQuery = "SELECT * FROM DebtorsMaster WHERE AccountCode = @AccountCode";

                SqlCommand command = new SqlCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@AccountCode", accountCode);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader(); //Retrieving data

                    if (reader.Read())
                    {
                        // Populate the input fields with the retrieved data
                        txbAccountCode.Text = reader["AccountCode"].ToString();
                        txbAddress1.Text = reader["Address1"].ToString();
                        txbAddress2.Text = reader["Address2"].ToString();
                        txbAddress3.Text = reader["Address3"].ToString();
                        nudBalance.Value = Convert.ToDecimal(reader["Balance"]);
                        nudSalesYear.Value = Convert.ToDecimal(reader["SalesYearToDate"]);
                        nudCostYear.Value = Convert.ToDecimal(reader["CostYearToDate"]);
                    }
                    else
                    {
                       MessageBox.Show("Debtor not found.");
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
            // Collect data from input fields
            int accountCode = Convert.ToInt32(txbAccountCode.Text);
            string address1 = txbAddress1.Text;
            string address2 = txbAddress2.Text;
            string address3 = txbAddress3.Text;
            decimal balance = nudBalance.Value;
            decimal salesYearToDate = nudSalesYear.Value;
            decimal costYearToDate = nudCostYear.Value;

            // Validate input data

            // Insert a new record into the database
            string connectionString = "data source=user\\SQLEXPRESS;initial catalog=xact1;trusted_connection=true"; 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string insertQuery = "INSERT INTO DebtorsMaster (AccountCode, Address1, Address2, Address3, Balance, SalesYearToDate, CostYearToDate) " +
                                     "VALUES (@AccountCode, @Address1, @Address2, @Address3, @Balance, @SalesYearToDate, @CostYearToDate)";

                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@AccountCode", accountCode);
                command.Parameters.AddWithValue("@Address1", address1);
                command.Parameters.AddWithValue("@Address2", address2);
                command.Parameters.AddWithValue("@Address3", address3);
                command.Parameters.AddWithValue("@Balance", balance);
                command.Parameters.AddWithValue("@SalesYearToDate", salesYearToDate);
                command.Parameters.AddWithValue("@CostYearToDate", costYearToDate);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Debtor record added successfully!");
                        // Clear input fields or perform any other necessary actions
                    }
                    else
                    {
                        MessageBox.Show("Failed to add debtor record. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Collect data from input fields
            int accountCode = Convert.ToInt32(txbAccountCode.Text);
            string address1 = txbAddress1.Text;
            string address2 = txbAddress2.Text;
            string address3 = txbAddress3.Text;
            decimal balance = nudBalance.Value;
            decimal salesYearToDate = nudSalesYear.Value;
            decimal costYearToDate = nudCostYear.Value;

            // Validate input data (add your validation logic here)

            // Update the corresponding record in the database
            string connectionString = "data source=user\\SQLEXPRESS;initial catalog=xact1;trusted_connection=true"; 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string updateQuery = "UPDATE DebtorsMaster " +
                                     "SET Address1 = @Address1, Address2 = @Address2, Address3 = @Address3, " +
                                     "Balance = @Balance, SalesYearToDate = @SalesYearToDate, CostYearToDate = @CostYearToDate " +
                                     "WHERE AccountCode = @AccountCode";

                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@AccountCode", accountCode);
                command.Parameters.AddWithValue("@Address1", address1);
                command.Parameters.AddWithValue("@Address2", address2);
                command.Parameters.AddWithValue("@Address3", address3);
                command.Parameters.AddWithValue("@Balance", balance);
                command.Parameters.AddWithValue("@SalesYearToDate", salesYearToDate);
                command.Parameters.AddWithValue("@CostYearToDate", costYearToDate);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Debtor record updated successfully!");
                        // Clear input fields or perform any other necessary actions
                    }
                    else
                    {
                        MessageBox.Show("Failed to update debtor record. Please try again.");
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
            DialogResult result = MessageBox.Show("Are you sure you want to delete this debtor record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Delete the corresponding record from the database
                int accountCode = Convert.ToInt32(txbAccountCode.Text); // Assuming the account code is used to identify the debtor record

                string connectionString = "data source=user\\SQLEXPRESS;initial catalog=xact1;trusted_connection=true"; 
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string deleteQuery = "DELETE FROM DebtorsMaster WHERE AccountCode = @AccountCode";

                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@AccountCode", accountCode);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Debtor record deleted successfully!");
                            // Clear input fields or perform any other necessary actions
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete debtor record. Please try again.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void frmDebtorsMaster_Load(object sender, EventArgs e)
        {
            // Example: Populate the form with data for a specific debtor (e.g., account code 123)
            int accountCode = 123; 

            // Call the PopulateDebtorData method to populate the form with data for the specified debtor
            PopulateDebtorData(accountCode);
        }

        private void btnMainScreen_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form (frmStockEnquiry)
            //frmMain mainForm = new frmMain();
            //mainForm.Show(); // Show the main form (frmMain)
        }

        private void btnDebtorsEnquiry_Click(object sender, EventArgs e)
        {
            frmDebtorsEnquiry debtorsEnquiry = new frmDebtorsEnquiry();
            debtorsEnquiry.Show();
        }
    }
}
