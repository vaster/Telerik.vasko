using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure; // Northwind.Data
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace NorthwindClient
{
    internal class Tester
    {
        static void Main(string[] args)
        {
            // task 2

            // DataAccessor.InsertCustomer("Appee","Apple3");
            // DataAccessor.Delete("Appee");
            // Dictionary<CustomerProperty, string> changesToMake =
            //   new Dictionary<CustomerProperty, string>();
            // string country = "USA";
            // changesToMake.Add(CustomerProperty.Country,country);
            // DataAccessor.Modify("Apple",changesToMake);

            // task 3

            // int year = 1997;
            // string country = "Canada";
            // LINQCustomMethods.FindCustomerByOrderAndShippingDestination(year, country);

            // task 5

            // DateTime startDate = new DateTime(1996,1,1);
            // DateTime endDate = new DateTime(1997,1,1);
            // string region = "RJ";
            // LINQCustomMethods.FindSalesByRegionAndPeriod(region,startDate,endDate);



            // task 6

            // IObjectContextAdapter context = new northwindEntities();
            // string cloneNorthwind = context.ObjectContext.CreateDatabaseScript(); // the string can be saved as sqlscript and ran in a database server
                                                                                  //    for restoring the database. Alt. is to use the EF model and generate a new DB from it.


            // task 7 

            // By default EF uses no concurrency control (last write wins) which allows lost updates.
            // I have't be able to reproduce a scenario when concurency exception is thrown (not sure how to),
            //      but to prevent data lost, a possible way is to write a UnitOfWorkScope class, wich is smart enough to
            //      make autosave for its scope.
            //      example 
            //             using(new UnitOfWorkScope(true))
            //              {
            //                  some changes...
            //              }<- at the end of the scope, it performes .SaveChanges(), hidden, its part of its logic
            //      so it will prevent the data loss, also a nesting of dbContexts will cause an exception.
        }
    }
}
