using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Accountant
{
    public class ProductItemesCmd
    {
        static DataManager DbManager = new DataManager();

        public static List<Db.ProductItemsRow> GetAllItems()
        {
            List<Db.ProductItemsRow> GetAll = ( from i in DbManager .ShopData .ProductItems select i ).ToList ();
            return GetAll ;
        }

        public static List<Db.ProductItemsRow> GetAllItemsByProductID(int PRDID)
        {
            List<Db.ProductItemsRow> GetAll = (from i in DbManager.ShopData.ProductItems 
                                               where i.ProductID == PRDID 
                                               select i).ToList();
            return GetAll;
        }
        public static List<Db.ProductItemsRow> GetAllItemsBySupplierID(int SupplID)
        {
            List<Db.ProductItemsRow> GetAll = (from i in DbManager.ShopData.ProductItems
                                               where i.SupplierID  == SupplID
                                               select i).ToList();
            return GetAll;
        }

        public static Db.ProductItemsRow ItemsByID(int ItmID)
        {
           Db.ProductItemsRow GetOne = (from i in DbManager.ShopData.ProductItems
                                               where i.ID == ItmID 
                                               select i).SingleOrDefault ();
            return GetOne;
        }
        public static Db.ProductItemsRow ItemsByName(string ItmName)
        {
            Db.ProductItemsRow GetOne = (from i in DbManager.ShopData.ProductItems
                                         where i.ItemName == ItmName 
                                         select i).SingleOrDefault();
            return GetOne;
        }


    }
}
