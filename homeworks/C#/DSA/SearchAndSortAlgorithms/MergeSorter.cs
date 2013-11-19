namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
       
        public void Sort(IList<T> collection)
        {
            this.DivideCollection(collection);
        }

        private void DivideCollection(IList<T> collection)
        {
            if (collection.Count == 1)
            {
                return;
            }

            IList<T> leftPart = new List<T>();
            IList<T> rightPart = new List<T>();

            int middleIndex = collection.Count / 2;

            for (int i = 0; i < middleIndex; i++)
            {
                leftPart.Add(collection[i]);
            }

            for (int i = middleIndex; i < collection.Count; i++)
            {
                rightPart.Add(collection[i]);
            }

            this.DivideCollection(leftPart);
            this.DivideCollection(rightPart);

            for (int i = collection.Count - 1; i >= 0; i--)
            {
                if (leftPart.Count == 0)
                {
                    collection[i] = rightPart.Last();
                    rightPart.Remove(rightPart.Last());
                }
                else if (rightPart.Count == 0)
                {
                    collection[i] = leftPart.Last();
                    leftPart.Remove(leftPart.Last());
                }
                else if (leftPart.Last().CompareTo(rightPart.Last()) > 0)
                {
                    collection[i] = leftPart.Last();
                    leftPart.Remove(leftPart.Last());
                }
                else
                {
                    collection[i] = rightPart.Last();
                    rightPart.Remove(rightPart.Last());
                }
            }
        }
    }
}
