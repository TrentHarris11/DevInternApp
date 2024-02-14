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
using System.Drawing.Printing;

namespace DevInternApp
{
    public partial class frmInvoicing : Form
    {

        private int _accountCode;
        private string _documentNo;
        private DateTime _date;
        private decimal _totalSellExclVat;
        private decimal _vat;

        //private int currentInvoiceNo;
        public frmInvoicing(int accountCode, string documentNo, DateTime date, decimal totalSellExclVat, decimal vat)
        {
            InitializeComponent();

            _accountCode = accountCode;
            _documentNo = documentNo;
            _date = date;
            _totalSellExclVat = totalSellExclVat;
            _vat = vat;

            PopulateDebtorComboBox();
            PopulateInvoiceFields();
        }

        public frmInvoicing()
        {
            InitializeComponent();
        }



        private void PopulateInvoiceFields()
        {
            // Use the private fields to populate the form's controls
            txbAccCode.Text = _accountCode.ToString();
            txbInvoiceNo.Text = _documentNo;
            dtpDate.Value = _date != DateTime.MinValue ? _date : DateTime.Today; // Check for default DateTime value
            txbTotalSellExclVat.Text = _totalSellExclVat.ToString("N2"); // Format for currency
            txbVat.Text = _vat.ToString("N2"); // Format for currency
                                               //TotalCost is the sum of _totalSellExclVat and _vat
            txbTotalCost.Text = (_totalSellExclVat + _vat).ToString("N2");
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

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int invoiceNo = GetSelectedInvoiceNo();

            // Now, you pass this invoiceNo when constructing the frmInvoiceDetails form
            frmInvoiceDetails frmInvoiceHeader = new frmInvoiceDetails(invoiceNo);
            frmInvoiceHeader.Show();
        }

        private int GetSelectedInvoiceNo()
        {
            if (dataGridViewDisplay.CurrentRow != null)
            {
                return Convert.ToInt32(dataGridViewDisplay.CurrentRow.Cells["InvoiceNo"].Value); 
            }
            else
            {
                MessageBox.Show("Please select an invoice from the list.");
                return 0; 
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
            txbAccCode.Clear();
            dtpDate.Value = DateTime.Now; 
            txbTotalSellExclVat.Clear();
            txbVat.Clear();
            txbTotalCost.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFormFields();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font headerFont = new Font("Arial", 10, FontStyle.Bold);
            Font contentFont = new Font("Arial", 10);
            int startX = 50;
            int startY = 55;
            int offsetY = 0;

            // Set header widths
            int[] columnWidths = new int[] { 120, 100, 180, 50, 100 }; // Adjust the widths as needed

            // Print headers and draw vertical lines
            int headerX = startX;
            for (int i = 0; i < dataGridViewDisplay.Columns.Count; i++)
            {
                graphics.DrawString(dataGridViewDisplay.Columns[i].HeaderText,
                                    headerFont,
                                    Brushes.Black,
                                    headerX,
                                    startY);
                headerX += columnWidths[i];
                // Draw vertical line after the header
                graphics.DrawLine(Pens.Black, headerX, startY, headerX, startY + offsetY + (dataGridViewDisplay.Rows.Count * contentFont.GetHeight()) + (5 * dataGridViewDisplay.Rows.Count));
            }

            offsetY += (int)headerFont.GetHeight() + 10; // Add some padding below headers

            // Draw a line under the headers
            graphics.DrawLine(Pens.Black, startX, startY + offsetY, startX + columnWidths.Sum(), startY + offsetY);

            offsetY += 3; // Padding below the header line

            // Print each cell value and draw vertical lines
            foreach (DataGridViewRow row in dataGridViewDisplay.Rows)
            {
                if (row.IsNewRow) continue; // Skip the new row at the end

                int rowX = startX;
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    graphics.DrawString(row.Cells[i].FormattedValue.ToString(),
                                        contentFont,
                                        Brushes.Black,
                                        rowX,
                                        startY + offsetY);
                    rowX += columnWidths[i];
                    // Draw vertical line after the cell value
                    graphics.DrawLine(Pens.Black, rowX, startY + offsetY - 3, rowX, startY + offsetY + contentFont.GetHeight());
                }

                offsetY += (int)contentFont.GetHeight() + 5; // Add padding between rows
            }

            // Draw a horizontal line at the bottom of the last row
            graphics.DrawLine(Pens.Black, startX, startY + offsetY, startX + columnWidths.Sum(), startY + offsetY);

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            int selectedAccountCode = Convert.ToInt32(cmbDebtors.SelectedValue);
            PopulateInvoiceDataGridView(selectedAccountCode);
        }
    }
}
