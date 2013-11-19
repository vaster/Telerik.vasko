using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    public class School
    {
        private List<Classes> classes;
        public static List<string> ClassIndt {get;set;}

        public School(List<Classes> classes)
        {
            ClassIndt = new List<string>();
            for (int i = 0; i < classes.Count; i++)
            {
                classes[i].UniqueTextIndentifer = classes[i].UniqueGenerator();
            }
            this.classes = classes;
        }

        public void PrintInfo()
        {
            for (int i = 0; i < classes.Count; i++)
            {
                Console.WriteLine(classes[i]);
                classes[i].PrintClassParticipents();
            }
            
        }
    }
}
