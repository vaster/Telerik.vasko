using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using StudentSystem.Models;

namespace SchoolSystem.Data
{
    public class SchoolSystemContext : DbContext
    {
        public SchoolSystemContext()
            : base("SchoolSystemDB")
        {
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Homework> Homework { get; set; }
    }
}
