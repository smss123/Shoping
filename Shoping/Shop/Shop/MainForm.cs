
using Shop.Accountant;
using Shop.Backup;
using Shop.Customers;
using Shop.Employees;
using Shop.Products;
using Shop.Sells;
using Shop.Suppliers;
using Shop.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Shop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
       
        private void UsersBtn_Click(object sender, EventArgs e)
        {
            FrmUsersManager frm = new FrmUsersManager();
            frm.ShowDialog();
        }


        private void SetBalloonTip()
        {
            notifyIcon1.Icon = SystemIcons.Information;            
            notifyIcon1.BalloonTipTitle = "Shop";
            notifyIcon1.BalloonTipText = "Powered By :  Abu Ehab  2015";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;           
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(3000);
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
        
          SetBalloonTip();
          CreateAccountCategories();               
        }

        private void SuppliersBtn_Click(object sender, EventArgs e)
        {
            FrmSuppliersManager frm = new FrmSuppliersManager();
            frm.ShowDialog();
        }

        private void AccountsBtn_Click(object sender, EventArgs e)
        {
            FrmAccountsManager frm = new FrmAccountsManager();
            frm.ShowDialog();
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DatabaseBtn_Click(object sender, EventArgs e)
        {
            FrmBackup frm = new FrmBackup();
            frm.ShowDialog();
        }

        private void EmployeesBtn_Click(object sender, EventArgs e)
        {
            FrmEmployeesManager frm = new FrmEmployeesManager();
            frm.ShowDialog ();
           
        }
        static DataManager DbManager = new DataManager();
        void CreateAccountCategories()
        {
            List<string> LstCategoriestName = new List<string>();
            LstCategoriestName.AddRange(new string[] { "الصندوق", "الموردين", "العملاء", "العمال", "حسابات أخرى" });
      
            //===============================================================================
            List<string> LstCategoriesDescription= new List<string>();
            LstCategoriesDescription.AddRange(new string[] { "الصندوق", "الموردين", "العملاء", "العمال", "حسابات أخرى" });
         
            //===============================================================================
            int count = (from c in DbManager.ShopData.AccountCategories select c.ID).Count();
            if (count == 0)
            {

                for (int i = 0; i <= 4; i++)
                {
                Db.AccountCategoriesRow rw =DbManager.ShopData.AccountCategories.NewAccountCategoriesRow();
                rw.CategoryName = LstCategoriestName[i];
                rw.Description = LstCategoriesDescription[i];
                DbManager.ShopData.AccountCategories.AddAccountCategoriesRow(rw);
                DbManager.SaveChanges();
                }
            }
          
         
        }

        private void ShopBtn_Click(object sender, EventArgs e)
        {
            FrmHome frm = new FrmHome();
            frm.ShowDialog();
        }

        private void StartTableBtn_Click(object sender, EventArgs e)
        {
            FrmStartingWork frm = new FrmStartingWork();
            frm.ShowDialog();
        }

        private void AddCategoriesBtn_Click(object sender, EventArgs e)
        {
            FrmProductsManager frm = new FrmProductsManager();
            frm.ShowDialog();
        }

        private void AddNewProductsBtn_Click(object sender, EventArgs e)
        {
            FrmAddCategory frm = new FrmAddCategory();
            frm.ShowDialog();
        }

        private void CustomersBtn_Click(object sender, EventArgs e)
        {
            FrmCustomersManager frm = new FrmCustomersManager();
            frm.ShowDialog(); frm = new FrmCustomersManager();
          
        }

        private void DailyBtn_Click(object sender, EventArgs e)
        {
            FrmAccountDaily frm = new FrmAccountDaily();
            frm.ShowDialog();
        }

        private void SellManagerBtn_Click(object sender, EventArgs e)
        {
            FrmSellManager frm = new FrmSellManager();
            frm.ShowDialog();
        }

        private void InvoicesBtn_Click(object sender, EventArgs e)
        {
            FrmSellsInvoices frm = new FrmSellsInvoices();
            frm.ShowDialog();
        }

        private void ProductItemsBtn_Click(object sender, EventArgs e)
        {
            FrmProductItems frm = new FrmProductItems();
            frm.ShowDialog();
        }

        
    }
}
