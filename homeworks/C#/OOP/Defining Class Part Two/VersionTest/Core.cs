using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;



namespace major
{
    class Core
    {
        static void Main(string[] args)
        {

            Sample sample = new Sample();
            Type type = typeof(Sample);
            object[] attributes = type.GetCustomAttributes(true);
            foreach (object attribute in attributes)
            {
                Console.Write("  {0}", attribute.ToString());
                Version da = attribute as Version;
                if (da != null)
                    Console.WriteLine("(" + da.VersionCheck + ")");
                else
                    Console.WriteLine();
            }
        }
    }
}
