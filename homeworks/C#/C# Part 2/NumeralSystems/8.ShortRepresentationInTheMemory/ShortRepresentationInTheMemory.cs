using System;
using System.Collections.Generic;



class ShortRepresentationInTheMemory
{
    static int[] MakeItBin(short shortNumber,int sign)
    {

        if (shortNumber < 0)
        {
            shortNumber = Convert.ToInt16(shortNumber * (-1));
        }                              


        int lenght = 15;
        short storeNumber = shortNumber;
        int[] binRep = new int[16];
        int binSum = 0;
        binRep[0] = sign;
        
        do                                                           
        {                                                            
            shortNumber = Convert.ToInt16(storeNumber%2);
            binRep[lenght] = shortNumber; 
            storeNumber = Convert.ToInt16(storeNumber /2);           
            lenght--;                                                
                                                                     
        } while (lenght > 0);

       
        for (int i = 1; i < binRep.Length; i++)                    
        {
            if (sign == 0)
            {
                break;
            }                                                
            binRep[i] = binRep[i]^1;                                  
        }                                                        

        lenght = 15;

        do
        {
            if (sign == 0)
            {
                break;
            }
            binSum = binRep[lenght] + 1;

            if (binSum == 1)
            {
                binRep[lenght] = 1;
                binSum = 0;
            }

            if (binSum == 2)
            {
                binRep[lenght] = 0;
                if (binRep[lenght - 1] == 1)
                {
                    binSum = 2;
                }
                if (binRep[lenght - 1] == 0)
                {
                    binSum = 1;
                }
            }
            
            
           
            lenght--;
        } while (binSum != 0 && lenght >= 1);


        return binRep;

    }
    /*____________________________________________________________*/
    static int TellMeWhatIsTheSigh(short shortNumber)
    {
        if (shortNumber < 0)
            return 1;
        else
            return 0;
    }
    /*____________________________________________________________*/
    static void Main(string[] args)
    {
        short number;
        int[] binRep = new int[16];
        int sign;
        Console.Write("Enter 2 byte number (min:{0}, max:+{1}):", short.MinValue, short.MaxValue);
        number = short.Parse(Console.ReadLine());
        sign = TellMeWhatIsTheSigh(number);
        binRep = MakeItBin(number,sign);
        foreach (var bins in binRep)
        {
            Console.Write(bins);
        }
    }
}

