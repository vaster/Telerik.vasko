using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    public class School
    {
        private int id;
        private string name;
        private string location;
        private ICollection<Student> students;

        public School()
        {
            this.id = 0;
            this.name = null;
            this.location = null;
            this.students = new HashSet<Student>();
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        public virtual ICollection<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }
    }
}
