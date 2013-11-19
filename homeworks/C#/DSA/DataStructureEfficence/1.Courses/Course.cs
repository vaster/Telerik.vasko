using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureEfficence
{
    public class Course : IComparable<Course>
    {
        public string Name { get; private set; }

        public Course(string name)
        {
            this.Name = name;
        }

        public int CompareTo(Course other)
        {
            if (this.Name.CompareTo(other.Name) > 0)
            {
                return 1;
            }
            else if (this.Name.CompareTo(other.Name) < 0)
            {
                return -1;
            }

            return 0;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
