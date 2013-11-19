using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Models;

namespace School.EF.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext()
            : base("SchoolDbTest")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<School.Models.School> Schools { get; set; }
        public DbSet<Mark> Marks { get; set; }
    }
}
