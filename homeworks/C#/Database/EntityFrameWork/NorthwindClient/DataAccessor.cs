using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace NorthwindClient
{
    public class DataAccessor
    {
        public DataAccessor()
        {
        }

        public static void InsertCustomer(
            string id,
            string companyName,
            string contactName = null,
            string contactTitle = null,
            string address = null,
            string city = null,
            string region = null,
            string postalCode = null,
            string country = null,
            string phone = null,
            string fax = null
            )
        {
            using (new UnitOfWorkScope(true))
            {
                Customer customer = new Customer();
                customer.CustomerID = id;
                customer.CompanyName = companyName;
                customer.ContactName = contactName;
                customer.ContactTitle = contactTitle;
                customer.Address = address;
                customer.City = city;
                customer.Region = region;
                customer.PostalCode = postalCode;
                customer.Country = country;
                customer.Phone = phone;
                customer.Fax = fax;

                UnitOfWorkScope.NorthwindContext.Customers.Add(customer);
            }
        }

        public static void Modify(string id, Dictionary<CustomerProperty, string> propertiesToChange)
        {

            using (new UnitOfWorkScope(true))
            {
                var forModify = UnitOfWorkScope.NorthwindContext.Customers.Find(id);

                if (propertiesToChange.ContainsKey(CustomerProperty.Address))
                {
                    forModify.Address = propertiesToChange[CustomerProperty.Address];
                }
                if (propertiesToChange.ContainsKey(CustomerProperty.City))
                {
                    forModify.City = propertiesToChange[CustomerProperty.City];
                }
                if (propertiesToChange.ContainsKey(CustomerProperty.CompanyName))
                {
                    forModify.CompanyName = propertiesToChange[CustomerProperty.CompanyName];
                }
                if (propertiesToChange.ContainsKey(CustomerProperty.ContactName))
                {
                    forModify.ContactName = propertiesToChange[CustomerProperty.ContactName];
                }
                if (propertiesToChange.ContainsKey(CustomerProperty.ContactTitle))
                {
                    forModify.ContactTitle = propertiesToChange[CustomerProperty.ContactTitle];
                }
                if (propertiesToChange.ContainsKey(CustomerProperty.Country))
                {
                    forModify.Country = propertiesToChange[CustomerProperty.Country];
                }
                if (propertiesToChange.ContainsKey(CustomerProperty.Fax))
                {
                    forModify.Fax = propertiesToChange[CustomerProperty.Fax];
                }
                if (propertiesToChange.ContainsKey(CustomerProperty.Phone))
                {
                    forModify.Phone = propertiesToChange[CustomerProperty.Phone];
                }
                if (propertiesToChange.ContainsKey(CustomerProperty.PostalCode))
                {
                    forModify.PostalCode = propertiesToChange[CustomerProperty.PostalCode];
                }
                if (propertiesToChange.ContainsKey(CustomerProperty.Region))
                {
                    forModify.Region = propertiesToChange[CustomerProperty.Region];
                }
            }
        }

        public static void Delete(string id)
        {
            using (new UnitOfWorkScope(true))
            {
                var forDelete = UnitOfWorkScope.NorthwindContext.Customers.Find(id);

                UnitOfWorkScope.NorthwindContext.Customers.Remove(forDelete);
            }
        }
    }
}
