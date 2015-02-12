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
    public partial class FrmStartingWork : Form
    {
        public FrmStartingWork()
        {
            InitializeComponent();
        }
        static DataManager DbManager = new DataManager();
        public int PrdID  { get; set; }
        private void FrmAddProduct_Load(object sender, EventArgs e)
        {
            Broom();
            PopulateCmb();
            PopulateTree();
       
        }


        #region "   ^^^ Save Process     "
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            #region "  ^^^ Check Controls Vales     "

            if (CmbProductName.Text == "") { Operation.ShowMassege("أضــــــف النـــتج", this); return; }
            if (txtQty.Text == "") { Operation.ShowMassege("أضــــــف الكميــــــه", this); return; }
            if (txtPrice.Text == "") { Operation.ShowMassege("أضــــــف الســـــــغر", this); return; }
          
            #endregion

            #region " ^^^ Check IDes   "

              if (CategId == 0) { CmbCategories_SelectedIndexChanged(sender, e); }
              if (SuppId == 0 && CmbSuppliers.Text == ""){  CmbSuppliers_SelectedIndexChanged(sender, e);  }
         
            #endregion

           #region "^^^ Check Product "
            
            var prduct = GetOneProductByName(CmbProductName.Text);

            Db.ProductsRow rw = DbManager.ShopData.Products.NewProductsRow();

            Db.MainStoreRow stor = DbManager.ShopData.MainStore.NewMainStoreRow();
            if(prduct .ID == 0 )
            {
               // Start Save : { New Product}
                rw.ProductName = CmbProductName.Text;
                rw.CategoryID = CategId;
                rw.Description = string.Format(" Product Name : {0}  ||  Category Name {1}  : ", txtItemName.Text, CmbCategories.Text);
                DbManager.ShopData.Products.AddProductsRow(rw);
                DbManager.SaveChanges();


                // New Store 
                //== أضافة سجل جديد للمخزن العام             
                stor.ProductID = rw.ID;
                stor.Status = "";
                DbManager.ShopData.MainStore.AddMainStoreRow(stor);
                DbManager.SaveChanges();

                PrdID = rw.ID;
            }
            else {
                PrdID = prduct .ID ;
            }

           #endregion
            try
            {
                   #region "   ^^^^ Check Item    "

                      var  CurrentItem = ProductItemesCmd . ItemsByName(txtItemName .Text );
                     if(CurrentItem .ID != 0){ MessageBox.Show ("موجـــــود من قبل") ;Broom (); return ;}

                   #endregion

          

             }
             catch (Exception)
             {

                 //===============================================================
                 // Start Save At ProductItems Table :
                 Db.ProductItemsRow pirw = DbManager.ShopData.ProductItems.NewProductItemsRow();
                 pirw.ItemName = txtItemName.Text;
                 pirw.ProductID = PrdID;
                 pirw.SupplierID = SuppId;
                 pirw.Qty = int.Parse(txtQty.Text);
                 pirw.ItemPrice = int.Parse(txtPrice.Text);
                 pirw.ItemUnit = CmbUnitType.Text;
                 pirw.TotalCostPrice = int.Parse(txtPrice.Text) * int.Parse(txtQty.Text);
                 pirw.Comment = "";
                 DbManager.ShopData.ProductItems.AddProductItemsRow(pirw);
                 DbManager.SaveChanges();
                 //============================================================================
                 // Start Save At ItemesStoreRow
                 Db.ItemesStoreRow itmstr = DbManager.ShopData.ItemesStore.NewItemesStoreRow();
                 itmstr.ItemID = pirw.ID;
                 itmstr.MainStoreID = stor.ID;
                 itmstr.AvailableQty = int.Parse(txtQty.Text);
                 itmstr.ExpireDate = ExpireValue.Value.ToShortDateString();
                 DbManager.ShopData.ItemesStore.AddItemesStoreRow(itmstr);
                 DbManager.SaveChanges();
                 //============================================================================
                 Operation.ShowMassege("تــــــم الحــــــفظ", this);
                 FrmAddProduct_Load(sender, e);
             }
          
               
           
        }

        #endregion

        #region "   ^^^ Clear And Populate           "
        void Broom()
        {
            CmbCategories.Text = ""; CmbSuppliers.Text = ""; CmbProductName.Text = ""; txtPrice.Text = ""; CmbUnitType.Text = "";
            CmbCategories.Focus();
        }

        void PopulateCmb()
        {
            CmbCategories.Items.Clear();
            CmbCategories.Items.AddRange((from c in CategoryCmd.GetAllCategories()
                                          select c.CategoryName).Distinct().ToArray());
            CmbProductName.Items.Clear();
            CmbProductName .Items .AddRange ((from p in CategoryCmd.GetAllProducts () select p.ProductName ).Distinct ().ToArray ());

            CmbSuppliers.Items.Clear();
            CmbSuppliers.Items.AddRange(((from s in DbManager.ShopData.Suppliers
                                          select s.SupplierName).Distinct().ToArray()));

            CmbUnitType.Items.Clear();
            CmbUnitType.Items.AddRange((from c in ProductItemesCmd.GetAllItems() select c.ItemUnit).Distinct().ToArray());

            
        }

        void PopulateTree()
        {
            int cat = 0;
            int prd = 0;
            int itm = 0;
            ProductsTree.Nodes.Clear();
            ProductsTree.Nodes.Add("Abu Ehab", "التصنيفات", 0);
            List<Db.CategoriesRow> LstCateg = CategoryCmd.GetAllCategories();

            foreach (var catg in LstCateg) // 1 Category
            {
                ProductsTree.Nodes[0].Nodes .Add(catg.ID .ToString (),catg .CategoryName ,1);

                List<Db.ProductsRow> LstProducts = CategoryCmd.GetAllProductsByCategoryID(catg.ID );

                foreach (var pd in LstProducts) // 2 Products
                {
                    ProductsTree.Nodes[0].Nodes[cat].Nodes.Add("prdct",pd.ProductName , 2);


                    List<Db.ProductItemsRow> LstItems = ProductItemesCmd.GetAllItemsByProductID(pd.ID);

                    foreach (var item in LstItems) // 3  ProductItemes
                    {
                        ProductsTree.Nodes[0].Nodes[cat].Nodes["prdct"].Nodes .Add("xItem",item .ItemName ,3);

                        List<Db.ItemesStoreRow> LstItemsStore = StoresCmd.GetAllByItemId(item.ID);

                        foreach (var Sitem in LstItemsStore)// 4  ItemesStore
                        {
                            ProductsTree.Nodes[0].Nodes[cat].Nodes["prdct"].Nodes["xItem"].Nodes .Add("ItmStor",Sitem.AvailableQty .ToString (),4);
                        } // 4
                     itm ++;
                    } // 3
                    prd++;
                } // 2
                cat++;
            } // 1




        }

        #endregion 

   
        #region "^^^ Selected IDes"
        public int CategId { get; set; }
        public int SuppId { get; set; }
        private void CmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                  CategId = 0;
                  if (CmbCategories.Text != "") 
                  {
                      CategId = (from c in CategoryCmd.GetAllCategories()
                                 where c.CategoryName == CmbCategories.Text select c.ID).Single();
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

        private void CmbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SuppId = 0;
                if (CmbSuppliers.Text == "") { MessageBox.Show("أدخل أسم المورد"); return; }

                // Start Check Supplier Data :
                if (CmbSuppliers.Text != "") 
                {
                    SuppId = (from s in DbManager.ShopData.Suppliers 
                                                         where s.SupplierName == CmbSuppliers.Text
                                                         select s.ID).Single();
                }
                
            }

            catch (Exception)
            {

                if (SuppId == 0)
                {

                    //====================================================================
                    // أذا المورد غير معلوم يتم تسجيل اسمه وانشاء حساب له
                    // CreateAccount At Accounts Table

                    int AcctId = 0;
                    Db.AccountsRow act = DbManager.ShopData.Accounts.NewAccountsRow();
                    act.AccountName = CmbSuppliers.Text;
                    act.Description = "Supplier";
                    act.AccountCategoryID = 5;
                    DbManager.ShopData.Accounts.AddAccountsRow(act);
                    DbManager.SaveChanges();
                    AcctId = act.ID;
                    //====================================================================
                    // Save New Supplier At Supplier Table
                    Db.SuppliersRow Suplr = DbManager.ShopData.Suppliers.NewSuppliersRow();
                    Suplr.SupplierName = CmbSuppliers.Text;

                    Suplr.AccountID = AcctId;
                    DbManager.ShopData.Suppliers.AddSuppliersRow(Suplr);
                    DbManager.SaveChanges();

                }
            
            }
        }

        private static Db.ProductsRow GetOneProductByName(string nam)
        {
            Db.ProductsRow prduct = (from p in DbManager.ShopData.Products 
                                     where p.ProductName == nam select p).Single();
            return prduct;
        }
        #endregion

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            Broom();
            this.Hide();
        }

        private void ExpanedAllBtn_Click(object sender, EventArgs e)
        {
            ProductsTree.ExpandAll();
        }

        private void CollapseAllBtn_Click(object sender, EventArgs e)
        {
            ProductsTree.CollapseAll();
        }

    
    }
}
