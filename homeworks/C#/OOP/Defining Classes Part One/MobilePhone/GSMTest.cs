using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class GSMTest
    {
        private static List<GSM> gsmCatalog = new List<GSM>();


        static GSM newGSMTwo = new GSM("X8", "HTC", 1200, "Vasil");//instance with full contrsuctor arguments
        static GSM newGSMThree = new GSM("Nexus", "Google", 1000, "Vasil");//instance with full contrsuctor arguments


      
        
        public static void TestGSM()
        {
            GsmCatalog.Add(newGSMTwo);
            GsmCatalog.Add(newGSMThree);
            for (int i = 0; i < gsmCatalog.Count; i++)
            {
                Console.WriteLine();
                gsmCatalog[i].PrintGSMInfo();
            }
            Console.WriteLine();
            Console.WriteLine("{0}{1}", Environment.NewLine, GSM.Iphone4S);
        }


        private static List<GSM> GsmCatalog
        {
            get { return gsmCatalog; }
            set { gsmCatalog = value; }
        }



    }
}
