using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School.Services.Models
{
    public class StudentModel
    {
        private int id;
        private string firstName;
        private string lastName;
        private int age;
        private double grade;
        private ICollection<MarkModel> marks;
        private SchoolModel school;

        public StudentModel()
        {
            this.id = 0;
            this.firstName = null;
            this.lastName = null;
            this.age = 0;
            this.grade = 0.0d;
            this.marks = new HashSet<MarkModel>();
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

        public ICollection<MarkModel> Marks
        {
            get { return this.marks; }
            set { this.marks = value; }
        }

        public SchoolModel School
        {
            get { return this.school; }
            set { this.school = value; }
        }
    }

}