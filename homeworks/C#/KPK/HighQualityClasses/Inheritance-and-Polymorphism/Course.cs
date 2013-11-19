using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    // Repated code reduced
    // All Common methods and props come together in abstract class Course
    // All props are checked for nullable values -> trown Exception with proper message.
    public abstract class Course
    {
        private string courseName;
        private string teacherName;
        private IList<string> students;

        // Aways make an abstract class constructor protected.
        protected Course(string courseName = null, string teacherName = null, IList<string> students = null)
        {
            this.CourseName = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        private string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }

       public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.CourseName);
            result.Append("; Teacher = ");
            result.Append(this.TeacherName);
            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());

            return result.ToString();
        }

        protected string CourseName
        {
            get
            {
                return this.courseName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Course name can't ne left blank!");
                }
                this.courseName = value;
            }
        }
        protected string TeacherName
        {
            get
            {
                return this.teacherName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Teacher name can't ne left blank!");
                }
                this.teacherName = value;
            }
        }
        protected IList<string> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                if (value.Equals(null))
                {
                    throw new NullReferenceException("Information for a student can't be left blank!");
                }
                this.students = value;
            }
        }
    }
}
