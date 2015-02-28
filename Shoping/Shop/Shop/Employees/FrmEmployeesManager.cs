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
            ClearTxt();
            PopulaetDgv();

        }
        static DataManager DbManager = new DataManager();

        public static List<Db.EmployeesRow> GetAllEmployees()
        {
            List<Db.EmployeesRow> GetAll = (from emp
                                            in DbManager.ShopData.Employees
                                            orderby emp.EmployeeName ascending
                                            select emp).ToList();
            return GetAll;
        }



        void PopulaetDgv()
        {
          
            List<Db.EmployeesRow> LstEmployeess = GetAllEmployees();
          
      
                DgvEmployees.Rows.Clear();
                foreach (var emp in LstEmployeess )
                {
                    DgvEmployees.Rows.Add(new string[] {emp.ID .ToString (),emp .EmployeeName ,emp.Address , emp.Phone , emp.Salary .ToString (), emp.StartWorkAt.ToString () , emp.AccountID .ToString ()                       
                    });
                }
                Styles.GridFullStyle(DgvEmployees);
        }
        private void FrmEmployeesManager_Load(object sender, EventArgs e)
        {
            ClearTxt();
            PopulaetDgv();
       
        }
       
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "") { Alert.Warning("أدخل الاسم للضــرورة"); return; }
            //============================================================
            Db.EmployeesRow emp = EmployeesCmd.GetByName(txtName.Text);
            Alert.Warning("موجــــود بالفـعل");
            ClearTxt(); return; 
            }
            catch (Exception)
            {
                //==================================================================
                // Create Account
                Db.AccountsRow EmpolyeeAct = DbManager.ShopData.Accounts.NewAccountsRow();
                EmpolyeeAct.AccountName = txtName.Text;
                EmpolyeeAct.Description = "Employee";
                EmpolyeeAct.AccountCategoryID = 4;
                DbManager.ShopData.Accounts.AddAccountsRow(EmpolyeeAct);
                DbManager.SaveChanges();
                //==================================================================
                Db.EmployeesRow emp = DbManager.ShopData.Employees.NewEmployeesRow();
                emp.EmployeeName = txtName.Text;
                emp.Address = txtAddess.Text;
                emp.Phone = txtPhone.Text;
                emp.StartWorkAt =(DateTime ) WorkPicker.Value ;
                emp.Salary = Convert.ToDouble (txtSalary.Text);
                emp.AccountID = EmpolyeeAct.ID;
                DbManager.ShopData.Employees.AddEmployeesRow(emp);
                DbManager.SaveChanges();
                Alert.Info("تــم الحــــــفظ بنجــاح");
         
                ClearTxt();
               // PopulaetDgv();
                FrmEmployeesManager_Load(sender, e);
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

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox.Text != "")
            {

                List<Db.EmployeesRow> LstEmployeess = (from c in EmployeesCmd.GetAllEmployees()
                                                       where c.EmployeeName.Contains(SearchBox.Text)
                                                       select c).ToList();


                DgvEmployees.Rows.Clear();
                foreach (var emp in LstEmployeess)
                {
                    DgvEmployees.Rows.Add(new string[] {emp.ID .ToString (),
                        emp .EmployeeName ,emp.Address , emp.Phone ,
                       emp.Salary .ToString (), emp.StartWorkAt.ToString () , emp.AccountID .ToString ()
                    });
                }
            }
            else
            {
                List<Db.EmployeesRow> LstEmployeess = EmployeesCmd.GetAllEmployees();
                DgvEmployees.Rows.Clear();
                foreach (var emp in LstEmployeess)
                {
                    DgvEmployees.Rows.Add(new string[] {emp.ID .ToString (),
                        emp .EmployeeName ,emp.Address , emp.Phone ,
                       emp.Salary .ToString (), emp.StartWorkAt.ToString () , emp.AccountID .ToString ()
                    });
                }
            }
        }

    }
}
