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
    public partial class frmAddItem : Form
    {
        public frmAddItem()
        {
            InitializeComponent();
            // Subscribe to TextChanged events
            txbQuantity.TextChanged += (s, e) => CalculateTotalCost();
            txbDiscount.TextChanged += (s, e) => CalculateTotalCost();
        }

        private void CalculateTotalCost()
        {
            if (decimal.TryParse(txbUnitSellingPrice.Text, out decimal unitSell) &&
                int.TryParse(txbQuantity.Text, out int quantity) &&
                decimal.TryParse(txbDiscount.Text, out decimal discount))
            {
                decimal totalCost = quantity * (unitSell - discount);
                lblTotalCosts.Text = totalCost >= 0 ? totalCost.ToString("C") : "N/A";
            }
            else
            {
                lblTotalCosts.Text = "N/A";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmInvoicing invoicing = new frmInvoicing();
            invoicing.Show();
        }



        private void frmAddItem_Load(object sender, EventArgs e)
        {
            PopulateStockCodeComboBox();
        }

        private void PopulateStockCodeComboBox()
        {
            string connectionString = "data source=user\\SQLEXPRESS;initial catalog=xact1;trusted_connection=true";
            string query = "SELECT StockCode FROM StockMaster";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable stockCodes = new DataTable();
                        adapter.Fill(stockCodes);
                        cmbStock.DisplayMember = "StockCode";
                        cmbStock.ValueMember = "StockCode";
                        cmbStock.DataSource = stockCodes;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message);
                    }
                }
            }
        }

            private void cmbStock_SelectedIndexChanged(object sender, EventArgs e)
        {
                 UpdateDescriptionAndPrices();
        }

        private void UpdateDescriptionAndPrices()
        {
            string selectedStockCode = cmbStock.SelectedValue.ToString();
            string connectionString = "data source=user\\SQLEXPRESS;initial catalog=xact1;trusted_connection=true";
            string query = "SELECT StockDescription, Cost, SellingPrice FROM StockMaster WHERE StockCode = @StockCode";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StockCode", selectedStockCode);
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblDescription.Text = reader["StockDescription"].ToString();
                                txbUnitCost.Text = reader["Cost"].ToString();
                                txbUnitSellingPrice.Text = reader["SellingPrice"].ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message);
                    }
                }
            }
        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate inputs and calculate total...
            if (decimal.TryParse(txbUnitSellingPrice.Text, out decimal unitSell) &&
                int.TryParse(txbQuantity.Text, out int quantity) &&
                decimal.TryParse(txbDiscount.Text, out decimal discount))
            {
                // Calculate total cost
                decimal totalCost = quantity * (unitSell - discount);

                // Check if the total cost is not negative
                if (totalCost >= 0)
                {
                    // If you have a public method in frmInvoicing to add items, invoke it here
                    // Assuming you have a reference to the frmInvoicing instance:
                    var mainForm = this.Owner as frmInvoicing;
                    if (mainForm != null)
                    {
                        mainForm.AddItemToInvoice(
                            cmbStock.SelectedValue.ToString(),
                            lblDescription.Text,
                            quantity,
                            decimal.Parse(txbUnitCost.Text), // Assuming txtUnitCost is always valid
                            unitSell,
                            discount,
                            totalCost
                        );
                    }

                    // Close the form
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The total cost cannot be negative.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for quantity, unit cost, unit sell price, and discount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
