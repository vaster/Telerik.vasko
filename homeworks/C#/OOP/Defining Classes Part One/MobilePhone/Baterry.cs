using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class Baterry
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType type;



        public Baterry() //empty constructor
        {
            this.Model = null;
            this.HoursIdle = 0;
            this.HoursTalk = 0;
            this.Type = 0;
        }
        public Baterry(string model) //one argument constructor
        {
            this.Model = model;
            this.HoursIdle = 0;
            this.HoursTalk = 0;
            this.Type = 0;
        }
        public Baterry(string model, int hoursIdle) //two arguments constructor
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = 0;
            this.Type = 0;
        }
        public Baterry(string model, int hoursIdle, int hoursTalk, BatteryType type) //full arguments constructor
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.Type = type;
        }


        public void PrintBaterryInfo()
        {
            Console.WriteLine();
            Console.WriteLine(this);//with 'this' we use the current instance of our class
        }

        public override string ToString()
        {
            return String.Format(
                "Batery model: {0}{1}Idle Time : {2} Hours{3}Batery life in active mode: {4} Hours{5}Baterry Type: {6}",
                this.Model, Environment.NewLine,
                this.HoursIdle.ToString(), Environment.NewLine,
                this.HoursTalk, Environment.NewLine,
                this.Type);
        }

        //properties

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }//no restriction for model
        }
        public int HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Baterry Life in Idle can't be equal or less than zero hours!");
                }
                this.hoursIdle = value;
            }
        }
        public int HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Baterry Life in active mode can't be equal or less than zero hours!");
                }
                this.hoursTalk = value;
            }
        }

        public BatteryType Type
        {
            get { return this.type; }
            set
            {this.type = value;}//no need for check. In the full argument constructor we are using type of 'BaterryType' so VS won't let as use anything else.
        }
    }
}
