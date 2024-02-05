using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevInternApp
{
    public partial class frmInvoicing : Form
    {

        private int currentInvoiceNo;
        public frmInvoicing()
        {
            InitializeComponent();
            dtpInvoice.Value = DateTime.Now; // Set to current date
            PopulateDebtorComboBox();
            
        }

        private void PopulateInvoiceDataGridView(int accountCode)
        {
            string connectionString = @"data source=user\SQLEXPRESS;initial catalog=xact1;trusted_connection=true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT InvoiceNo, Date, TotalSellAmountExclVAT, Vat, TotalCost 
                         FROM InvoiceHeader 
                         WHERE AccountCode = @AccountCode";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AccountCode", accountCode);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable invoiceData = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(invoiceData);
                    dataGridViewDisplay.DataSource = invoiceData;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while fetching invoice data: " + ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulateDebtorComboBox()
        {
            string connectionString = @"data source=user\SQLEXPRESS;initial catalog=xact1;trusted_connection=true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT AccountCode, (Address1 + ' ' + Address2 + ' ' + Address3) AS DebtorName FROM DebtorsMaster";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable debtorData = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(debtorData);
                    cmbDebtors.DataSource = debtorData;
                    cmbDebtors.DisplayMember = "DebtorName";
                    cmbDebtors.ValueMember = "AccountCode";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while populating the debtor list: " + ex.Message);
                }
            }
        }

        private void cmbDebtors_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbDebtors.SelectedValue != null && int.TryParse(cmbDebtors.SelectedValue.ToString(), out int selectedAccountCode))
            {
                PopulateInvoiceDataGridView(selectedAccountCode);
            }
        }

        private void frmInvoicing_Load(object sender, EventArgs e)
        {
            PopulateDebtorComboBox();
        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }  

        private void dataGridViewDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Add columns to the DataGridView

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Assuming you have a way to obtain the currently selected InvoiceNo from your DataGridView or another control
            int invoiceNo = GetSelectedInvoiceNo();

            // Now, you pass this invoiceNo when constructing the frmInvoiceDetails form
            frmInvoiceDetails frmInvoiceHeader = new frmInvoiceDetails(invoiceNo);
            frmInvoiceHeader.Show();
        }

        private int GetSelectedInvoiceNo()
        {
            // You need to implement the logic to retrieve the selected invoice number from your DataGridView
            // Here is just a placeholder for the logic you need to implement
            if (dataGridViewDisplay.CurrentRow != null)
            {
                return Convert.ToInt32(dataGridViewDisplay.CurrentRow.Cells["InvoiceNo"].Value); //
            }
            else
            {
                MessageBox.Show("Please select an invoice from the list.");
                return 0; // Or handle this scenario appropriately
            }
        }

        private void lblTotalCost_Click(object sender, EventArgs e)
        {

        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            string connectionString = @"data source=user\SQLEXPRESS;initial catalog=xact1;trusted_connection=true";
            // Attempt to parse the account code from the textbox
            if (!int.TryParse(txbAccCode.Text, out int accountCode))
            {
                MessageBox.Show("Please enter a valid Account Code.");
                return;
            }

            // Parse other input values, performing validation as necessary
            if (!decimal.TryParse(txbTotalSellExclVat.Text, out decimal totalSellExclVat))
            {
                MessageBox.Show("Please enter a valid Total Sell Amount Excluding VAT.");
                return;
            }

            if (!decimal.TryParse(txbVat.Text, out decimal vat))
            {
                MessageBox.Show("Please enter a valid VAT amount.");
                return;
            }

            if (!decimal.TryParse(txbTotalCost.Text, out decimal totalCost))
            {
                MessageBox.Show("Please enter a valid Total Cost amount.");
                return;
            }

            DateTime invoiceDate = dtpDate.Value; // Get the date from the DateTimePicker

            string insertQuery = @"INSERT INTO InvoiceHeader (AccountCode, Date, TotalSellAmountExclVAT, Vat, TotalCost)
                           VALUES (@AccountCode, @Date, @TotalSellAmountExclVAT, @Vat, @TotalCost);
                           SELECT SCOPE_IDENTITY();"; // This will return the last identity value inserted

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                // Add parameters to SqlCommand
                command.Parameters.AddWithValue("@AccountCode", accountCode);
                command.Parameters.AddWithValue("@Date", invoiceDate);
                command.Parameters.AddWithValue("@TotalSellAmountExclVAT", totalSellExclVat);
                command.Parameters.AddWithValue("@Vat", vat);
                command.Parameters.AddWithValue("@TotalCost", totalCost);

                try
                {
                    connection.Open();
                    // ExecuteScalar() is used because SCOPE_IDENTITY() returns a value
                    var invoiceNo = command.ExecuteScalar();

                    // If the insert was successful and an identity value was generated,
                    // it will be assigned to txbInvoiceNo.Text
                    if (invoiceNo != null)
                    {
                        txbInvoiceNo.Text = invoiceNo.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while inserting the invoice: " + ex.Message);
                }
            }
        }
        private void ClearFormFields()
        {
            // Replace these with your actual control names if they are different
            txbAccCode.Clear();
            dtpDate.Value = DateTime.Now; // or set to DateTime.Today for just the date without time
            txbTotalSellExclVat.Clear();
            txbVat.Clear();
            txbTotalCost.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFormFields();
        }
    }
}
