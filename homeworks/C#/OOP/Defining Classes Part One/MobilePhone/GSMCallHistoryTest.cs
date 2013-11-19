using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class GSMCallHistoryTest
    {
       
        public static void AddCallTest()
        {
            GSM.AddCall();
        }
        public static void PrintCallHistoty()
        {
            Console.WriteLine();
            Console.WriteLine("Call History");
        
            for (int i = 0; i < GSM.CallHistory.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Call N {0}",i+1);
                GSM.CallHistory[i].PrintCall();
            }
        }
        public static void PrintBill()
        {
            
            Console.WriteLine();
            Console.WriteLine("Total price of calls is {0}.",GSM.Bill());
            Console.WriteLine();
        }


       

    }
}
