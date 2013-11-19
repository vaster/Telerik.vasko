using System;

    class InCircleOutRect
    {
        static void Main()
        {
            double sideA;
            double sideB;
            double x;
            double y;
            int radius = 3;

            Console.Write("Enter coordinate for x:");
            x = double.Parse(Console.ReadLine());
            Console.Write("Enter coordinate for y:");
            y = double.Parse(Console.ReadLine());
            sideA = (Math.Abs(x) - 1) * (Math.Abs(x) - 1);
            sideB = (Math.Abs(y) - 1) * (Math.Abs(y) - 1);
            if ((sideA + sideB) <= radius * radius)
            {
                if ((x <= 7 && (y >= -1)) || (x <= 1 && y <= 4))
                    Console.WriteLine("The point is in the circle and out of the rect.");
            }//задачата се опитах да я реша чрез чертеж, не съм сигурен за вярността, като при top=1, left = - 1, съм приел, че горен ляв ъгъл има тези кординати
            else
                Console.WriteLine("It is not");
                        
        }
    }

