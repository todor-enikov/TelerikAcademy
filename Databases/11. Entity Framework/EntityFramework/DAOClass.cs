using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.Data;

namespace EntityFramework
{
    public class DAOClass
    {
        private static NorthwindEntitity GetDatabase()
        {
            var db = new NorthwindEntitity();
            return db;
        }

        public static void InsertingCustomer(string customerID, string companyName)
        {
            var db = GetDatabase();
            var customer = new Customer();
            customer.CustomerID = customerID;
            customer.CompanyName = companyName;
            db.Customers.Add(customer);
            db.SaveChanges();
            Console.WriteLine("You successfully added a customer!");
        }

        public static void ModifyingCustomer(string customerId, string nameToModify)
        {
            var db = GetDatabase();
            var customer = db.Customers
                            .FirstOrDefault(c => c.CustomerID == customerId);
            customer.CompanyName = nameToModify;
            db.SaveChanges();
            Console.WriteLine("You successfully modified a customer!");
        }

        public static void DeletingCustomer(string customerId)
        {
            var db = GetDatabase();
            var customer = db.Customers
                .FirstOrDefault(c => c.CustomerID == customerId);
            db.Customers.Remove(customer);
            db.SaveChanges();
            Console.WriteLine("You successfully deleted a customer!");
        }

        public static void FindingAllCustomersByGivenParameters(int year, string country)
        {
            var db = GetDatabase();
            var customers = db.Orders
                              .Where(o => o.OrderDate.Value.Year == year && o.ShipCountry == country)
                              .Distinct()
                              .ToList();
            Console.WriteLine("Customers with NativeSQL, OrderYear: {0}, Country: {1}", year, country);
            foreach (var customer in customers)
            {
                Console.WriteLine("Name: {0}", customer.Customer.CompanyName);
            }
        }

        public static void FindingAllCustomersByGivenParameterWithNativeSQL(int year, string country)
        {
            string sqlQuery = @"SELECT * FROM Customers c 
                                JOIN Orders o 
                                    ON c.CustomerID = o.CustomerID 
                               WHERE YEAR(o.OrderDate) = '{0}' AND o.ShipCountry = '{1}'";
            string query = string.Format(sqlQuery, year, country);
            var db = GetDatabase();
            var customers = db.Customers
                              .SqlQuery(query)
                              .Distinct()
                              .ToList();
            Console.WriteLine("Customers with NativeSQL, OrderYear: {0}, Country: {1}", year, country);
            foreach (var customer in customers)
            {
                Console.WriteLine("Name: {0}", customer.CompanyName);
            }
        }

        public static void FindingAllSalesByGivenParameter(string shipRegion, DateTime start, DateTime end)
        {
            var db = GetDatabase();
            var sales = db.Orders
                        .Where(o => o.ShipRegion == shipRegion && (o.OrderDate >= start || end >= o.OrderDate))
                        .ToList();
            foreach (var sale in sales)
            {
                Console.WriteLine("Name of ship: {0} name of ship city: {1} and it is ordered on {2}", sale.ShipName, sale.ShipCity,sale.OrderDate);
            }
        }
    }
}
