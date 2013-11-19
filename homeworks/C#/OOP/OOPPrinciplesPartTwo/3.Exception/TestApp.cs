using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Exception
{
    public class TestApp
    {
        int StartInt { get; set; }
        int EndInt { get; set; }

        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }

        public TestApp(int start, int end)
        {
            this.StartInt = start;
            this.EndInt = end;
        }

        public TestApp(DateTime start, DateTime end)
        {
            this.StartDate = start;
            this.EndDate = end;
        }

        public void RunInt()
        {
            for (int i = this.StartInt; i < this.EndInt; i++)
            {
                if (i >=100 || i<0)
                {
                    string msg = String.Format("Invalid Range from [{0} - {1}]",this.StartInt,this.EndInt);
                    throw new InvalidRangeException<int>(msg,this.StartInt,this.EndInt);
                }
                Console.WriteLine("[{0}]", i);

            }
        }
        public void RunDate()
        {
           
            for (DateTime day = this.StartDate.Date; day < this.EndDate.Date; day.AddDays(1))
            {
                if (day.Date.ToString().CompareTo(("1.1.1980 г. 0:00:00")) > 0 || day.Date.ToString().CompareTo("31.12.2013 г. 0:00:00") < 0)
                {
                    string msg = String.Format("Invalid Range from [{0} - {1}]", this.StartDate, this.EndDate);
                    throw new InvalidRangeException<DateTime>(msg, this.StartDate, this.EndDate);
                }
                Console.WriteLine(day.Date);
            }
        }
    }
}
