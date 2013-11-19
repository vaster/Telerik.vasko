using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankingMechanism
{
    public class Bank<T> : IEnumerable<T>
        where T:Account
    {
        private List<T> acc = new List<T>();

        public Bank(List<T> acc)
        {
            this.acc = acc;
        }
        //implement IEnumerable
        public int Count { get { return acc.Count; } }

        public IEnumerator<T> GetEnumerator()
        {
            return this.acc.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

}
