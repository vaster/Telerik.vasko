using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SchoolSystem
{
    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void School_ChecIsNotkUniqeNumber()
        {
            School school = new School();
            Course<Student> course = new Course<Student>();
            Student student = new Student("Anonymouse",10000);

            course[0] = student;
            school.AddCourse(course);

            bool falseCondition = School.CheckForTrueUniqeNumber(10000);

            Assert.IsFalse(falseCondition,"Probably Uniqe Number funcionalty issue in the School class.");
        }
    }
}
