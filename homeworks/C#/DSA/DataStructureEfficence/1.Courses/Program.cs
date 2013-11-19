using System;
using System.Collections.Generic;

namespace DataStructureEfficence
{

    /*
     A text file students.txt holds information about students and their courses in the following format:
        Kiril  | Ivanov   | C#
        Stefka | Nikolova | SQL
        Stela  | Mineva   | Java
        Milena | Petrova  | C#
        Ivan   | Grigorov | C#
        Ivan   | Kolev    | SQL

	 Using SortedDictionary<K,T> print the courses in alphabetical order and for each of them prints the students ordered by family and then by name
        C#: Ivan Grigorov, Kiril Ivanov, Milena Petrova
        Java: Stela Mineva
        SQL: Ivan Kolev, Stefka Nikolova
     */

    public class Program
    {
        static void Main(string[] args)
        {
            string sourceFile = "students.txt";

            CourseInfoReader infoReader = new CourseInfoReader(sourceFile);
            infoReader.ReadInfo();

            SortedDictionary<Course, SortedSet<Student>> courseInfoTable =
                new SortedDictionary<Course, SortedSet<Student>>();

            Course course = null;
            Student student = null;
            SortedSet<Student> listOfStudents = null;

            string firstName = null;
            string lastName = null;
            string courseName = null;

            for (int i = 0; i < infoReader.StudentsCount; i++)
            {
                courseName = infoReader.CourseNames[i];
                course = new Course(courseName);

                firstName = infoReader.FirstNames[i];
                lastName = infoReader.LastNames[i];
                student = new Student(firstName, lastName);

                if (!courseInfoTable.ContainsKey(course))
                {
                    listOfStudents = new SortedSet<Student>();
                    listOfStudents.Add(student);
                    courseInfoTable.Add(course, listOfStudents);
                }
                else
                {
                    courseInfoTable[course].Add(student);
                }
            }


            foreach (KeyValuePair<Course, SortedSet<Student>> courseInfo in courseInfoTable)
            {
                Console.WriteLine(courseInfo.Key);
                SortedSet<Student> students = courseInfo.Value;

                foreach (Student currStudent in students)
                {
                    Console.WriteLine("   " + currStudent);
                }
            }
        }
    }
}
