using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace Shop.Accountant
{
    public partial class FrmAccountsManager : Form
    {
        public FrmAccountsManager()
        {
            InitializeComponent();
            AccountCategoryBtn.Enabled = false;
        }
        static DataManager DbManager = new DataManager();
        int Indx = 0;
        void PopulateTreeAccounts()
        {
         
            List<Db.AccountCategoriesRow> acctCategories = GetAllAccountCategories();

            try
            {
                TreeAccounts.Nodes.Clear();
                TreeAccounts.ImageList = imageList1;
                TreeAccounts.Nodes.Add("AbuEhab", "شجرة الحسابات", 0).ForeColor = Color.Red;
                TreeAccounts.Nodes["AbuEhab"].NodeFont = new System.Drawing.Font("Times New Roman", 10, FontStyle.Bold);

              foreach (var item in acctCategories)
                {
                    TreeAccounts.Nodes[0].Nodes.Add("", item.CategoryName, 1).ForeColor = Color.Blue;
                    List<Db.AccountsRow> Accts = GetAccountByCategId(item.ID);

                    foreach (Db.AccountsRow Actitem in Accts)
                    {
                        TreeAccounts.Nodes[0].Nodes[Indx].Nodes.Add("", Actitem.AccountName, 2).ForeColor = Color.Brown;
                    }
                    Indx++;
                }
            }
            catch (Exception)
            {
                
              
            }
        }
        private void FrmAccountsManager_Load(object sender, EventArgs e)
        {
        
            PopulateTreeAccounts(); ;
          
            //===============================
            DgvAccountDaily.Rows.Clear();

            
        }

        #region " ^^^ Methods "
        private static List<Db.AccountsRow> GetAllAccounts()
        {
            List<Db.AccountsRow> GetAll = (from a in DbManager.ShopData.Accounts select a).ToList();
            return GetAll;
        }

        public static List<Db.AccountsRow> GetAccountByCategId(int CatgId)
        {
            List<Db.AccountsRow> GetAll = (from a in DbManager.ShopData.Accounts
                                           where a.AccountCategoryID == CatgId 
                                           select a).ToList();
            return GetAll;
        }
        public static List<Db.AccountCategoriesRow> GetAllAccountCategories()
        {
            List<Db.AccountCategoriesRow> GetAll = (from a in DbManager.ShopData.AccountCategories select  a).ToList();
            return GetAll;
        }
        #endregion

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //==================================================================
            // Create Account
            Db.AccountsRow act = DbManager.ShopData.Accounts.NewAccountsRow();
            act.AccountName = txtAccountName.Text;
            act.Description = "Athers";
            act.AccountCategoryID = 9;
            DbManager.ShopData.Accounts.AddAccountsRow(act);
            DbManager.SaveChanges();
            FrmAccountsManager_Load(sender, e);
            //==================================================================
        }
    

        private void AccountCategoryBtn_Click(object sender, EventArgs e)
        {
           // static DataManager DbManager = new DataManager();
            //Db.AccountCategoriesRow rw = DbManager.ShopData.AccountCategories.NewAccountCategoriesRow();
            //rw.CategoryName = txtAccountName.Text ;
            //rw.Description = txtDescription.Text;
            //DbManager.ShopData.AccountCategories.AddAccountCategoriesRow(rw);
            //DbManager.SaveChanges();
            //FrmAccountsManager_Load(sender, e);
        }

        private void ExpandeAllBtn_Click(object sender, EventArgs e)
        {
            TreeAccounts.ExpandAll();
        }

        private void CollapseBtn_Click(object sender, EventArgs e)
        {
            TreeAccounts.CollapseAll();
        }

        private void FrishBtn_Click(object sender, EventArgs e)
        {
         FrmAccountsManager_Load( sender,  e);
        }
    }
}
