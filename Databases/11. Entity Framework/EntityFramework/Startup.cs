using EntityFramework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class Startup
    {
        public static void Main()
        {
            //Please run the methods separately to view the difference in the database :)
            //task 1 and 2
            //DAOClass.InsertingCustomer("bacho", "Chorbata na baba");
            //DAOClass.ModifyingCustomer("bacho", "e mnogo hubava");
            //DAOClass.DeletingCustomer("bacho");

            //task3
            //DAOClass.FindingAllCustomersByGivenParameters(1997, "Canada");

            //task4
            //DAOClass.FindingAllCustomersByGivenParameterWithNativeSQL(1997, "Canada");

            //task5
            DAOClass.FindingAllSalesByGivenParameter("BC", new DateTime(1996, 6, 1), new DateTime(2000, 6, 1));

            //task 6
            //If you want to create a database called NorthwindTwin you should go to the entity schema
            //of the project. You must wight-click the mouse and to press Generate Database From a Model
            //and you should continue with the next steps....
            //task 7
            //It will throw exception, because it is enough to make only one time db.SaveChanges()

        }
    }
}
