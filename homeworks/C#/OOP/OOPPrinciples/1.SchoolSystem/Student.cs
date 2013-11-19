using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    public class Student : People, IUniqueble<int>
    {
        private int uniqueNumber;
        
        
        //constructor

        public Student(string name)
        {
            this.Name = name;
            this.UniqueNumber = 0;
        }


        //properties

        public int UniqueNumber
        {
            get { return this.uniqueNumber; }
            set { this.uniqueNumber = value; }
        }


        //IUniqueble method implement
        public int UniqueGenerator()
        {
            int generator = 1;
            Classes.GeneretedHolder.Add(generator);
            generator = Classes.GeneretedHolder.Count * 1;
            return generator;
        }

        public override string ToString()
        {
            return String.Format("Student Name: {0}{1} Number in class: {2}{3}",
                this.Name,
                Environment.NewLine,
                this.UniqueNumber,
                Environment.NewLine);
        }
    }
}
