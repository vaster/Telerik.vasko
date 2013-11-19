using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.AdvenceOperations
{
    public class Calculation<T>
        where T : struct // constrains for value types
    {
        private T x;

        // constructor
        public Calculation(T x)
        {
            this.X = x;
        }

        // methods
        public void CalculateSquareRoot()
        {
            Math.Sqrt((dynamic)this.X);
        }

        public void CalculateNaturalLogarithm()
        {
            Math.Log((dynamic)this.X, Math.E);
        }

        public void CalculateSinus()
        {
            Math.Sin((dynamic)this.X);
        }

        // properties
        public T X
        {
            get
            {
                return this.x;
            }
            private set
            {
                if (value.Equals(null))
                {
                    throw new NullReferenceException("'x' can'be null!");
                }
                this.x = value;
            }
        }
    }
}
