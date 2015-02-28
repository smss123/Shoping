using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shop.Sells
{
    public partial class FrmSellManager : Form
    {
        public FrmSellManager()
        {
            InitializeComponent();
        }

        private void AddSellBtn_Click(object sender, EventArgs e)
        {
            FrmAddInvoiceSelles frm = new FrmAddInvoiceSelles();
            frm.ShowDialog();
        }

        private void StoreBtn_Click(object sender, EventArgs e)
        {
            FrmSellesStore frm = new FrmSellesStore();
            frm.ShowDialog();
        }

        private void FrishBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmSellManager_Load(object sender, EventArgs e)
        {
           
        }
    }
}
