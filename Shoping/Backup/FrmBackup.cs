using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Shop.Backup
{
    public partial class FrmBackup : Form
    {
        public FrmBackup()
        {
            InitializeComponent();
        }
        public bool ChkPath { get; set; }
        private void RestoreBtn_Click(object sender, EventArgs e)
        {

        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {

            StartCreateBackup();
        }

        private void FrmBackup_Load(object sender, EventArgs e)
        {
            ChkPath = false;
            GoCheckPath();
            if (ChkPath == false) { GoCreateDirctoy(); }
        }

        void GoCheckPath()
        {
            if (Directory.Exists(@"E:\\ShopDataBase") == false)
            {
                ChkPath = false;
            }
            else
            {
                ChkPath = true;
            }
        }
        OpenFileDialog OP = new OpenFileDialog();
        void StartCreateBackup()
        {
            OP.ShowDialog();
            File.Copy(@"E:\\ShopDataBase\ShopData.xml", OP.FileName, true);
            MessageBox.Show("Done");
        }

        void GoCreateDirctoy()
        {
            Directory.CreateDirectory(@"E:\\ShopDataBase");
            File.Create(@"E:\\ShopDataBase\ShopData.xml");
            MessageBox.Show("تــــــم إنشــــاء مجـــلد جديد");
         
        }


        
    }
}
