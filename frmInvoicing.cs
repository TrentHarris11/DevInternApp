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
    public partial class frmInvoicing : Form
    {

        
        public frmInvoicing()
        {
            InitializeComponent();
            dtpInvoice.Value = DateTime.Now; // Set to current date
            PopulateDebtorComboBox();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulateDebtorComboBox()
        {
            string query = "SELECT AccountCode, Address1 AS DebtorInfo FROM DebtorsMaster";
            DataTable debtors = new DataTable();

            using (SqlConnection conn = new SqlConnection("data source=user\\SQLEXPRESS;initial catalog=xact1;trusted_connection=true"))
            {
                try  
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(debtors);
                        cmbDebtors.DisplayMember = "DebtorInfo";
                        cmbDebtors.ValueMember = "AccountCode";
                        cmbDebtors.DataSource = debtors;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while populating debtor information: " + ex.Message);
                }
            }
        }

        private void cmbDebtors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmInvoicing_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }  

        private void dataGridViewDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Add columns to the DataGridView
            dataGridViewDisplay.Columns.Add("StockCode", "Stock Code");
            dataGridViewDisplay.Columns.Add("Description", "Description");
            dataGridViewDisplay.Columns.Add("QuantitySold", "Quantity Sold");
            dataGridViewDisplay.Columns.Add("UnitCost", "Unit Cost");
            dataGridViewDisplay.Columns.Add("UnitSell", "Unit Sell");
            dataGridViewDisplay.Columns.Add("Discount", "Discount");
            dataGridViewDisplay.Columns.Add("Total", "Total");
        }
    }
}
