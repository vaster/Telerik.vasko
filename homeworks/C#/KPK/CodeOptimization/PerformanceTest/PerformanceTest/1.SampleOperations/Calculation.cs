using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SampleOperations
{
    public class Calculation<T>
        where T : struct // constrains for value types
    {
        private T x;
        private T y;

        // constructor
        public Calculation(T x, T y)
        {
            this.X = x;
            this.Y = y;
        }

        // methods   
        public void AddTwoNumbers()
        { 
            T result =  (dynamic)this.X + (dynamic)this.Y;
        }

        public void DivideTwoNumbers()
        {
            T result = (dynamic)this.X - (dynamic)this.Y;
        }

        public void SubstractTwoNumbers()
        {
            T result = (dynamic)this.X / (dynamic)this.Y;
        }

        public void MultiplyTwoNumbers()
        {
            T result = (dynamic)this.X * (dynamic)this.Y;
        }

        public void Increment()
        {
            T result = (dynamic)this.X + 1;
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
                    throw new NullReferenceException("'x' can't be null");
                }
                this.x = value;
            }
        }

        public T Y
        {
            get
            {
                return this.y;
            }
            private set
            {
                if (value.Equals(null))
                {
                    throw new NullReferenceException("'y' can't be null");
                }
                this.y = value;
            }
        }
    }
}
