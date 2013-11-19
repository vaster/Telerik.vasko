using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

 Write a method that from a given array of students finds all students whose first name is before its last name alphabetically. Use LINQ query operators.
Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order. Rewrite the same with LINQ.


 */
namespace _3.FindStudentByPatern
{
    class Core
    {
        static void Main(string[] args)
        {
            Student bratPit = new Student("Brat","Pit",22);
            Student freidaPinto = new Student("Freida","Pinto",21);
            Student gwynethPaltrow = new Student("Gwyneth", "Paltrow",19);
            Student anonymousStudent = new Student("Student", "Anonymous",45);



            Student[] students = new Student[4];
            students[0] = bratPit;
            students[1] = freidaPinto;
            students[2] = gwynethPaltrow;
            students[3] = anonymousStudent;
            Console.WriteLine("Shows if first name is alphabeticly 'bigger' than second name");
            var resultByPaternOfName =
                from currStudent in students
                where currStudent.FirstName[0] < currStudent.LastName[0]
                select currStudent;
               
            foreach (var item in resultByPaternOfName)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Shows if age of student si between 18 and 24");
            var resultByPaternOfAge =
                from currStudent in students
                where currStudent.Age >= 18 && currStudent.Age <= 24
                select currStudent;

            foreach (var item in resultByPaternOfAge)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Sort with Lamba by Name");
            var sortedStudentsByNameLambda =
                students.OrderByDescending(currStudent => currStudent.FirstName).ThenByDescending(currStudent => currStudent.LastName); //not sure that this is right
             
            foreach (var item in sortedStudentsByNameLambda)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Sort with LINQ by First Name");
            var sortedStudentsByNameLINQ =
                from currStudent in students
                orderby currStudent.FirstName descending
                orderby currStudent.LastName descending
                select currStudent;

            foreach (var item in sortedStudentsByNameLINQ)
            {
                Console.WriteLine(item);
            }
        }
    }
}
