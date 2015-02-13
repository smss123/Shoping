using Shop.Accountant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shop.Products
{
    public partial class FrmProductsManager : Form
    {
        public FrmProductsManager()
        {
            InitializeComponent();
        }
        static DataManager DbManager = new DataManager();
        private void AddNewProduct_Click(object sender, EventArgs e)
        {
            FrmAddProduct frm = new FrmAddProduct();
            frm.ShowDialog();
        }

        void PopulateDgv()
        {
            List<Db.ProductsRow> LstProducts = CategoryCmd.GetAllProducts();
            DgvProducts.Rows.Clear();
            foreach (var Prd in LstProducts )
            {
                DgvProducts.Rows.Add(new string[] {Prd.ID.ToString(), Prd.ProductName, Prd.Description});
            }
        }
        private void FrmProductsManager_Load(object sender, EventArgs e)
        {
            PopulateDgv();
        }

        private void FrishBtn_Click(object sender, EventArgs e)
        {
            FrmProductsManager_Load(sender, e);
        }

        private void DgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = this.DgvProducts.CurrentCell.ColumnIndex;
            Db.ProductsRow tb = CategoryCmd.GetProductById(int.Parse(DgvProducts.CurrentRow.Cells[0].Value.ToString()));
            int CurrentProductId = int.Parse(DgvProducts.CurrentRow.Cells[0].Value.ToString());
            if (col.ToString() == "3")
            {
             // Edit 

                
                   FrmEditProduct frm = new FrmEditProduct ();
                   frm.targetProduct = tb;
                 
                   frm.ShowDialog();
            }


            if (col.ToString() == "4")
            {
                // Delete
                // { 1 } FK_MainStore
                Db.MainStoreRow store = DbManager.ShopData.MainStore.Where(target => target.ProductID == tb.ID).Single();
                DbManager.ShopData.MainStore.RemoveMainStoreRow(store);

                //{ 2 }  PK_Products
                Db.ProductsRow tbRow = DbManager.ShopData.Products.NewProductsRow();
                tbRow = CategoryCmd.RemoveProduct(CurrentProductId );

               
                FrmProductsManager_Load(sender, e);
            }



        }
    }
}
