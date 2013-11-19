using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace StudentSystem.Models
{
    public class Course
    {
        private ICollection<Student> participatedStudents = null;

        private ICollection<Homework> homeworks = null;

        public Course()
        {
            this.participatedStudents = new List<Student>();
            this.homeworks = new List<Homework>();
        }

        public virtual ICollection<Student> ParticipatedStudents
        {
            get { return this.participatedStudents; }
            set { this.participatedStudents = value; }
        }

        public virtual ICollection<Homework> Homeworks
        {
            get { return this.homeworks; }
            set { this.homeworks = value; }
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Materials { get; set; }
    }
}
