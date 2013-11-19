using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class Display
    {
        private int size;
        private int numberOfColors;


        public Display() //empty constructor
        {
            this.Size = 0;
            this.NumberOfColors = 0;
        }
        public Display(int size, int numberOfColors) //full argument constructor
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }



        public void PrintDisplayInfo()
        {
            Console.WriteLine();
            Console.WriteLine(this);//with 'this' we use the current instance of our class
        }

        public override string ToString()
        {
            return String.Format(
                "Display Size: {0} inches{1}Number of Colors : {2}",
                this.Size, Environment.NewLine,
                this.NumberOfColors);
        }

        //proparties
        
        public int Size
        {
            get { return this.size; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Size of display can't be lower than zero!");
                }
                this.size = value;
            }
        }

        public int NumberOfColors
        {
            get { return this.numberOfColors; }
            set
            {
                if (value <=0)
                {
                    throw new Exception("Number of colors can't be lower than one!");
                }
                this.numberOfColors = value;
            }
        }
    }
}
