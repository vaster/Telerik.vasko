using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.PhoneBook
{
    public class PhoneBook<T>
    {
        private class KeyNameValueTownValuePhone<T>
        {
            public T KeyName { get; set; }

            public T ValueTown { get; set; }

            public T ValuePhone { get; set; }

            public KeyNameValueTownValuePhone(T name, T town, T number)
            {
                this.KeyName = name;
                this.ValueTown = town;
                this.ValuePhone = number;
            }
        }

        public int Count { get; private set; }

        private const int INITIALCAPACITY = 8;

        private LinkedList<KeyNameValueTownValuePhone<T>>[] Base { get; set; }

        public PhoneBook()
        {
            this.Base = new 
                LinkedList<KeyNameValueTownValuePhone<T>>[PhoneBook<T>.INITIALCAPACITY];
            this.Count = 0;
        }

        public void Add(T name, T town, T phone)
        {

            //int index = some hashcode generator

            KeyNameValueTownValuePhone<T> entry = new KeyNameValueTownValuePhone<T>(name,town,phone);

            LinkedListNode<KeyNameValueTownValuePhone<T>> currNode =
                new LinkedListNode<KeyNameValueTownValuePhone<T>>(entry);

            if (this.Base[0/*index*/] == null)
            {
                this.Base[0] = new LinkedList<KeyNameValueTownValuePhone<T>>();
                this.Count++;
            }

            this.Base[0/*index*/].AddLast(currNode);
        }
    }
}
