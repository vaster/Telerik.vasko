using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    public class Teacher:People
    {
        List<Disciplines> disciplines = new List<Disciplines>();
        //constructor
        public Teacher(string name, List<Disciplines> disciplines)
        {
            this.Name = name;
            this.Disciplines.AddRange(disciplines);
        }

        //properties
        private List<Disciplines> Disciplines
        {
            get { return this.disciplines; }
            set { this.disciplines = value; }
        }
        //methods

        public void PrintDisciplines()
        {
            for (int i = 0; i < this.Disciplines.Count; i++)
            {
                Console.WriteLine("{0}",this.Disciplines[i]);
            }
        }
        public override string ToString()
        {
            return String.Format("Teacher Name: {0}{1}",this.Name,Environment.NewLine);
        }
    }
}
