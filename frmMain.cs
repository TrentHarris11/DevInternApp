using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevInternApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            // Event handler for btnDebtors
            this.btnDebtors.Click += new EventHandler(btnDebtors_Click);

            // Event handler for btnStocks
            this.btnStock.Click += new EventHandler(btnStock_Click);

            // Event handler for btnInvoicing
            this.btnInvoices.Click += new EventHandler(btnInvoices_Click);
        }

        private void btnDebtors_Click(object sender, EventArgs e)
        {
            frmDebtorsMaster frm = new frmDebtorsMaster();
            frm.Show();
            this.Hide(); //  Hide the main form
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmStockMaster frm = new frmStockMaster();
            frm.Show();
            this.Hide(); //Hide the main form
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            frmInvoicing frm = new frmInvoicing();
            frm.Show();
            this.Hide(); //Hide the main form
        }
    }
}
