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
        
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmInvoicing invoicing = new frmInvoicing();
            invoicing.Show();
        }



        private void frmAddItem_Load(object sender, EventArgs e)
        {
           
        }


            private void cmbStock_SelectedIndexChanged(object sender, EventArgs e)
        {
                 
        }

        

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }
    }
}
