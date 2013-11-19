using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.CustomLinkedList
{
    public class CustomLinkedList<T> : ICustomLinkedList<T>
    {
        public ListItem<T> FirstElement { get; private set; }

        public int Count { get; private set; }

        private ListItem<T> CurrElement { get; set; }

        public CustomLinkedList()
        {
            this.FirstElement = null;
            this.CurrElement = null;
            this.Count = 0;
        }

        public void Add(T element)
        {

            if (this.FirstElement == null)
            {
                this.FirstElement = new ListItem<T>(element);
                this.CurrElement = this.FirstElement;
            }
            else
            {
                this.CurrElement.NextItem = new ListItem<T>(element);
                this.CurrElement = this.CurrElement.NextItem;
            }

            this.Count++;
        }


        public ListItem<T> this[int index]
        {
            get
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid position! Index must be in range [0 - {0}]", 
                        this.Count - 1));
                }
                ListItem<T> seekedItem = this.FirstElement;
                int indexer = 0;

                while (seekedItem.NextItem != null)
                {
                    if (indexer == index)
                    {
                        break;
                    }
                    seekedItem = seekedItem.NextItem;
                    indexer++;
                }
                return seekedItem;
            }
        }

        public void Insert(int index, T element)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException(String.Format("Invalid position! Index must be in range [0 - {0}]",
                    this.Count - 1));
            }
            if (index == 0)
            {
                throw new InvalidOperationException(String.Format("Inserting an element at the position of the head of the List is not allowed!"));
            }

            // taking the element at position befour breaking the chain
            ListItem<T> startChainElement = this[index-1];
            // store the old element at the position for insertion
            ListItem<T> elementToBeOffseted = startChainElement.NextItem;
            // creating new instance for the new next item, so no reference mess up to be expected
            startChainElement.NextItem = new ListItem<T>(element);
            // making the new instance's next item to point the rest of the chain where it was broken
            startChainElement.NextItem.NextItem = elementToBeOffseted;
            this.Count++;
        }

        public void Remove(T element)
        {
            ListItem<T> seekedItem = this.FirstElement;
            int index = 0;
            
            while (seekedItem != null)
            {
                if (seekedItem.Value.Equals(element))
                {
                    break;
                }
                seekedItem = seekedItem.NextItem;
                index++;
            }

            // another way is by not using indexer, but another ListItem storing previouse element -> double linked list.
            // double linked list should be faster.
            if (index != 0)
            {
                ListItem<T> startChainBreakElement = this[index - 1];
                ListItem<T> afterChainBreakElement = seekedItem.NextItem;
                startChainBreakElement.NextItem = afterChainBreakElement;
                seekedItem = null;
            }
            else
            {
                this.FirstElement = this.FirstElement.NextItem;
            }
            this.Count--;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException(String.Format("Invalid position! Index must be in range [0 - {0}]",
                    this.Count - 1));
            }

            ListItem<T> seekedItem = this[index];
            this.Remove(seekedItem.Value);
        }

        public void Clear()
        {
            int indexHead = 0;
            
            // we change the count dynamicly when removing elements.
            while (this.Count > 0)
            {
                // aways remove the head of the list, because of the re-arrange
                this.RemoveAt(indexHead);
            } 
        }

        public bool Contains(T element)
        {
            ListItem<T> seekedItem = this.FirstElement;

            while (seekedItem != null)
            {
                if (seekedItem.Value.Equals(element))
                {
                    return true;
                }
                seekedItem = seekedItem.NextItem;
            }

            return false;
        }
    }
}
