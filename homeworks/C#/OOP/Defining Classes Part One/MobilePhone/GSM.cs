using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class GSM
    {
        static private int indexOfLongestCall = -1;
        static private int max = int.MinValue;

        public const double chargePerMinute = 0.37;
        private string model = null;
        private string manufacturer = null;
        private int price = 0;
        private string owner = null;
        static private GSM iPhone4S = new GSM("Iphone4S", "Apple", 700, "Apple Corp."); //creating static filed of type 'GSM' that holds the info about Iphone
        static private List<Call> callHistory = new List<Call>();
        static private double totalBill = 0;

        Baterry baterryInfo = new Baterry("Model One", 10, 5, BatteryType.Lion); //creating instance of class Baterry
        Display displayInfo = new Display(7, 65000); //creating instance of class Display
        
        //constructors
        public GSM(string model, string manufacturer, int price, string owner) //full argument constructor
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;

        }
        public GSM(string model, string manufacturer, int price) //variant one of not a full argument constructor
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;


        }
        public GSM(string model, string manufacturer, string owner) //varinat two of not a full argument constructor
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Owner = owner;

        }
        public GSM(string model, string manufacturer) //varinat three of not a full argument constructor
        {
            this.Model = model;
            this.Manufacturer = manufacturer;

        }



        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        //methods

        public void PrintGSMInfo()
        {
            Console.WriteLine(this);//with 'this' we use the current instance of our class, this equals to 'instanceOfGSM'.toString();
            
        }

        static public void AddCall()
        {

            Call thisCall = new Call();
            string anotherCall = null;
            Console.WriteLine();
            Console.WriteLine("You're in mode: Add Call");
            Console.WriteLine();
            Console.Write("Enter Date of the call:");
            thisCall.Date = Console.ReadLine();
            Console.Write("Enter the time when the call was made:");
            thisCall.Time = Console.ReadLine();
            Console.Write("Enter Phone number of the call reciver:");
            thisCall.DialedNumber = Console.ReadLine();
            Console.Write("Enter duration of the call(in seconds):");
            thisCall.Duration = int.Parse(Console.ReadLine());
            if (max < thisCall.Duration)
            {
                max = thisCall.Duration;
                indexOfLongestCall++;  //use this index to dell the longest call later in the 'RemoveCall' method

            }
            thisCall = new Call(thisCall.Date, thisCall.Time, thisCall.DialedNumber, thisCall.Duration);//invoke full argument constructor of class 'Call'
            CallHistory.Add(thisCall);//add the call in List<Call>
            Console.WriteLine();
            Console.Write("Add another call? Type 'yes' to proceed('no' for exit): ");
            anotherCall = Console.ReadLine().ToLower();
            if (anotherCall.Equals("yes"))
            {
                //Bill();
                GSM.AddCall();
            }

        }
        static public double Bill()
        {
            TotalBill = 0;
            for (int i = 0; i < callHistory.Count; i++)
            {
                TotalBill = TotalBill + (CallHistory[i].Duration/60) * chargePerMinute;// divide by 60 to calculate for a minute
            }

            return TotalBill;
        }
        static public void RemoveCall()
        {
            CallHistory.RemoveAt(indexOfLongestCall);
        }
        static public void RemoveAllCalls()
        {
            CallHistory.RemoveRange(0, CallHistory.Count);
        }

        public void PrintCallHistory()
        {
            for (int i = 0; i < CallHistory.Count; i++)
            {
                CallHistory[i].PrintCall();
            }
        }

        public override string ToString()
        {

            return String.Format(
                "GSM model: {0}{1}Manufacturer: {2}{3}Owner: {4}{5}Price: {6:C}",
                this.Model, Environment.NewLine,
                this.Manufacturer, Environment.NewLine,
                this.Owner, Environment.NewLine,
                this.Price);
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||


        //properties

        public string Model
        {
            get { return this.model; }
            set
            {
                if (value.Equals(string.Empty))
                {
                    throw new ArgumentNullException("Model can't be blank!");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value.Equals(string.Empty))
                {
                    throw new ArgumentNullException("Manufacturer can't be blank!");
                }
                this.manufacturer = value;
            }
        }


        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (value.Length <= 2)
                {
                    throw new FormatException("Name of the owner must be longer than 2 symbols!");
                }
                this.owner = value;
            }
        }

        public int Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new FormatException("Price must be a positive number!");
                }
                this.price = value;
            }
        }
        private static double TotalBill
        {
            get { return totalBill; }
            set { totalBill = value; }
        }


        static public GSM Iphone4S
        {
            get { return iPhone4S; }
        }

        public static List<Call> CallHistory
        {
            get { return callHistory; }
            set { callHistory = value; }
        }

        public Baterry BaterryInfo
        {
            get { return this.baterryInfo; }
        }
        public Display DisplayInfo
        {
            get { return this.displayInfo; }
        }

    }
}
