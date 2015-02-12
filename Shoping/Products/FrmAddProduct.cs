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
    public partial class FrmAddProduct : Form
    {
        public FrmAddProduct()
        {
            InitializeComponent();
        }
        static DataManager DbManager = new DataManager();

        void PopulateCmo()
        {
            CmbCategories.Items.Clear();
            CmbCategories.Items.AddRange((from c in CategoryCmd.GetAllCategories()
                                          select c.CategoryName).Distinct().ToArray());

            CmbProducts.Items.Clear();
            CmbProducts.Items.AddRange((from p in CategoryCmd.GetAllProducts() 
                                        select p.ProductName).Distinct().ToArray());


        }
        private void FrmAddProduct_Load(object sender, EventArgs e)
        {
            PopulateCmo();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
           
            if (CmbCategories.Text == "") { Operation.ShowMassege("أختـــــــــار  التصنيف", this); return; }
            if (CategId == 0) { CmbCategories_SelectedIndexChanged(sender, e); }
            if (CmbProducts.Text == "") { Operation.ShowMassege("أضــــــف النـــتج", this); return; }
         

           
            try
            {
                Db.ProductsRow prduct = GetOneProductByName(CmbProducts.Text);
                Operation.ShowMassege("موجود بالفعــــــل", this);
                ClearTxt();
                return;
            }
            catch (Exception)
            {
                // Start Save :
                Db.ProductsRow rwProduct = DbManager.ShopData.Products.NewProductsRow();
                rwProduct.Description = txtDescription.Text;
                rwProduct.ProductName = CmbProducts.Text;
                rwProduct.CategoryID = CategId;
                DbManager.ShopData.Products.AddProductsRow(rwProduct);

                DbManager.SaveChanges();

                //========================================================================
                Db.MainStoreRow stor = DbManager.ShopData.MainStore.NewMainStoreRow();

                stor.ProductID = rwProduct.ID;
                stor.Status = "";

                DbManager.ShopData.MainStore.AddMainStoreRow(stor);
                DbManager.SaveChanges();


                Operation .ShowMassege ("تــــــم الحــــــفظ",this );
                ClearTxt();
            }


        }


        private static Db.ProductsRow GetOneProductByName(string nam)
        {
            Db.ProductsRow prduct = (from p in DbManager.ShopData.Products
                                     where p.ProductName == nam
                                     select p).Single();
            return prduct;
        }



        public int CategId { get; set; }
    


        private void CmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CategId = 0;
                if (CmbCategories.Text != "")
                {
                    CategId = (from c in CategoryCmd.GetAllCategories()
                               where c.CategoryName == CmbCategories.Text
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

        private void CmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void ClearTxt()
        {
            CmbCategories.Text = "";
            CmbProducts.Text = "";
            txtDescription.Text = "";
            CmbCategories.Focus();
            CategId = 0 ;

        }

    }
}
