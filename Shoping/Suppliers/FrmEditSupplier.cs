using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shop.Suppliers
{
    public partial class FrmEditSupplier : Form
    {
        public FrmEditSupplier()
        {
            InitializeComponent();
        }
        public Db.SuppliersRow TargetSupplier  { get; set; }
        static DataManager DbManager = new DataManager();
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (txtSupplierName.Text == "")
            {
                MessageBox.Show("لا يجوز ترك الاسم فارغ","تنبيه");
                return;
                 }
            TargetSupplier.SupplierName = txtSupplierName.Text;
            TargetSupplier.Address = txtAddress.Text;
            TargetSupplier.Phone = txtPhone.Text;
            EditSupplier(TargetSupplier);
          
            this.Hide();
        }

        private void FrmEditSupplier_Load(object sender, EventArgs e)
        {
            txtSupplierName.Text = TargetSupplier.SupplierName;
            txtAddress.Text = TargetSupplier.Address;
            txtPhone.Text = TargetSupplier.Phone;
        }

        private  static bool EditSupplier(Db.SuppliersRow sup)
        {
           Db.SuppliersRow  Rw = DbManager.ShopData.Suppliers .NewSuppliersRow ();
            Rw = (from u in DbManager.ShopData.Suppliers  where u.ID == sup .ID  select u).Single();
            Rw.SupplierName = sup.SupplierName;
            Rw.Address = sup.Address;
            Rw.Phone = sup.Phone;

            DbManager.SaveChanges();
            return true;
        }
    }
}
