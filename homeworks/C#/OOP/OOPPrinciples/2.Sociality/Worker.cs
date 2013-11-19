using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Sociality
{
    public class Worker : Human
    {
        private const int WorkDaysInWeek = 7;
        private decimal weekSalary;
        private int workHoursPerDay;
        //constructors

        public Worker(string fName, string lName, decimal weekSalary, int workHours)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHours;
        }


        //properties

        private decimal WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }
        private int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
        }

       //methods
        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (WorkDaysInWeek * this.WorkHoursPerDay);
        }

        public override string ToString()
        {
            return String.Format("Name: {0}",//u can add here to display more information, just use more placeholders
                                this.FirstName +" "+ this.LastName,
                                Environment.NewLine,
                                this.MoneyPerHour());
        }
    }
}
