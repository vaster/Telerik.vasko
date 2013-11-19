using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchoolSystem.Data;
using StudentSystem.Models;

namespace SchoolSystem.Client
{
    internal class Seeder
    {
        static void Main(string[] args)
        {
            SchoolSystemContext context = new SchoolSystemContext();

            Student sampleStudent = new Student();

            sampleStudent.Name = "Name2";

            context.Students.Add(sampleStudent);

            context.SaveChanges();
        }
    }
}
