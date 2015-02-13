using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Accountant
{
    class CategoryCmd
    {
        static DataManager DbManager = new DataManager();
        public static bool NewCategory(Db.CategoriesRow catg)
        {
            Db.CategoriesRow r = DbManager.ShopData.Categories.NewCategoriesRow();
            r.CategoryName = catg.CategoryName;
            r.Description = catg.Description;
            DbManager.ShopData.Categories.AddCategoriesRow(r);
            DbManager.SaveChanges();
            return true;
        }
        public static List<Db.CategoriesRow> GetAllCategories()
        {
            List<Db.CategoriesRow> LstCategories = (from c in DbManager.ShopData.Categories select c).ToList();
            return LstCategories;
        }
        public static Db.CategoriesRow EditCategory(Db.CategoriesRow row)
        {
            Db.CategoriesRow rw = DbManager.ShopData.Categories.NewCategoriesRow();
            rw = (from c in DbManager.ShopData.Categories where c.ID == row.ID select c).Single();
            rw.CategoryName = row.CategoryName;
            rw.Description = row.Description;
            DbManager.SaveChanges ();
            return rw;
        }

        public static Db.CategoriesRow GetByID(int XID)
        {
            Db.CategoriesRow rw = (from c in DbManager.ShopData.Categories where c.ID == XID select c).Single();
            return rw;
        }
        public static Db.CategoriesRow DeeleteCategory(int XID)
        {
            Db.CategoriesRow rw = (from c in DbManager.ShopData.Categories where c.ID == XID select c).Single();
            DbManager.ShopData.Categories.RemoveCategoriesRow(rw);
            DbManager.SaveChanges();
            return rw;
        }
        public static List<Db.ProductsRow> GetAllProducts()
        {
            List<Db.ProductsRow> GetAll = (from p in DbManager.ShopData.Products select p).ToList();
            return GetAll;
        }

        public static List<Db.ProductsRow> GetAllProductsByCategoryID(int CATGID)
        {
            List<Db.ProductsRow> GetAll = (from p in DbManager.ShopData.Products 
                                           where p.CategoryID == CATGID 
                                           select p).ToList();
            return GetAll;
        }


        public static Db.ProductsRow RemoveProduct(int prdid)
        {
            Db.ProductsRow rw = (from p in DbManager.ShopData.Products where p.ID == prdid select p).Single();
            DbManager.ShopData.Products.RemoveProductsRow(rw);
            DbManager.SaveChanges();
            return rw;
        }
        public static Db.ProductsRow GetProductById(int prdid)
        {
            Db.ProductsRow GetOne = (from p in DbManager.ShopData.Products where p.ID == prdid select p).Single();
            return GetOne;
        }
    }
}
