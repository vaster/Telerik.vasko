using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    public class Classes : IUniqueble<string>
    {
        private string uniqueTextIndentifer;
        private List<Student> students = new List<Student>();
        private List<Teacher> teachers = new List<Teacher>();
        public string MainField { get; set; }
        public static  List<int> GeneretedHolder {get;set;}
       


        //constructor
       
        public Classes(string justClassIndt, List<Student> students, List<Teacher> teachers)
        {
            GeneretedHolder = new List<int>();
            for (int i = 0; i < students.Count; i++)
            {
                students[i].UniqueNumber = students[i].UniqueGenerator();
                this.Students.Add(students[i]);
                
            }
            this.Teachers.AddRange(teachers);
            this.UniqueTextIndentifer = justClassIndt;
            
        }

        //properties

        public string UniqueTextIndentifer
        {
            get { return this.uniqueTextIndentifer; }
            set
            {
                this.uniqueTextIndentifer = value;
                //this.uniqueTextIndentifer=this.UniqueGenerator();
            }
        }

        private List<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }

        private List<Teacher> Teachers
        {
            get { return this.teachers; }
            set { this.teachers = value; }
        }


        //IUniqueble method implement
       public string UniqueGenerator()
        {

            for (int i = 0; i < School.ClassIndt.Count; i++)
            {
                if (School.ClassIndt[i].Equals(this.UniqueTextIndentifer))
                {
                    throw new Exception("There is Subject with a name '" + this.UniqueTextIndentifer + "'!");
                }
            }
            School.ClassIndt.Add(this.UniqueTextIndentifer);
            return UniqueTextIndentifer;
        }
        //methods

        public void PrintClassParticipents()
        {

            for (int i = 0; i < this.Teachers.Count; i++)
            {
                Console.Write(Teachers[i]);
                Teachers[i].PrintDisciplines();
            }

            for (int i = 0; i < Students.Count; i++)
            {
                Console.WriteLine(Students[i]);
            }
        }

        public override string ToString()
        {
            return String.Format("Class Indetifier: {0}{1}", this.UniqueTextIndentifer, Environment.NewLine);
        }
    }
}
