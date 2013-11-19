using System;
using System.Collections.Generic;
using System.Text;


namespace StudentSystem.Models
{
    public class Student
    {
        private ICollection<Course> participatedCourses = null;

        private ICollection<Homework> homeworks = null;

        public Student()
        {
            this.participatedCourses = new List<Course>();
            this.homeworks = new List<Homework>();
        }

        public virtual ICollection<Course> ParticipatedCourses
        {
            get { return this.participatedCourses; }
            set { this.participatedCourses = value; }
        }

        public virtual ICollection<Homework> Homework
        {
            get { return this.homeworks; }
            set { this.homeworks = value; }
        }


        public int Id { get; set; }

        public string Name { get; set; }

        public string Number { get; set; }


    }
}
