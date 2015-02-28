using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shop.Users
{
    public partial class FrmUsersManager : Form
    {
        public FrmUsersManager()
        {
            InitializeComponent();
        }
       
        private void FrmUsersManager_Load(object sender, EventArgs e)
        {
          var lst = UsersCmd.GetAllUsers();
          DgvUsers.Rows.Clear();
          foreach (var item in lst)
          {
              DgvUsers.Rows.Add(new string[] { item.ID.ToString(), item.UserName });
          }


          DgvUsers.RowHeadersWidth = 70;
          DgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
          DgvUsers.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
          DgvUsers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


          foreach (DataGridViewRow R in DgvUsers.Rows)
          {
              R.HeaderCell.Value = (R.Index + 1).ToString();

          }

        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            FrmAddUser frm = new FrmAddUser();
            frm.ShowDialog();
        }

        private void FrishBtn_Click(object sender, EventArgs e)
        {
            FrmUsersManager_Load(sender, e);
        }

        private void DgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          

              int col = this.DgvUsers.CurrentCell.ColumnIndex;
             // int row = this.DgvUsers.CurrentCell.RowIndex;

              Db.UsersRow rw =  UsersCmd.GetById(int.Parse(DgvUsers.CurrentRow.Cells[0].Value.ToString()));
              if (col.ToString() == "2")
              {
                  FrmEditUser frm = new FrmEditUser();
                
                  frm.TargetUser = rw;
                  frm.ShowDialog();
              }

              if (col.ToString() == "3")
              {
                  UsersCmd.DeleteUser(rw);
                  FrmUsersManager_Load(sender, e);
              }
      }

        private void ChangePassBtn_Click(object sender, EventArgs e)
        {
            FrmChangePassword frm = new FrmChangePassword();
            frm.ShowDialog();
        }











                    
                 

        //}
    }
}
