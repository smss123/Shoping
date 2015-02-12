using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace Shop.Employees
{
    public partial class FrmEmployeesManager : Form
    {
        public FrmEmployeesManager()
        {
            InitializeComponent();
        }

        private void FreishBtn_Click(object sender, EventArgs e)
        {
            FrmEmployeesManager_Load(sender, e);

        }

        void PopulaetDgv()
        {
            List<Db.EmployeesRow> LstEmployeess = EmployeesCmd.GetAllEmployees();
          
      
                DgvEmployees.Rows.Clear();
                foreach (var emp in LstEmployeess )
                {
                    DgvEmployees.Rows.Add(new string[] {emp.ID .ToString (),
                        emp .EmployeeName ,emp.Address , emp.Phone ,
                       emp.Salary .ToString (), emp.StartWorkAt.ToString () , emp.AccountID .ToString ()
                    });
                }
           
        }
        private void FrmEmployeesManager_Load(object sender, EventArgs e)
        {
           
            PopulaetDgv();
       
        }
        static DataManager DbManager = new DataManager();
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
            if (txtName.Text == "") { MessageBox.Show("أدخل الاسم للضــرورة"); return;  }
            //============================================================
            Db.EmployeesRow emp = EmployeesCmd.GetByName(txtName.Text);
            MessageBox.Show("موجــــود بالفـعل");
            ClearTxt(); return; 
            }
            catch (Exception)
            {
                //==================================================================
                // Create Account
                Db.AccountsRow act = DbManager.ShopData.Accounts.NewAccountsRow();
                act.AccountName = txtName.Text;
                act.Description = "Employee";
                act.AccountCategoryID = 3;
                DbManager.ShopData.Accounts.AddAccountsRow(act);
                DbManager.SaveChanges();
                //==================================================================
                Db.EmployeesRow emp = DbManager.ShopData.Employees.NewEmployeesRow();
                emp.EmployeeName = txtName.Text;
                emp.Address = txtAddess.Text;
                emp.Phone = txtPhone.Text;
                emp.StartWorkAt =(DateTime ) WorkPicker.Value ;
                emp.Salary = Convert.ToDouble (txtSalary.Text);
                emp.AccountID = act.ID;
                DbManager.ShopData.Employees.AddEmployeesRow(emp);
                DbManager.SaveChanges();
                MessageBox.Show("تــم الحــــــفظ بنجــاح");
                ClearTxt();
                PopulaetDgv();
                //FrmEmployeesManager_Load(sender, e);
            }
        }
        void ClearTxt()
        {
            txtAddess.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtSalary.Text = "";
            SearchBox.Text = "";
            txtName.Focus();
        }

        private void DgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int col = this.DgvEmployees.CurrentCell.ColumnIndex;
            // int row = this.DgvUsers.CurrentCell.RowIndex;

            Db.EmployeesRow  rw = EmployeesCmd.GetById(int.Parse(DgvEmployees.CurrentRow.Cells[0].Value.ToString()));
            if (col.ToString() == "7")
            {
                FrmEditEmployee frm = new FrmEditEmployee();

                frm.TargetEmployee = rw;
                frm.ShowDialog();
            }

            if (col.ToString() == "8")
            {
                EmployeesCmd.DeleteEmployee(rw);
                FrmEmployeesManager_Load(sender, e);
            }
        }

    }
}
