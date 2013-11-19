using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client;

namespace _2.Task2
{
    internal class Performencer
    {
        /*
         Using Entity Framework write a query that selects all employees from the Telerik Academy database, 
         * then invokes ToList(), then selects their addresses, then invokes ToList(),
         * then selects their towns, then invokes ToList() and finally checks whether the town is "Sofia".
         * Rewrite the same in more optimized way and compare the performance.
         */

        public static void SlowQuery()
        {
            using(TelerikAcademyEntities context = new TelerikAcademyEntities())
            {

                var emp = context.Employees.ToList()
                    .Select(x=>x.Address).ToList()
                    .Select(t=>t.Town).ToList()
                    .Where(t=>t.Name == "Sofia");
            }
        }

        public static void FastQuery()
        {
            using (TelerikAcademyEntities context = new TelerikAcademyEntities())
            {

                var emp = context.Employees
                    .Select(x => x.Address)
                    .Select(t => t.Town)
                    .Where(t => t.Name == "Sofia");
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
