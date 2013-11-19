using System;

    class CompanyInfo
    {
        static void Main()
        {
            string companyName;
            string companyAddress;
            int companyPhone;
            int companyFax;
            string companyWeb;
            string managerFirstName;
            string managerLastName;
            int managerAge;
            int managerPhone;

            Console.Write("Enter company name:");
            companyName = Console.ReadLine();

            Console.Write("Enter company address:");
            companyAddress = Console.ReadLine();

            Console.Write("Enter company phone number:");
            companyPhone = int.Parse(Console.ReadLine());

            Console.Write("Enter company fax number:");
            companyFax = int.Parse(Console.ReadLine());

            Console.Write("Enter company website:");
            companyWeb = Console.ReadLine();

            Console.Write("Enter manager first name:");
            managerFirstName = Console.ReadLine();

            Console.Write("Enter manager last name:");
            managerLastName = Console.ReadLine();

            Console.Write("Enter manager age:");
            managerAge = int.Parse(Console.ReadLine());

            Console.Write("Enter manager phone number:");
            managerPhone = int.Parse(Console.ReadLine());

            Console.WriteLine("     Info aobut the Company\nCompany Name:{0}\nCompany Address:{1}\nCompany Phone:{2}\nCompany Fax:{3}\nCompany WebSite:{4}",companyName,companyAddress,companyPhone,companyFax,companyWeb);
            Console.WriteLine("     Info about the Manager\nManager First Name:{0}\nManager Last Name:{1}\nManager age:{2}\nManager Phone Number{3}",managerFirstName,managerLastName,managerAge,managerPhone);
        }
    }

