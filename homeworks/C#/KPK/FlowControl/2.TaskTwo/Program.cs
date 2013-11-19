using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.TaskTwo
{
    class Program
    {
        static void Cook(Potato potato)
        {
            //TODO:
        }
        static void Main(string[] args)
        {
            //Sample
            Potato potato = new Potato();
            //... 
            if (potato != null)
            {
                if (!potato.IsRotten && !potato.HasNotBeenPeeled)// Rotten check befoure Peeled check.
                {
                    Cook(potato);
                }
            }
        }
    }
}
