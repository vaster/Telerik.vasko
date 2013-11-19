namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
          sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            foreach (var element in items)
            {
                if (element.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public bool BinarySearch(T item)
        {
            bool founded = false;
            this.GoDeep(items, item, ref founded);

            return founded;
        }

        private void GoDeep(IList<T> collection, T item, ref bool founded)
        {
            List<T> befour = new List<T>();
            List<T> after = new List<T>();

            T seekedElement = default(T);

            int middleIndex = collection.Count / 2;
            if (collection.Count != 0)
            {
                seekedElement = collection[middleIndex];
                if (seekedElement.CompareTo(item) == 0)
                {
                    founded = true;
                }

                for (int i = 0; i < middleIndex; i++)
                {
                    befour.Add(collection[i]);
                }
                for (int i = middleIndex + 1; i < collection.Count; i++)
                {
                    after.Add(collection[i]);
                }

                GoDeep(befour, item, ref founded);
                GoDeep(after, item, ref founded);
            }
        }

        // Complexity is O(n)
        public void Shuffle()
        {
            Random randomGenerator = new Random();
            T tmp = default(T);
            int randomIndex = 0;
            for (int i = 0; i < items.Count; i++)
            {
               tmp = items[i];
               randomIndex = randomGenerator.Next(0,items.Count - 1);
               items[i] = items[randomIndex];
               items[randomIndex] = tmp;
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
