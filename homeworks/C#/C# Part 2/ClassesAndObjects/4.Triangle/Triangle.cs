﻿using System;
using System.Collections.Generic;

class Triangle
{
    static double CalculateSurface(int formulaType, List<int> triangleParams)
    {
        
        if (formulaType == 1)
        {
            return (triangleParams[0]*triangleParams[1]) * 0.5;
        }
        if (formulaType == 2)
        {
            double helpingTool = (triangleParams[0] + triangleParams[1] +triangleParams[2])*0.5;
            return Math.Sqrt(helpingTool * (helpingTool - triangleParams[0]) * (helpingTool - triangleParams[1]) * (helpingTool - triangleParams[2]));
        }
        else
        {
            return 0.5*(triangleParams[0]*triangleParams[1]*Math.Sin(triangleParams[2]));
        }
    }
    /*_____________________________________________________________________________________*/
    static void Main(string[] args)
    {
        int choice;
        List<int> triangleParameters = new List<int>();
        double result;

        Console.WriteLine("Make a choice.");
        Console.WriteLine("1.By side and altitude.");
        Console.WriteLine("2.By Three sides(Heron's formula).");
        Console.WriteLine("3.By two sides and an angle betweem them.");

        choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                {
                    Console.Write("Enter Side:");
                    triangleParameters.Add(int.Parse(Console.ReadLine()));
                    Console.Write("enter altitude:");
                    triangleParameters.Add(int.Parse(Console.ReadLine()));

                    break;
                }
            case 2:
                {
                    Console.Write("Enter Side A:");
                    triangleParameters.Add(int.Parse(Console.ReadLine()));
                    Console.Write("Enter Side B:");
                    triangleParameters.Add(int.Parse(Console.ReadLine()));
                    Console.Write("Enter Side C:");
                    triangleParameters.Add(int.Parse(Console.ReadLine()));
                    break;
                }
            case 3:
                {
                    Console.Write("Enter Side A:");
                    triangleParameters.Add(int.Parse(Console.ReadLine()));
                    Console.Write("Enter Side B:");
                    triangleParameters.Add(int.Parse(Console.ReadLine()));
                    Console.Write("Enter angle between them(in degrees):");
                    triangleParameters.Add(int.Parse(Console.ReadLine()));
                    break;
                }
            default:
                {
                    Console.WriteLine("Wrong Choice? Try again.");
                    break;
                }


                
        }
        if (choice <= 3)
        {
            result = CalculateSurface(choice, triangleParameters);
            Console.WriteLine("Area is {0}", result);
        }
    }
}

