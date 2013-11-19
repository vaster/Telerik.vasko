using System;

    class QuadraticEquation
    {
        static void Main()
        {
            double a;
            double b;
            double c;
            double determinant;
            double x1;
            double x2;

            Console.WriteLine("     In the equation a(x^2) + bx + c = 0");
            do
            {
                Console.Write("Enter number for a(a != 0):");
                a = double.Parse(Console.ReadLine());
            }while(a==0);
            Console.Write("Enter nubmer for b:");
            b = double.Parse(Console.ReadLine());
            Console.Write("Enter number f c:");
            c = double.Parse(Console.ReadLine());

            determinant = (b * b) - 4 * a * c;
            if (determinant < 0)
            {
                Console.WriteLine("No real roots.");
            }
            if (determinant == 0)
            {
                x1 = x2 = (-b) / (2 * a);
                Console.Write("We have only one root for the equation  x = {0}",x1);
            }
            if (determinant > 0)
            {
                x1 = (-b + Math.Sqrt(determinant))/(2*a);
                x2 = (-b - Math.Sqrt(determinant))/(2*a);

                Console.Write("The roots are:\n x1 = {0}\n x2 = {1}",x1,x2);
            }
        }
    }

