using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shop.Accountant
{
    public partial class FrmEditProduct : Form
    {
        public FrmEditProduct()
        {
            InitializeComponent();
        }
        public Db.ProductsRow  targetProduct { get; set; }
        static DataManager DbManager = new DataManager();
        private void FrmEditProduct_Load(object sender, EventArgs e)
        {
            txtProductName.Text = targetProduct.ProductName;
            txtCategoryName.Text = (from c in DbManager.ShopData.Categories where c.ID == targetProduct.CategoryID select c.CategoryName).Single();
            txtDescription.Text = targetProduct.Description;
        }



        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CategId == 0) { CmbCategories_SelectedIndexChanged(sender, e); }
            

            if (txtProductName.Text == "") { Alert.Warning ("أضــــــف النـــتج"); return; }
          
        


                // Start Save Changes:
               // Db.ProductsRow rw = DbManager.ShopData.Products.NewProductsRow();
              //  rw = (from p in DbManager.ShopData.Products where p.ID == targetProduct.ID select p).Single();
                    targetProduct.ProductName = txtProductName.Text;
                    targetProduct.Description = txtDescription.Text;
                    targetProduct.CategoryID = targetProduct .CategoryID ;
               

                DbManager.SaveChanges();

            //=========================================================
                Db.MainStoreRow stor = DbManager.ShopData.MainStore.NewMainStoreRow();

                stor = StoresCmd.GetByProductID(targetProduct.ID);

                stor.ProductID = targetProduct.ID;
 
                stor.Status = "";

                StoresCmd.EditStore(stor, targetProduct.ID);
                DbManager.SaveChanges();


                MessageBox.Show("تــــــم الحــــــفظ");
                this.Hide();
            
        }



        #region "^^^ Selected IDes"
        public int CategId { get; set; }
        public int SuppId { get; set; }
        private void CmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CategId = 0;
                if (txtCategoryName.Text != "")
                {
                    CategId = (from c in CategoryCmd.GetAllCategories()
                               where c.CategoryName == txtCategoryName.Text
                               select c.ID).Single();
                }
                else
                {

                    MessageBox.Show("حـــــدد الصنف");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("حـــــدد الصنف");
            }
        }


        private static Db.ProductsRow GetOneProductByName(string nam)
        {
            Db.ProductsRow prduct = (from p in DbManager.ShopData.Products
                                     where p.ProductName == nam
                                     select p).Single();
            return prduct;
        }
        #endregion

        private void CmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
