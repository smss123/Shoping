using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shop.Employees
{
    public partial class FrmEditEmployee : Form
    {
        public FrmEditEmployee()
        {
            InitializeComponent();
        }

        static DataManager DbManager = new DataManager();
        public Db.EmployeesRow TargetEmployee  { get; set; }

        private void FrmEditEmployee_Load(object sender, EventArgs e)
        {
            txtName.Text = TargetEmployee.EmployeeName;
            txtAddess.Text = TargetEmployee.Address;
            txtPhone.Text  = TargetEmployee.Phone;
            txtSalary.Text = TargetEmployee.Salary.ToString();
            WorkPicker.Value  = (DateTime)TargetEmployee.StartWorkAt;

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "") { MessageBox.Show("أدخل الاسم للضــرورة"); return; }
            //============================================================
      

           TargetEmployee.EmployeeName=  txtName.Text  ;
           TargetEmployee.Address=   txtAddess.Text;
           TargetEmployee.Phone= txtPhone.Text ;
           TargetEmployee.Salary= Convert.ToDouble ( txtSalary.Text);
           TargetEmployee.StartWorkAt = (DateTime)WorkPicker.Value;
            EmployeesCmd.EditEmployee(TargetEmployee);
            this.Hide();
        }


    }
}
