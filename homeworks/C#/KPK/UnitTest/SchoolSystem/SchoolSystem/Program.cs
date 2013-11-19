using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            Course<Student> course = new Course<Student>();
            Student student = new Student("A",10000);

            course[0] = student;
            school.AddCourse(course);

        }
    }
}
