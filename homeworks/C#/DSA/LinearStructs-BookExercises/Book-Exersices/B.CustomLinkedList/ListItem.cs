using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.CustomLinkedList
{
    public class ListItem<T>
    {
        public T Value { get; private set; }

        public ListItem<T> NextItem { get; set; }

        public ListItem(T element)
        {
            this.Value = element;
            this.NextItem = null;
        }
    }
}
