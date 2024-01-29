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
        }

        private void btnDebtors_Click(object sender, EventArgs e)
        {
            // Create an instance of the frmDebtorsMaster form
            frmDebtorsMaster debtorsForm = new frmDebtorsMaster();

            // Show the frmDebtorsMaster form
            debtorsForm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmStockMaster stockMaster = new frmStockMaster();
            stockMaster.Show();
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            frmInvoicing frmInvoicingForm = new frmInvoicing();
            frmInvoicingForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
