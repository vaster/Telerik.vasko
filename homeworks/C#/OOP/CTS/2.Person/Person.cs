using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Person
{
    public class Person
    {
        private string name;
        private Nullable<int> age;

        //constructor
        public Person(string name, Nullable<int> age = null)
        {
            this.Age = age;
            this.Name = name;
        }

        //methods
        public override string ToString()
        {
            if (!(this.Age.Equals(null)))
            {
                return String.Format("Name: " + this.Name + Environment.NewLine + "Age: " + this.Age);
            }
            return String.Format("Name: " + this.Name + Environment.NewLine + "Age: Not specifeed");
        }
        //properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public Nullable<int> Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

    }
}
