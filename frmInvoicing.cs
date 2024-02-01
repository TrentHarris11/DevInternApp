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
            frmInvoiceHeader frmInvoiceHeader = new frmInvoiceHeader();
            frmInvoiceHeader.Show();
        }

        private void lblTotalCost_Click(object sender, EventArgs e)
        {

        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            string connectionString = @"data source=user\SQLEXPRESS;initial catalog=xact1;trusted_connection=true";
            int accountCode;
            if (!int.TryParse(txbAccCode.Text, out accountCode))
            {
                MessageBox.Show("Please enter a valid Account Code.");
                return;
            }

            // Parse other input values, performing validation as necessary
            decimal totalSellExclVat = decimal.Parse(txbTotalSellExclVat.Text);
            decimal vat = decimal.Parse(txbVat.Text);
            decimal totalCost = decimal.Parse(txbTotalCost.Text);
            DateTime invoiceDate = dtpDate.Value;

            string insertQuery = @"INSERT INTO InvoiceHeader (AccountCode, Date, TotalSellAmountExclVAT, Vat, TotalCost)
                           VALUES (@AccountCode, @Date, @TotalSellAmountExclVAT, @Vat, @TotalCost);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@AccountCode", accountCode);
                command.Parameters.AddWithValue("@Date", invoiceDate);
                command.Parameters.AddWithValue("@TotalSellAmountExclVAT", totalSellExclVat);
                command.Parameters.AddWithValue("@Vat", vat);
                command.Parameters.AddWithValue("@TotalCost", totalCost);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Invoice added successfully.");

                    // Optionally retrieve and show the generated InvoiceNo here
                    // Clear the form fields after successful insertion
                    ClearFormFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
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
