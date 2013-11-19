using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class School
    {
        private static List<int> schoolNumberHolder;
        private List<Course<Student>> courses;

        // constructors

        static School()
        {
            schoolNumberHolder = new List<int>();
        }

        public School()
        {
            this.courses = new List<Course<Student>>();
           
        }

        // methods
        public void AddCourse(Course<Student> course)
        {
            this.courses.Add(course);
        }

        public static bool CheckForTrueUniqeNumber(int schoolNumber)
        {
            for (int index = 0; index < schoolNumberHolder.Count; index++)
            {
                if (schoolNumber == schoolNumberHolder[index])
                {
                    return false;
                }
            }
            schoolNumberHolder.Add(schoolNumber);

            return true;
        }
    }
}
