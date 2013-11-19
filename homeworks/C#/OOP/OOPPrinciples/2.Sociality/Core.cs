using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Define abstract class Human with first name and last name.
Define new class Student which is derived from Human and has new field – grade.
Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker.
Define the proper constructors and properties for this hierarchy. 
Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method). 
Initialize a list of 10 workers and sort them by money per hour in descending order. 
Merge the lists and sort them by first name and last name.

 */
namespace _2.Sociality
{
    class Core
    {
        static void Main(string[] args)
        {
            //testing
            List<Student> sampleListOfStudents = new List<Student>()
            {
                new Student("Avaron","Bunko",(decimal)5.5),
                new Student("Kazumi","Keiko",(decimal)4),
                new Student("Mi","Rei",(decimal)6),
                new Student("Nori","Ume",(decimal)5.2),
                new Student("Usagi","Yoshiko",(decimal)3.3),
                new Student("Yoko","Hitomi",(decimal)5.7),
                new Student("Emi","Cho",(decimal)6),
                new Student("Fumiko","Azumi",(decimal)5.1),
                new Student("Gina","Hitmoi",(decimal)2),
                new Student("Jun","Kin",(decimal)3),
            };
            //LINQ sort
           
            var sortedStudents =
                from currStudent in sampleListOfStudents
                orderby currStudent.Grade ascending
                select currStudent;
            Console.WriteLine("Students");
            foreach (var item in sortedStudents)
            {
                Console.WriteLine(item);
            }



            List<Worker> sampleListOfWorkers = new List<Worker>()
            {
                new Worker("Freida","Pinto",(decimal)100,5),
                new Worker("Stanly","Kubrrick",(decimal)320,10),
                new Worker("Martin","Scorsese",(decimal)1000,7),
                new Worker("Vincent","Cassel",(decimal)78,12),
                new Worker("Mila","Kunis",(decimal)115,10),
                new Worker("Terrence","Malick",(decimal)-30,4),
                new Worker("Wes","Anderson",(decimal)1,6),
                new Worker("Malcolm","",(decimal)252,8),
                new Worker("Reese","",(decimal)230,9),
                new Worker("Dewey","",(decimal)0.78,3),
            };

            //LINQ sort
            var sortedWorkers =
                from currWorker in sampleListOfWorkers
                orderby currWorker.MoneyPerHour() descending
                select currWorker;
            Console.WriteLine();
            Console.WriteLine("Workers");
            foreach (var item in sortedWorkers)
            {
                Console.WriteLine(item);
            }

            //mergin Lists

            List<Human> person = new List<Human>();

            person.AddRange(sampleListOfStudents);
            person.AddRange(sampleListOfWorkers);

            var mergeSort =
                from currPerson in person
                orderby currPerson.FirstName, currPerson.LastName
                select currPerson;
            Console.WriteLine();
            Console.WriteLine("Sorted merged List");
            foreach (var item in mergeSort)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
