﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
We are given a school. In the school there are classes of students. 
Each class has a set of teachers. Each teacher teaches a set of disciplines.
Students have name and unique class number. Classes have unique text identifier.
Teachers have name. Disciplines have name, number of lectures and number of exercises. 
Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).
Your task is to identify the classes (in terms of  OOP) and their attributes and operations, encapsulate their fields,
define the class hierarchy and create a class diagram with Visual Studio.
 
 */
namespace OOPPrinciples
{
    class Core
    {
        static void Main(string[] args)
        {

            //testing
            List<Disciplines> discipline = new List<Disciplines>()
            {
                new Disciplines("Math",3,3),
                new Disciplines("History",2,3),
                new Disciplines("Physics",4,3)
            };

            List<Disciplines> disciplines = new List<Disciplines>()
            {
                new Disciplines("Chemistry",2,3),
                new Disciplines("Teortical Electronics",1,2),
                new Disciplines("Laws of Optics",4,3)
            };

            List<Teacher> teachers = new List<Teacher>()
            {
                new Teacher("Chloe Adelard",disciplines),
                new Teacher("Remi Bayrad",discipline)
            };
            List<Student> studentsOfFirstClass = new List<Student>()
            {
                new Student("Aubert Elie"),
                new Student("Degare Eloy"),
                new Student("Marrok Pons"),
                new Student("Yvon Julies"),
                
            };
            List<Student> studentsOfSecondClass = new List<Student>()
            {
                new Student("Adophe Claude"),
                new Student("Dion Elliot"),
                new Student("Eudo Garland"),
                new Student("Irene Ives"),
            };

         
            List<Classes> justClasses = new List<Classes>()
            {
                
                 new Classes("044", studentsOfFirstClass, teachers),
                 new Classes("045", studentsOfSecondClass, teachers),
            };
           

            School sampleSchool = new School(justClasses);
            sampleSchool.PrintInfo();

        }
    }
}
