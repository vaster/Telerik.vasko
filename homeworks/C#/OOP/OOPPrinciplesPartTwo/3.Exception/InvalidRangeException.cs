using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Exception
{
    public class InvalidRangeException<T> : System.Exception
    {
        private T start;
        private T end;

        //constructor
        public InvalidRangeException(string msg,System.Exception innerEx)
            : base(msg,innerEx)
        {

        }
        public InvalidRangeException(string msg, T start, T end)
            :base(msg)
        {
            this.Start = start;
            this.End = end;
        }

        //properties

        private T Start
        {
            get { return this.start; }
            set { this.start = value; }
        }

        private T End
        {
            get { return this.end; }
            set { this.end = value; }
        }
    }
}
