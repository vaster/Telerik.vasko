using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CheckExpresion
{
    static void Main(string[] args)
    {
        string expresion;
        int indexOpen=-1; 
        int indexClose=-1;
        
         

        Console.Write("Enter expresion: ");
        expresion = Console.ReadLine();

        for (int i = 0; i < expresion.Length; i++)
        {
            for (int z = 0; z < expresion.Length; z++)
            {
                 indexOpen = expresion.IndexOf("(",indexOpen+1);
                 indexClose = expresion.IndexOf(")",indexClose+1);
                 if (indexOpen > indexClose)
                 {
                     break;

                 }
               
            }
            if (indexOpen > indexClose)
            {
                Console.WriteLine("Wrong");
                break;
                
            }

        }

    }
}

