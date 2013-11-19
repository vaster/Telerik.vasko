using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client;

namespace _1.TaskOne
{
    internal class Performencer
    {

        /*
             Using Entity Framework write a SQL query to select all employees from the Telerik Academy database and later print their name, 
             department and town. 
             Try the both variants: with and without .Include(…). 
             Compare the number of executed SQL statements and the performance.
         */

        public static void SlowQuery()
        {
            using (TelerikAcademyEntities context = new TelerikAcademyEntities())
            {
                var employees = context.Employees;

                foreach (var employee in employees)
                {
                    Console.WriteLine(employee.FirstName + " " + employee.Address.Town.Name + " " + employee.Department.Name);
                }
            }
        }

        public static void FastQuery()
        {
            using (TelerikAcademyEntities context = new TelerikAcademyEntities())
            {
                var employees =
                        from employee in context.Employees
                        join department in context.Departments
                        on employee.DepartmentID equals department.DepartmentID
                        join address in context.Addresses
                        on employee.AddressID equals address.AddressID
                        join town in context.Towns
                        on address.TownID equals town.TownID
                        select employee.FirstName + " "+ employee.Department.Name + " " + employee.Address.Town.Name;


                foreach (var employee in employees)
                {
                    Console.WriteLine(employee);          
                }
            }
        }

        static void Main(string[] args)
        {
           // Performencer.FastQuery();
           // Performencer.SlowQuery();
        }
    }
}
