using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Employees
{
   public  class EmployeesCmd
    {
       static DataManager DbManager = new DataManager();

       #region "  Searching Data     "
       public static List<Db.EmployeesRow> GetAllEmployees()
       {
           List<Db.EmployeesRow> GetAll = (from emp 
                                           in DbManager.ShopData.Employees
                                           orderby emp .EmployeeName ascending 
                                           select emp).ToList();
           return GetAll;
       }

       public static Db.EmployeesRow GetById(int xid)
       {
           Db.EmployeesRow rw = (from emp 
                                 in DbManager.ShopData.Employees
                                 where emp.ID == xid
                                 select emp).Single();
           return rw;
       }
       public static Db.EmployeesRow GetByName(string empname)
       {
           Db.EmployeesRow rw = (from emp 
                                 in DbManager.ShopData.Employees
                                 where emp.EmployeeName == empname 
                                 select emp).Single();
           return rw;
       }

       #endregion


       public static bool  EditEmployee(Db.EmployeesRow emptb ){
         Db.EmployeesRow   emp = DbManager.ShopData.Employees.Where(ep => ep.ID == emptb.ID).Single();
         emp.EmployeeName = emptb.EmployeeName;
         emp.Address = emptb.Address;
         emp.Phone = emptb.Phone;
         emp.Salary = Convert.ToDouble(emptb.Salary);
         emp.StartWorkAt = (DateTime)emptb.StartWorkAt;
         DbManager.SaveChanges();
         return true ;

       }
       public static Db.EmployeesRow DeleteEmployee(Db.EmployeesRow emptb)
       {
           Db.EmployeesRow emp = DbManager.ShopData.Employees.Where(ep => ep.ID == emptb.ID).Single();
           DbManager.ShopData.Employees.RemoveEmployeesRow(emp);
           DbManager.SaveChanges();
           return emp;

       }
    }
}
