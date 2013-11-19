using System;

class VariationsOfElements
{
    static void Main(string[] args)
    {
        int n;
        int k;
        int y = 1;
        

        Console.Write("Enter N for interval [1...N]");
        n = int.Parse(Console.ReadLine());

        Console.Write("Enter K for count of elements to be combined in the specific interval");
        k = int.Parse(Console.ReadLine());

        int[] array = new int[n+1];
        for (int i = 1; i <= n; i++)
        {
            array[i] = i;
        }

        do
        {
            for (int i = 1; i <=n; i++)
			{
                for (int l = 0; l < k; l++)
                {
                    if(l!=k-1)
                        Console.Write("{0},", array[y]); 
                    if(l==k-1)
                        Console.Write("{0},", array[i]);
                }
                Console.WriteLine();
			}
            y++;
        }while(y<=Math.Pow(5,(k-1)));
    }
}

