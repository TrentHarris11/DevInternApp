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
            // Input validation here...

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
    }
}
