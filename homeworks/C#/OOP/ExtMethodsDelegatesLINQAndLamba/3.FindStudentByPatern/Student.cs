using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.FindStudentByPatern
{
    public class Student
    {
        private string fName;
        private string lName;
        private int age;

        public Student(string fName, string lName,int age)
        {
            this.fName = fName;
            this.lName = lName;
            this.age = age;
        }
      

        public string FirstName
        {
            get { return this.fName; }
            
        }
        public string LastName
        {
            get { return this.lName; }
            
        }
        public int Age
        {
            get { return this.age; }
     
        }


        public override string ToString()
        {
            return string.Format("Student: {0} {1}",this.FirstName,this.LastName);
        }
    }
}
