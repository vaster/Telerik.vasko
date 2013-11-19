using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class Call
    {
        private string date = null;
        private string time = null;
        private string dialedNumber = null;
        private int duration = 0;


        //properties

        public string Date
        {
            get { return this.date; }
            set
            {
                if (value.Equals(string.Empty))
                {
                    throw new ArgumentNullException("Date can't be empty");
                }
                this.date = value;
            }
        }

        public string Time
        {
            get { return this.time; }
            set
            {
                if (value.Equals(string.Empty))
                {
                    throw new ArgumentNullException("Time can't be empty");
                }
                this.time = value;
            }
        }

        public string DialedNumber
        {
            get {return this.dialedNumber; }
            set
            {
                if (value.Equals(string.Empty))
                {
                    throw new ArgumentOutOfRangeException("No number entered? Try again.");
                }
                this.dialedNumber = value;
            }
        }
        public int Duration
        {
            get { return this.duration; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Duration can't be negative");
                }
                this.duration = value;
            }
        }

        //Constructors
        public Call()//empty constructor
        {

        }

        public Call(string date, string time, string number, int duration)//full argument costructor
        {
            this.Date = date;
            this.Time = time;
            this.DialedNumber=number;
            this.Duration = duration;
        }

        //methods

        public void PrintCall()
        {
            Console.WriteLine("Date of Call: {0}",this.Date);
            Console.WriteLine("Time when call was made: {0}",this.Time);
            Console.WriteLine("Phone number of the reciver: {0}",this.DialedNumber);
            Console.WriteLine("Duration of the call: {0}",this.Duration);
        }

    }
}
