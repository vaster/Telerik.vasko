using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range.
It should hold error message and a range definition [start … end].
Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers in the range [1..100]
and dates in the range [1.1.1980 … 31.12.2013].

 */
namespace _3.Exception
{
    class Core
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            TestApp sampleTest = new TestApp(1,50);
            try
            {
                sampleTest.RunInt();
                
            }
            catch (InvalidRangeException<int> are)
            {

                throw new InvalidRangeException<int>("Range Must be from [1 - 100].", are);
            }
            sampleTest = new TestApp(today.Date, today.AddYears(3).Date);
            try
            {
                sampleTest.RunDate();
            }
            catch (InvalidRangeException<DateTime> are)
            {
                throw new InvalidRangeException<DateTime>("Invalid Date from [1.1.1980 - 12.31.2013]", are);
            }
           
        }
    }
}
