using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Users
{
   public  class UsersCmd
    {
      static  DataManager DbManager = new DataManager();
      public static Db.UsersRow CurrentUser;
      public static bool NewUser(Db.UsersRow Usr)
      {
          Db.UsersRow Rw = DbManager .ShopData .Users .NewUsersRow ();
          Rw.UserName = Usr.UserName;
          Rw.UserPassword = Usr.UserPassword;
          DbManager.ShopData.Users.AddUsersRow(Rw);
          DbManager.SaveChanges();
          return true;
      }
      public static List<Db.UsersRow> GetAllUsers()
      {
          var lst = (from u in DbManager.ShopData.Users select u).ToList();
          return lst;
      }
      public static Db.UsersRow GetById(int xid)
      {
          Db.UsersRow rw = (from u in DbManager.ShopData.Users where u.ID == xid select u).Single();
          return rw;
      }

      public static bool EditUser(Db.UsersRow Usr)
      {
          Db.UsersRow Rw = DbManager.ShopData.Users.NewUsersRow();
         Rw = (from u in DbManager.ShopData.Users where u.ID == Usr .ID  select u).Single();
         
          Rw.UserName = Usr.UserName;
          Rw.UserPassword = Usr.UserPassword;

          DbManager.SaveChanges();
          return true;
      }
      public static bool DeleteUser(Db.UsersRow Usr)
      {
          Db.UsersRow Rw = DbManager.ShopData.Users.NewUsersRow();
          Rw = (from u in DbManager.ShopData.Users where u.ID == Usr.ID select u).Single();
          DbManager.ShopData.Users.RemoveUsersRow(Rw);

          DbManager.SaveChanges();
          return true;
      }
      public static bool EditUserPassword(Db.UsersRow Usr)
      {
          Db.UsersRow Rw = DbManager.ShopData.Users.NewUsersRow();
          Rw = (from u in DbManager.ShopData.Users where u.ID == Usr.ID select u).Single();

       
          Rw.UserPassword = Usr.UserPassword;

          DbManager.SaveChanges();
          return true;
      }

    }
}
