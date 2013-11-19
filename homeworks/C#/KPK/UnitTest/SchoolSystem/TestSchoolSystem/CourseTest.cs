using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SchoolSystem
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void Course_StudentIsAdded()
        {
            Course<Student> mathCourse = new Course<Student>();
            Student student = new Student("Anonymous", 10001);

            mathCourse[0] = student;
            bool actual = (mathCourse[0] == (student));
            Assert.AreEqual(true, actual,"student is not added to the course.");
        }

        [TestMethod]
        public void Course_StudentIsExcluded()
        {
            Course<Student> mathCourse = new Course<Student>();
            Student bratPit = new Student("Brat Pit", 10002);
            Student fracescoTotti = new Student("Francesco Totti", 10003);
            Student jessicaAlba = new Student("Jessica Alba", 10004);

            mathCourse[0] = bratPit;
            mathCourse[1] = fracescoTotti;
            mathCourse[2] = jessicaAlba;

            mathCourse.ExcludeParticipant(fracescoTotti);

            bool actual = true;
            for (int index = 0; index < 3; index++)
            {
                if (mathCourse[index] == fracescoTotti)
                {
                    actual = false;
                    break;
                }
            }

            Assert.IsTrue(actual,"Student is not removed from the course.");
        }

        [TestMethod]
        public void Course_ArragneOfArrayIsRight()
        {
            Course<Student> mathCourse = new Course<Student>();
            Student bratPit = new Student("Brat Pit", 10005);
            Student fracescoTotti = new Student("Francesco Totti", 10006);
            Student jessicaAlba = new Student("Jessica Alba", 10007);

            mathCourse[0] = bratPit;
            mathCourse[1] = fracescoTotti;
            mathCourse[2] = jessicaAlba;

            mathCourse.ExcludeParticipant(bratPit);
            mathCourse.ExcludeParticipant(fracescoTotti);

            Assert.AreEqual(jessicaAlba,mathCourse[0],"mathCourse[0] is not set to the right Object. Probably Course->ExcludeParticipant->Sorting logic problem.");
            Assert.AreEqual(null,mathCourse[1], "mathCourse[1] is not set to null. Probably Course->ExcludeParticipant->Sorting logic problem.");
            Assert.AreEqual(null, mathCourse[2],"mathCourse[2] is not set to null. Probably Course->ExcludeParticipant->Sorting logic problem.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Course_30IsOutOfRangeIndex()
        {
            Course<Student> mathCourse = new Course<Student>();
            Student student = new Student("Anonymous", 10008);

            mathCourse[30] = student;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Course_Minus5IsOutOfRangeIndex()
        {
            Course<Student> mathCourse = new Course<Student>();
            Student student = new Student("Anonymous", 10009);

            mathCourse[-5] = student;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Course_StudentIsAlreadyInThisCourse()
        {
            Course<Student> mathCourse = new Course<Student>();
            Student student = new Student("Anonymous", 10010);

            mathCourse[0] = student;
            mathCourse[1] = student;
        }

        [TestMethod]
        [ExpectedException((typeof(InvalidOperationException)))]
        public void Course_ReWritingExistingStudentIsNotAllowed()
        {
            Course<Student> mathCourse = new Course<Student>();
            Student rosamundPike = new Student("rosamundPike", 10011);
            Student friedaPinto = new Student("friedaPinto", 10012);

            mathCourse[0] = rosamundPike;
            mathCourse[0] = friedaPinto;
        } 
    }
}
