using System;
using System.Collections.Generic;

namespace InheritanceAndPolymorphism
{
    class CoursesExamples
    {
        static void Main()
        {
            Course localCourse = new LocalCourse(
                "Databases", "Svetlin Nakov", 
                new List<string> { "Peter", "Maria", "Milena", "Todor"},
                "Enterprise");
            Console.WriteLine(localCourse);
   
            Course offsiteCourse = new OffsiteCourse(
                "PHP and WordPress Development", "Mario Peshev", 
                new List<string>() { "Thomas", "Ani", "Steve" },
                "Sofia");
            Console.WriteLine(offsiteCourse);
        }
    }
}
