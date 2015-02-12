﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Shop.Users
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }
        static DataManager DbManager = new DataManager();




        #region "    ^^^ Brwose Photo    "

        OpenFileDialog Op = new OpenFileDialog();
        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            Op = new OpenFileDialog();

            if (Op.ShowDialog() == DialogResult.OK)
            {
                this.Cursor = Cursors.WaitCursor;
                Op.Filter = "Image Files(*.png; *.jpg; *.bmp)|*.png; *.jpg; *.bmp";
                picLogo.Image = Image.FromFile(Op.FileName);
                this.Cursor = Cursors.Default;

                
                picLogo.Image.Save(Application.StartupPath + Op.SafeFileName, ImageFormat.Jpeg);
         

            }
        }

        #endregion

        #region "  ^^^^ Method      "
        private static bool EditOldInformation(Db.TheShopRow shptb)
        {
            Db.TheShopRow shp = DbManager.ShopData.TheShop.NewTheShopRow();

            shp = DbManager.ShopData.TheShop.Where(c => c.ID == shptb.ID).Single();
            if (shp.ID != 0)
            {

                shp.ShopName = shptb.ShopName;
                shp.Address = shptb.Address;
                shp.Phone = shptb.Phone;
                shp.LogoPath = shptb.LogoPath;
                DbManager.SaveChanges();
                return true; ;
            }
            return false;
        }
        #endregion

        private void SaveChangesBtn_Click(object sender, EventArgs e)
        {
            Db.TheShopRow tr = (from c in DbManager.ShopData.TheShop where c.ID == 1 select c).Single();

            Db.TheShopRow shp = DbManager.ShopData.TheShop.NewTheShopRow();

            if (tr.ID  == 0)
            {
                shp.ShopName = txtName.Text;
                shp.Address = txtAddress.Text;
                shp.Phone = txtPhone.Text;
                if (Op.FileName  != "") { shp.LogoPath = Op.FileName; }
                DbManager.ShopData.TheShop.AddTheShopRow(shp);
                DbManager.SaveChanges();
                Operation.ShowMassege("تــــم حـــــفظ التغيــــيرات", this);
          
            }
            else
            {
                shp = (from c in DbManager.ShopData.TheShop where c.ID == 1 select c).Single(); ;
                shp.ShopName = txtName.Text;
                shp.Address = txtAddress.Text;
                shp.Phone = txtPhone.Text;
                if (Op.FileName != "") { shp.LogoPath = Op.FileName; }
                EditOldInformation(shp);
                Operation.ShowMassege("تــــم حـــــفظ التغيــــيرات", this);
              
            }
        
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            try
            {
                 Db.TheShopRow tr = (from c in DbManager.ShopData.TheShop where c.ID == 1 select c).Single();
                 txtAddress.Text = tr.Address;
                 txtName.Text = tr.ShopName;
                 txtPhone.Text = tr.Phone;
                 if (File.Exists(tr.LogoPath) == true) { picLogo.Image =  Image .FromFile (tr.LogoPath); }
            }
            catch (Exception)
            {
                Operation.ShowMassege("لاتوجــــــــد بيانات خاصة ,,, يجب أدخالها لتظهر في التقارير والفواتير", this);
              
            }
        }

    }
}
