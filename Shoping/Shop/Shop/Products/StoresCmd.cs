using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Accountant
{
   public  class StoresCmd
    {
       static DataManager DbManager = new DataManager();


       public static List<Db.MainStoreRow> GetAllStaores()
       {
           List<Db.MainStoreRow> StoresLst = (from s in DbManager.ShopData.MainStore select s).ToList();
           return StoresLst;
       }

       public static Db.MainStoreRow GetByID(int SorID)
       {
           Db.MainStoreRow rw = DbManager.ShopData.MainStore.Where(s => s.ID == SorID).Single();
           return rw;
       }

       public static Db.MainStoreRow GetByProductID(int PrdID)
       {
           Db.MainStoreRow rw = ( from s in DbManager .ShopData .MainStore where 
                                      s.ProductID  == PrdID select s ).Single();
           return rw;
       }


       public static bool EditStore(Db.MainStoreRow stor , int PrdID)
       {
           Db.MainStoreRow rw = DbManager.ShopData.MainStore.NewMainStoreRow();
           rw = DbManager.ShopData.MainStore.Where(s => s.ID == stor.ID && s.ProductID == PrdID ).Single();
           rw.ProductID = stor.ProductID;
     
           rw.Status = stor.Status;
      
           DbManager.SaveChanges();
           return true;
       }

       public static List<Db.ItemesStoreRow> GetAllByItemId(int ItmiD)
       {
           List<Db.ItemesStoreRow> GetAll = (from i in DbManager.ShopData.ItemesStore
                                             where i.ItemID == ItmiD select i).ToList();
           return GetAll;
       }

       public static Db.ItemesStoreRow GetByItemId(int ItmiD)
       {
          Db.ItemesStoreRow GetOne = (from i in DbManager.ShopData.ItemesStore
                                             where i.ItemID == ItmiD
                                             select i).Single ();
           return GetOne;
       }

       public static List<Db.ItemesStoreRow> GetAllItems()
       {
           List<Db.ItemesStoreRow> GetAll = (from i in DbManager.ShopData.ItemesStore
                                             select i).ToList();
           return GetAll;
       }
    }
}