using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    public class Student
    {
        private int id;
        private string firstName;
        private string lastName;
        private int age;
        private double grade;
        private ICollection<Mark> marks;
        private School school;

        public Student()
        {
            this.id = 0;
            this.firstName = null;
            this.lastName = null;
            this.age = 0;
            this.grade = 0.0d;
            this.marks = new HashSet<Mark>();
            this.school = null;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = 0; }
        }

        public double Grade
        {
            get { return this.grade; }
            set { this.grade = 0.0d; }
        }

        public virtual ICollection<Mark> Marks
        {
            get { return this.marks; }
            set { this.marks = value; }
        }

        public virtual School School
        {
            get { return this.school; }
            set { this.school = value; }
        }
    }
}
