using System;

class SequenceOfGivenSum
{
    static void Main()
    {
        int lenght;
        int seekedSum;
        int combination = 2;
        int currentSum = 0;
        bool goOut = true;

        Console.Write("Enter Lenght:");
        lenght = int.Parse(Console.ReadLine());

        Console.Write("Enter sum to be find:");
        seekedSum = int.Parse(Console.ReadLine());

        int[] array = new int[lenght];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int j = 0; j < lenght; j++)
        {
            for (int i = 0; i < lenght - 1; i++)
            {
              
                for (int k = 0; k < combination; k++)
                {
                    if ((i + k) >= lenght)
                    {
                        currentSum = 0;
                        break;
                    }
                    
                    currentSum = currentSum + array[i + k];
                    //Console.WriteLine("{0}+++++++++++",array[i+k]);
                }
                //Console.WriteLine("+++++++{0}[{1}]", currentSum, i);
                if (currentSum == seekedSum)
                {
                    for (int k = 0; k < combination; k++)
                    {
                        //if ((i + k) >= lenght)
                            //break;
                        Console.Write("{0},", array[i + k]);

                    }
                    Console.WriteLine();

                }
                currentSum = 0;

            }
            combination++;
            if (combination > lenght)
                break;
            //Console.WriteLine("++++++++{0}",combination);
        }
    }
}

