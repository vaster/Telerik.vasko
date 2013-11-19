using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _7.Timer
{
    public delegate void TimeDeley(string msg, int seconds);



    public class Timer
    {

        public static void Msg(string msg, int seconds)
        {

            Console.WriteLine(msg);
            Timer.Deley(seconds);
        }


        public static void Deley(int seconds)
        {

            Thread.Sleep(seconds * 1000);
        }
    }
}
