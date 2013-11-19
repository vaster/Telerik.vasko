using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class OffsiteCourse : Course
    {

        private string town;

        public OffsiteCourse(string courseName = null, string teacherName = null, IList<string> students = null, string town = null)
            : base(courseName, teacherName, students)
        {
            this.Town = town;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("OffsiteCourse { Name = ");
            result.Append(base.ToString());
            result.Append("; Town = ");
            result.Append(this.Town);
            result.Append(" }");

            return result.ToString();
        }

        private string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Town information can't be left blank!");
                }
                this.town = value;
            }
        }
    }
}
