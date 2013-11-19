using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace NorthwindClient
{
    public class LINQCustomMethods
    {
        public static void FindCustomerByOrderAndShippingDestination(int year, string destinationCountry)
        {
            using(new UnitOfWorkScope(true))
            {
                var customers =
                      from customer in UnitOfWorkScope.NorthwindContext.Customers
                      join order in UnitOfWorkScope.NorthwindContext.Orders
                      on customer.CustomerID equals order.CustomerID
                      where customer.Country == destinationCountry
                      select customer;

                foreach (var customer in customers.Distinct())
                {
                    Console.WriteLine(customer.ContactName);
                }
            }
        }

        public static void FindSalesByRegionAndPeriod(string region, DateTime startDate, DateTime endDate)
        {
            if (endDate < startDate)
            {
                throw new ArgumentException(String.Format("End date must be after the start date!"));
            }

            using(new UnitOfWorkScope(true))
            {
                var sales =
                    from currSale in UnitOfWorkScope.NorthwindContext.Orders
                    where (currSale.OrderDate >= startDate && currSale.OrderDate <= endDate 
                        && currSale.ShipRegion == region)

                    select currSale;

                foreach (var sale in sales)
                {
                    Console.WriteLine(sale.ShipName);
                }
            }
        }
    }
}
