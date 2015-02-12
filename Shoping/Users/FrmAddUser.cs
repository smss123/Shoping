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
    public partial class FrmAddUser : Form
    {
        public FrmAddUser()
        {
            InitializeComponent();
        }
   
        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            ClearTxt();
        }
        static DataManager DbManager = new DataManager();
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Db.UsersRow usr = (from u in UsersCmd.GetAllUsers() 
                                  where u.UserName == txtName.Text select u).Single();
                MessageBox.Show("موجـود من قبـــــل");
                ClearTxt();
                return;
            }
            catch (Exception)
            {
                
            Db.UsersRow r = DbManager.ShopData.Users.NewUsersRow();
            r.UserName = txtName.Text;
            r.UserPassword = txtPassword.Text;
            UsersCmd.NewUser(r);
            
           MessageBox .Show  ("تــم الحــــــفظ بنجــاح");
           ClearTxt();
            }
          
        }

        void ClearTxt()
        {
            txtName.Text = ""; txtPassword.Text = "";
            txtName.Focus();
        }

    }
}
