using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shop.Users;
namespace Shop.Users
{
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                      Db.UsersRow User = ( from u in  UsersCmd.GetAllUsers()
                                     where  u.UserName == txtName .Text 
                                         && u.UserPassword == txtPassword .Text 
                                         select u).Single ();
                MainForm frm = new MainForm ();
                UsersCmd .CurrentUser = User ;
                frm.Show ();
                this .Hide ();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                
            }
        }
    }
}
