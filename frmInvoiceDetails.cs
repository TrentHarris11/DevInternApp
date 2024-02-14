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
using System.Drawing.Printing;

namespace DevInternApp
{
    public partial class frmInvoiceDetails : Form
    {
        private string connectionString = @"data source=user\SQLEXPRESS;initial catalog=xact1;trusted_connection=true";
        private int currentInvoiceNo;
        public frmInvoiceDetails(int invoiceNo)
        {
            InitializeComponent();
            currentInvoiceNo = invoiceNo;
            txbInvoiceNo.Text = invoiceNo.ToString();
            RefreshDataGridView();
            PopulateStockCodes();
        }

        private void CalculateTotal()
        {
            if (decimal.TryParse(txbQtySold.Text, out decimal qtySold) &&
                decimal.TryParse(txbUnitSell.Text, out decimal unitSell) &&
                decimal.TryParse(txbDiscount.Text, out decimal discount))
            {
                decimal total = (qtySold * unitSell) - discount;
                txbTotal.Text = total.ToString("0.00");
            }
        }

        private void frmInvoiceHeader_Load(object sender, EventArgs e)
        {

        }

        private void RefreshDataGridView()
        {
           
            string selectQuery = @"SELECT ItemNo, StockCode, QtySold, UnitCost, UnitSell, Disc, Total 
                               FROM InvoiceDetail WHERE InvoiceNo = @InvoiceNo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@InvoiceNo", currentInvoiceNo);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable invoiceDetailsTable = new DataTable();
                adapter.Fill(invoiceDetailsTable);
                dataGridViewDisplay.DataSource = invoiceDetailsTable;
            }
        }

        private void PopulateStockCodes()
        {
            string query = "SELECT DISTINCT StockCode FROM StockTransaction";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbStockCode.Items.Add(reader["StockCode"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while populating stock codes: " + ex.Message);
                }
            }
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            CalculateTotal();

            string insertQuery = @"INSERT INTO InvoiceDetail (InvoiceNo, StockCode, QtySold, UnitCost, UnitSell, Disc, Total)
                               VALUES (@InvoiceNo, @StockCode, @QtySold, @UnitCost, @UnitSell, @Disc, @Total);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@InvoiceNo", currentInvoiceNo);
                command.Parameters.AddWithValue("@StockCode", cmbStockCode.Text);
                command.Parameters.AddWithValue("@QtySold", int.Parse(txbQtySold.Text));
                command.Parameters.AddWithValue("@UnitCost", decimal.Parse(txbUnitCost.Text));
                command.Parameters.AddWithValue("@UnitSell", decimal.Parse(txbUnitSell.Text));
                command.Parameters.AddWithValue("@Disc", decimal.Parse(txbDiscount.Text));
                command.Parameters.AddWithValue("@Total", decimal.Parse(txbTotal.Text));

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Invoice detail added successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            RefreshDataGridView();
        }

      

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbStockCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStockCode = cmbStockCode.SelectedItem.ToString();
            FetchStockDetails(selectedStockCode);
        }

        private void FetchStockDetails(string stockCode)
        {
            string query = "SELECT TOP 1 UnitCost, UnitSell FROM StockTransaction WHERE StockCode = @StockCode ORDER BY Date DESC";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@StockCode", stockCode);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txbUnitCost.Text = reader["UnitCost"].ToString();
                            txbUnitSell.Text = reader["UnitSell"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while fetching stock details: " + ex.Message);
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font headerFont = new Font("Arial", 10, FontStyle.Bold);
            Font contentFont = new Font("Arial", 10);
            int startX = 50;
            int startY = 55;
            int offsetY = 0;

            // Adjust the widths as needed for the 8 columns
            int[] columnWidths = new int[] { 120, 90, 110, 80, 70, 70, 70, 70 };

            // Ensure the sum of the column widths does not exceed the page width
            int pageWidth = e.PageBounds.Width - (startX * 2); // Adjust startX accordingly if you have set margins
            if (columnWidths.Sum() > pageWidth)
            {
                // Handle the situation where the sum of column widths is too wide for the page
                // Perhaps by reducing font size, adjusting column widths, or continuing on a new line
            }

            // Print headers and draw vertical lines
            int headerX = startX;
            for (int i = 0; i < dataGridViewDisplay.Columns.Count; i++)
            {
                if (i < columnWidths.Length) // Check to avoid index out of bounds
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
            }

            offsetY += (int)headerFont.GetHeight() + 10; // Add some padding below headers

            // Draw a line under the headers
            graphics.DrawLine(Pens.Black, startX, startY + offsetY, headerX, startY + offsetY);

            offsetY += 3; // Padding below the header line

            // Print each cell value and draw vertical lines
            foreach (DataGridViewRow row in dataGridViewDisplay.Rows)
            {
                if (row.IsNewRow) continue; // Skip the new row at the end

                int rowX = startX;
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    if (i < columnWidths.Length) // Check to avoid index out of bounds
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
                }

                offsetY += (int)contentFont.GetHeight() + 5; // Add padding between rows
            }

            // Draw a horizontal line at the bottom of the last row
            graphics.DrawLine(Pens.Black, startX, startY + offsetY, headerX, startY + offsetY);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
