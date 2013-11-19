using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Sociality
{
    public class Student : Human
    {
        private decimal grade;
        //constructors
        public Student(string fName, string lName, decimal grade)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Grade = grade;
        }


        //properties
        public decimal Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }

        //methods

        public override string ToString()
        {
            return String.Format("Studnet Name: {0}",//u can add here to display more information, just use more placeholders
                                this.FirstName +" " + this.LastName,
                                Environment.NewLine,
                                this.Grade,
                                Environment.NewLine);
        }
    }
}
