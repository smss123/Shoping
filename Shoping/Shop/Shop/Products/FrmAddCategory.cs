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
    public partial class FrmAddCategory : Form
    {
        public FrmAddCategory()
        {
            InitializeComponent();
        }
        static DataManager DbManager = new DataManager();
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Db.CategoriesRow r = DbManager.ShopData.Categories.NewCategoriesRow();
            r.Description = txtDescription.Text;
            r.CategoryName = txtCategoryName.Text;
            CategoryCmd.NewCategory(r);
            Alert.Info ("تـــــــم الحـــــــــفظ" );
            FrmAddCategory_Load( sender,  e);
        }
     
        void PopulateTree()
        {
            treeView1.Nodes.Clear();
            DgvCategories.Rows.Clear();
            var LstCategories = CategoryCmd .GetAllCategories ();
            treeView1.ImageList = imageList1;
            treeView1.Nodes.Add("", "التصنيفات", 0);
            int i = 0;
            foreach (var Catg in LstCategories )
            {
                treeView1.Nodes[0].Nodes.Add("", Catg.CategoryName, 1);
              List <  Db.ProductsRow> LstProd = (from p in DbManager.ShopData.Products where p.CategoryID == Catg.ID select p).ToList();
              foreach (var Prd in LstProd  )
              {
                  treeView1.Nodes [0].Nodes[i].Nodes.Add("", Prd.ProductName , 2);
              }


                i++;
                DgvCategories.Rows.Add(new string[] {Catg .ID .ToString (),Catg .CategoryName  });
            }

            DgvCategories.RowHeadersWidth = 70;
            DgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvCategories.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvCategories.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            foreach (DataGridViewRow R in DgvCategories.Rows)
            {
                R.HeaderCell.Value = (R.Index + 1).ToString();

            }

        }
        private void FrmAddCategory_Load(object sender, EventArgs e)
        {
            GroupEdit.Enabled = false;
            GroupAdd.Enabled = true;
            ClearTxt();
            PopulateTree();
      
        }

        private void ExpanedAllBtn_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void CollapseAllBtn_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }
        public Db.CategoriesRow  TargetCategory { get; set; }
        private void DgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = this.DgvCategories.CurrentCell.ColumnIndex;
            // int row = this.DgvUsers.CurrentCell.RowIndex;
            if (col.ToString() == "2")
            {
               
                CategoryCmd.DeeleteCategory (int.Parse(DgvCategories.CurrentRow.Cells[0].Value.ToString()));
                FrmAddCategory_Load(sender, e);
            }
            if (col.ToString() == "3")
            {
                GroupAdd.Enabled = false; ;
                GroupEdit.Enabled = true;

               Db.CategoriesRow tb =  CategoryCmd.GetByID (int.Parse(DgvCategories.CurrentRow.Cells[0].Value.ToString()));
               txtEditName.Text = tb.CategoryName;
               txtEditDescription.Text = tb.Description;
               txtEditName.Focus();
               TargetCategory = tb;
            }

        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            TargetCategory.CategoryName = txtEditName.Text;
            TargetCategory.Description = txtEditDescription.Text;
            CategoryCmd.EditCategory(TargetCategory);
            ClearTxt();
            FrmAddCategory_Load(sender, e);
        }
        void ClearTxt()
        {
            txtEditName.Text = ""; txtEditDescription.Text = ""; txtCategoryName.Text = ""; txtDescription.Text = ""; txtCategoryName.Focus();
        }
    }
}
