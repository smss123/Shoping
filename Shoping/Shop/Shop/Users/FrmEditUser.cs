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
    public partial class FrmEditUser : Form
    {
        public FrmEditUser()
        {
            InitializeComponent();
        }

        static DataManager DbManager = new DataManager();
        public Db.UsersRow  TargetUser { get; set; }
        private void FrmEditUser_Load(object sender, EventArgs e)
        {
            txtName.Text = TargetUser.UserName.ToString ();
            txtPassword.Text = TargetUser.UserPassword.ToString ();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
        
            TargetUser.UserName = txtName.Text;
            TargetUser.UserPassword = txtPassword.Text;
            UsersCmd.EditUser(TargetUser);
            MessageBox.Show("Done...");
            this.Hide();
        }
    }
}
