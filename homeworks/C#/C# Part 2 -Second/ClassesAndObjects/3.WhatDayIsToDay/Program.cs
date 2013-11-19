using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.WhatDayIsToDay
{
    public class Program
    {
        /*Write a program that prints to the console which day of the week is today. Use System.DateTime.
        */
        static void Main(string[] args)
        {
            DayOfWeek today = new DayOfWeek();

            today = DateTime.Today.DayOfWeek;

            Console.WriteLine(today);
        }
    }
}
