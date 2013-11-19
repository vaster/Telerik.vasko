using System;

    class SumOfSubSetIs0
    {
        static void Main()
        {
            int[] inPutt = new int[6];
            int counter;

            for (counter = 1; counter < inPutt.Length; counter++ )
            {
                Console.Write("Enter int. number:");
                inPutt[counter] =int.Parse(Console.ReadLine());
            }
           
                if (inPutt[1] + inPutt[2] == 0)
                {
                    Console.WriteLine("Sum of {0}, {1} is zero",inPutt[1],inPutt[2]);
                }
                if (inPutt[1] + inPutt[3] == 0)
                {
                    Console.WriteLine("Sum of {0}, {1} is zero", inPutt[1], inPutt[3]);
                }
                if (inPutt[1] + inPutt[4] == 0)
                {
                    Console.WriteLine("Sum of {0}, {1} is zero", inPutt[1], inPutt[4]);
                }
                if (inPutt[1] + inPutt[5] == 0)
                {
                    Console.WriteLine("Sum of {0}, {1} is zero", inPutt[1], inPutt[5]);
                }
                if (inPutt[1] + inPutt[2] + inPutt[3] == 0)
                {
                    Console.WriteLine("Sum of {0}, {1}, {2} is zero", inPutt[1], inPutt[2], inPutt[3]);
                }
                if (inPutt[1] + inPutt[2] + inPutt[4] == 0)
                {
                    Console.WriteLine("Sum of {0}, {1}, {2} is zero", inPutt[1], inPutt[2], inPutt[4]);
                }
                if (inPutt[1] + inPutt[2] + inPutt[5] == 0)
                {
                    Console.WriteLine("Sum of {0}, {1}, {2} is zero", inPutt[1], inPutt[2], inPutt[5]);
                }
                if (inPutt[1] + inPutt[3] + inPutt[4] == 0)
                {
                    Console.WriteLine("Sum of {0}, {1}, {2} is zero", inPutt[1], inPutt[3], inPutt[4]);
                }
                if (inPutt[1] + inPutt[3] + inPutt[5] == 0)
                {
                    Console.WriteLine("Sum of {0}, {1}, {2} is zero", inPutt[1], inPutt[3], inPutt[5]);
                }
                if (inPutt[1] + inPutt[4] + inPutt[5] == 0)
                {
                    Console.WriteLine("Sum of {0}, {1}, {2} is zero", inPutt[1], inPutt[4], inPutt[5]);
                }
                if (inPutt[1] + inPutt[2] + inPutt[3] + inPutt[4] == 0)
                {
                    Console.WriteLine("Sum of {0}, {1}, {2}, {3} is zero", inPutt[1], inPutt[2], inPutt[3],inPutt[4]);
                }
                if (inPutt[1] + inPutt[2] + inPutt[3] + inPutt[5] == 0)
                {
                    Console.WriteLine("Sum of {0}, {1}, {2}, {3} is zero", inPutt[1], inPutt[2], inPutt[3], inPutt[5]);
                }
                if (inPutt[1] + inPutt[3] + inPutt[4] + inPutt[5] == 0)
                {
                    Console.WriteLine("Sum of {0}, {1}, {2}, {3} is zero", inPutt[1], inPutt[3], inPutt[4], inPutt[5]);
                }
                if (inPutt[1] + inPutt[2] + inPutt[3] + inPutt[4] + inPutt[5] == 0)
                {
                    Console.WriteLine("Sum of {0}, {1}, {2}, {3}, {4} is zero", inPutt[1], inPutt[2], inPutt[3], inPutt[4], inPutt[5]);
                }
                if (inPutt[2] + inPutt[3] == 0)
                {
                    Console.WriteLine("Sum of {0}, {1} is zero", inPutt[2], inPutt[3]);
                }
                if (inPutt[2] + inPutt[4] == 0)
                {
                    Console.WriteLine("Sum of {0}, {1} is zero", inPutt[2], inPutt[4]);
                }
                if (inPutt[2] + inPutt[5] == 0)
                {
                    Console.WriteLine("Sum of {0}, {1} is zero", inPutt[2], inPutt[5]);
                }
                if (inPutt[2] + inPutt[3] + inPutt[4] == 0)
                {
                    Console.WriteLine("Sum of {0}, {1}, {2} is zero", inPutt[2], inPutt[3], inPutt[4]);
                }
                if (inPutt[2] + inPutt[3] + inPutt[5] == 0)
                {
                    Console.WriteLine("Sum of {0}, {1}, {2} is zero", inPutt[2], inPutt[3], inPutt[5]);
                }
                if (inPutt[2] + inPutt[4] + inPutt[5] == 0)
                {
                    Console.WriteLine("Sum of {0}, {1}, {2} is zero", inPutt[2], inPutt[4], inPutt[5]);
                }
                if (inPutt[2] + inPutt[3] + inPutt[4] + inPutt[5] == 0)
                {
                    Console.WriteLine("Sum of {0}, {1}, {2}, {3} is zero", inPutt[2], inPutt[3], inPutt[4], inPutt[5]);
                }
                if (inPutt[3] + inPutt[4] == 0)
                {
                    Console.WriteLine("Sum of {0}, {1} is zero", inPutt[3], inPutt[4]);
                }
                if (inPutt[3] + inPutt[5] == 0)
                {
                    Console.WriteLine("Sum of {0}, {1} is zero", inPutt[3], inPutt[5]);
                }
                if (inPutt[3] + inPutt[4] + inPutt[5] == 0)
                {
                    Console.WriteLine("Sum of {0}, {1}, {2} is zero", inPutt[3], inPutt[4], inPutt[5]);
                }
            
                if (inPutt[4] + inPutt[5] == 0)
                {
                    Console.WriteLine("Sum of {0}, {1} is zero", inPutt[4], inPutt[5]);
                }
            
            
            
            
            
            
        }
    }

