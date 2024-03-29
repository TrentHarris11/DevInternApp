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
                      //MessageBox.Show("Debtor not found.");
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
            int accountCode;
            if (!int.TryParse(txbAccountCode.Text, out accountCode))
            {
                MessageBox.Show("Please enter a valid account code.");
                return;
            }

            if (DoesAccountCodeExist(accountCode))
            {
                MessageBox.Show("This account code has already been created.");
                return;
            }

            // If the account code does not exist, proceed with adding the new debtor record
            string address1 = txbAddress1.Text;
            string address2 = txbAddress2.Text;
            string address3 = txbAddress3.Text;
            decimal balance = nudBalance.Value;
            decimal salesYearToDate = nudSalesYear.Value;
            decimal costYearToDate = nudCostYear.Value;

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
                        txbAccountCode.Clear();
                        txbAddress1.Clear();
                        txbAddress2.Clear();
                        txbAddress3.Clear();
                        nudBalance.Value = 0;
                        nudCostYear.Value = 0;
                        nudSalesYear.Value= 0;
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

        private bool DoesAccountCodeExist(int accountCode) //Method to check whether account code exists
        {
            bool exists = false;
            string connectionString = "data source=user\\SQLEXPRESS;initial catalog=xact1;trusted_connection=true";
            string query = "SELECT COUNT(1) FROM DebtorsMaster WHERE AccountCode = @AccountCode";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@AccountCode", accountCode);

                try
                {
                    connection.Open();
                    exists = (int)command.ExecuteScalar() > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while checking the account code: " + ex.Message);
                }
            }

            return exists;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            // Input validation
            if (string.IsNullOrWhiteSpace(txbAccountCode.Text) ||
                string.IsNullOrWhiteSpace(txbAddress1.Text) ||
                string.IsNullOrWhiteSpace(txbAddress2.Text) ||
                string.IsNullOrWhiteSpace(txbAddress3.Text))
            {
                MessageBox.Show("All fields must be populated.");
                return;
            }


            // Collect data from input fields
            int accountCode = Convert.ToInt32(txbAccountCode.Text);
            string address1 = txbAddress1.Text;
            string address2 = txbAddress2.Text;
            string address3 = txbAddress3.Text;
            decimal balance = nudBalance.Value;
            decimal salesYearToDate = nudSalesYear.Value;
            decimal costYearToDate = nudCostYear.Value;

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
            // Input validation
            if (string.IsNullOrWhiteSpace(txbAccountCode.Text) ||
                string.IsNullOrWhiteSpace(txbAddress1.Text) ||
                string.IsNullOrWhiteSpace(txbAddress2.Text) ||
                string.IsNullOrWhiteSpace(txbAddress3.Text))
            {
                MessageBox.Show("All fields must be populated.");
                return;
            }

            // Confirm with the user if they want to proceed with the deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this debtor record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);



            if (result == DialogResult.Yes)
            {
                // Delete the corresponding record from the database
                int accountCode = Convert.ToInt32(txbAccountCode.Text); //Account code is used to identify the debtor record

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

        public void PopulateFields(int accountCode, string address1, string address2, string address3, decimal balance, decimal salesYearToDate, decimal costYearToDate)
        {
            // Set the fields with the provided data
            txbAccountCode.Text = accountCode.ToString();
            txbAddress1.Text = address1;
            txbAddress2.Text = address2;
            txbAddress3.Text = address3;
            nudBalance.Text = balance.ToString("N2"); // Format for currency
            nudSalesYear.Text = salesYearToDate.ToString("N2"); // Format for currency
            nudCostYear.Text = costYearToDate.ToString("N2"); // Format for currency
            txbAccountCode.Enabled = false;
        }

        private void frmDebtorsMaster_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(nudBalance, "Balance Amount Owed by Debtor");

            ToolTip toolTip2 = new ToolTip();
            toolTip1.SetToolTip(nudCostYear, "Accumulated Income From Debtor This Year");

            ToolTip toolTip3 = new ToolTip();
            toolTip1.SetToolTip(nudSalesYear, "Accumulated Value of Sales From Debtor This Year");


            //Populate the form with data for a specific debtor (e.g., account code 123)
            int accountCode = 123; 

            //Call the PopulateDebtorData method to populate the form with data for the specified debtor
            PopulateDebtorData(accountCode);
        }

        private void btnMainScreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDebtorsEnquiry_Click(object sender, EventArgs e)
        {
            frmDebtorsEnquiry debtorsEnquiry = new frmDebtorsEnquiry();
            debtorsEnquiry.Show();
            this.Close();
        }

        private void txbAccountCode_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
