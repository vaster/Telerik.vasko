using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureEfficence
{
    public class Student : IComparable<Student>
    {

        public string FirstName { get; private set; }

        public string LastName { get; private set; }


        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int CompareTo(Student other)
        {
            if (this.LastName.CompareTo(other.LastName) > 0)
            {
                return 1;
            }
            else if (this.LastName.CompareTo(other.LastName) < 0)
            {
                return -1;
            }
            else
            {
                if (this.FirstName.CompareTo(other.FirstName) > 0)
                {
                    return 1;
                }
                else if (this.FirstName.CompareTo(other.FirstName) < 0)
                {
                    return -1;
                }

                return 0;
            }
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
