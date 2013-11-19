using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty,
 university, faculty. Use an enumeration for the specialties, universities and faculties.
 Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
 Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.
 Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order)
 and by social security number (as second criteria, in increasing order).


 */
namespace _1.StudentSystem
{
    class Core
    {
        static void Main(string[] args)
        {
            //testing
            Student sampleStud = new Student("XXX","XXX","XXX","DB","abv@.bg",123456789,10078,3,University.UniversityOfParis,Specialty.PhysicsOfFluids,Faculty.FacultyOfPhysics);
            Student sampleSt = (Student)sampleStud.Clone();
           
            Console.WriteLine(sampleStud == sampleSt);
            Console.WriteLine();

            sampleStud.FirstName = "YYY";//changing the name of first student wont change the name of the second.
            Console.WriteLine(sampleStud);
            Console.WriteLine(sampleSt);
            Console.WriteLine();
           
            Console.WriteLine(sampleStud.CompareTo(sampleSt));
        }
    }
}
