using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Customers
{
    public  class CustomersCmd
    {

        static DataManager DbManager = new DataManager();

        public static bool NewCustomer(Db.CustomersRow cst)
        {
            Db.CustomersRow c = DbManager.ShopData.Customers.NewCustomersRow();
            c.CustomerName = cst.CustomerName;
            c.Address = cst.Address;
            c.Phone = cst.Phone;
            c.AccountID = cst.AccountID;

            DbManager.ShopData.Customers.AddCustomersRow(c);
            DbManager.SaveChanges();
            return true;
        }

        public static List<Db.CustomersRow> GetAllCustomers() {

            List<Db.CustomersRow> GetAll = (from c in DbManager.ShopData.Customers select c).ToList();
            return GetAll;
        }

        public static bool EditCustomer(Db.CustomersRow cst)
        {
            Db.CustomersRow c = DbManager.ShopData.Customers.Where(b => b.ID == cst.ID).Single();
            c.CustomerName = cst.CustomerName;
            c.Address = cst.Address;
            c.Phone = cst.Phone;
       
            DbManager.SaveChanges();
            return true;
        }
        public static Db.CustomersRow GetById (int cstid)
        {
            Db.CustomersRow c = DbManager.ShopData.Customers.Where(b => b.ID == cstid).Single();
            return c;
        }

        public static Db.CustomersRow GetByName(string cstname)
        {
            Db.CustomersRow c = DbManager.ShopData.Customers.Where(b => b.CustomerName == cstname ).Single();
            return c;
        }

    }
}
