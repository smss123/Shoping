using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shop.Customers
{
    public partial class FrmCustomersManager : Form
    {
        public FrmCustomersManager()
        {
            InitializeComponent();
        }
        static DataManager DbManager = new DataManager();


        void PopulateDgv()
        {

        }
       
        private void FrmCustomersManager_Load(object sender, EventArgs e)
        {



        }

        private void FrishBtn_Click(object sender, EventArgs e)
        {
            FrmCustomersManager_Load(sender, e);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
           
            try
            {

            }
            catch (Exception)
            {
                Db.CustomersRow c = DbManager.ShopData.Customers.NewCustomersRow();
                c.CustomerName = txtName.Text;
                c.Address = txtAddress.Text;
                c.Phone = txtPhone.Text;
                CustomersCmd.NewCustomer(c);
                Operation.ShowMassege("", this);
            }
        }
    }
}
