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
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();
            this.txtName.Text = "";
        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            this.txtName.Text = UsersCmd.CurrentUser.UserName;
            
        }

        private void SaveBtn_Click(object sender, EventArgs e){

            if (txtOldPass.Text == "" || txtOldPass .Text != UsersCmd .CurrentUser .UserPassword) 
            {

                return;
            }
            if (txtNewPass.Text == "") { return; }
     
            //=======================================================
            UsersCmd.CurrentUser.UserPassword = txtNewPass.Text;
            UsersCmd.EditUserPassword(UsersCmd.CurrentUser);
            this.Hide();
        }
        
           
        
    }
}
