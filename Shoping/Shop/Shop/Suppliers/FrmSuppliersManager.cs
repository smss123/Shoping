using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace Shop.Suppliers
{
    public partial class FrmSuppliersManager : Form
    {
        public FrmSuppliersManager()
        {
            InitializeComponent();
        }
        static DataManager DbManager = new DataManager();
        public int AcctId { get; set; }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSupplierName.Text == "") { return; }
                Db.SuppliersRow GetHim = GetSupplierByName(txtSupplierName.Text);
                MessageBox.Show("موجود بالفــعل");
                return;
            }
            catch (Exception)
            {
                //====================================================================
                AcctId = 0;
                Db.AccountsRow act = DbManager.ShopData.Accounts.NewAccountsRow();
                act.AccountName = txtSupplierName.Text;
                act.Description = "Supplier";
                act.AccountCategoryID = 5;
                DbManager.ShopData.Accounts.AddAccountsRow(act);
                DbManager.SaveChanges();
                AcctId = act.ID;
                //====================================================================
                Db.SuppliersRow Suplr = DbManager.ShopData.Suppliers.NewSuppliersRow();
                Suplr.SupplierName = txtSupplierName .Text ;
                Suplr.Address = txtAddress.Text;
                Suplr.Phone = txtPhone.Text;
                Suplr.AccountID =  AcctId ;
                DbManager.ShopData.Suppliers.AddSuppliersRow(Suplr);
                DbManager.SaveChanges();
                MessageBox.Show("تــم الحــــــفظ بنجــاح");
                FrmSuppliersManager_Load(sender, e);
                
            }
        }

        private static List<Db.SuppliersRow> GetAllSuppliers()
        {
            List<Db.SuppliersRow> GetAll = (from s in DbManager.ShopData.Suppliers select s).ToList();
            return GetAll;
        }

        private static Db.SuppliersRow GetSupplierByName(string nam)
        {
            Db.SuppliersRow GetHim = (from s in DbManager.ShopData.Suppliers 
                                      where s.SupplierName == nam select s).Single();
            return GetHim;
        }
        private static Db.SuppliersRow GetSupplierById(int  xid)
        {
            Db.SuppliersRow GetHim = (from s in DbManager.ShopData.Suppliers
                                      where s.ID == xid 
                                      select s).Single();
            return GetHim;
        }
        private void FrmSuppliersManager_Load(object sender, EventArgs e)
        {

            broom();

            PopulateDgv();
        }
        void PopulateDgv() {

            List<Db.SuppliersRow> GetAll = GetAllSuppliers();
            DgvSuppliers.Rows.Clear();
            foreach (var sup in GetAll )
            {
                DgvSuppliers.Rows.Add(new string[] { sup .ID .ToString (), sup .SupplierName , sup.Address , sup .Phone ,sup.AccountID .ToString ()});
            }
        }
        void broom()
        {
            txtSupplierName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtSupplierName.Focus();
        }

        private void DgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int col = this.DgvSuppliers.CurrentCell.ColumnIndex;
            // int row = this.DgvUsers.CurrentCell.RowIndex;

            Db.SuppliersRow rw =  GetSupplierById(int.Parse(DgvSuppliers.CurrentRow.Cells[0].Value.ToString()));
            if (col.ToString() == "5")
            {
                FrmEditSupplier frm = new FrmEditSupplier();

                frm.TargetSupplier = rw;
                frm.ShowDialog();
            }

            if (col.ToString() == "6")
            {
                Db.AccountsRow act = (from a in DbManager.ShopData.Accounts
                                      where a.ID == rw.AccountID 
                                      select a).Single();
                DbManager.ShopData.Accounts.RemoveAccountsRow(act);
                DbManager.SaveChanges();
                //============================================================
                DbManager.ShopData.Suppliers.RemoveSuppliersRow(rw);
                FrmSuppliersManager_Load(sender, e);
            }
        }

     

        private void FrishBtn_Click(object sender, EventArgs e)
        {
            FrmSuppliersManager_Load(sender, e);
        }

    }
}
