using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class LocalCourse : Course
    {

        public string lab;

        public LocalCourse(string courseName=null, string teacherName=null, IList<string> students=null, string lab = null)
            : base(courseName, teacherName, students)
        {
            this.Lab = lab;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("LocalCourse { Name = ");
            result.Append(base.ToString());
            result.Append("; Lab = ");
            result.Append(this.Lab);
            result.Append(" }");

            return result.ToString();
        }

        private string Lab
        {
            get
            {
                return this.lab;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Laboratory information can't be left blank!");
                }
                this.lab = value;
            }
        }
    }
}
