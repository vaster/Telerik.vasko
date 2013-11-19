using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SchoolSystem
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void Student_StudentIsCreated()
        {
            Student student = new Student("Anonymous", 10013);

            Assert.IsNotNull(student, "Studnet not created properly.");
            Assert.AreEqual(student.Name, "Anonymous", "Student name is not what is expected. Expected 'Anonymous.'");
            Assert.AreEqual(student.UniqeNumber, 10013, "Student school number is not wat expected. Expected 10013.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Student_10IsOutOfSchoolNumberAllowedRange()
        {
            Student student = new Student("Anonymouse",10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Student_10000000IsOutOfSchoolNumberAllowedRange()
        {
            Student student = new Student("Anonymouse", 10000000);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Student_NameIsEmpty()
        {
            Student student = new Student("",10000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Student_CheckForUniqnessTwoStudentsWithSameSchoolNumbers()
        {
            Student markWebber = new Student("Mark Webber", 10000);
            Student snoopDogg = new Student("Snoop Dogg", 10000);
        }
    }
}
