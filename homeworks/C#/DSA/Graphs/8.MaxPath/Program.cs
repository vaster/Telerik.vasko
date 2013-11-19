using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.MaxPath
{
    public class Node : IComparable<Node>, IEquatable<Node>
    {
        public int Value { get; private set; }

        public bool HasParrent { get; set; }

        public Node(int value)
        {
            this.Value = value;
        }


        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }

        public int CompareTo(Node other)
        {
            if (this.Value > other.Value)
            {
                return 1;
            }
            if (this.Value < other.Value)
            {
                return -1;
            }

            return 0;
        }

        public bool Equals(Node other)
        {
            if (this.Value == other.Value)
            {
                return true;
            }

            return false;
        }
    }

   

    public class Program
    {
        public static long Sum = 0;
        public static long CurrMaxSum = 0;
        public static long MaxSum = 0;
        public static List<long> golder = new List<long>();

        public static Node Root;

        public static void Traverser(Dictionary<Node, List<Node>> tree)
        {
            foreach (KeyValuePair<Node, List<Node>> item in tree)
            {
                if (!item.Key.HasParrent)
                {
                    Root = item.Key;
                    Traverser(tree, item.Key);
                }
            }
        }

        private static void Traverser(Dictionary<Node, List<Node>> tree, Node child)
        {
            foreach (var item in tree[child])
            {
                Sum = Sum + item.Value;
                Traverser(tree, item);
                if (Sum > CurrMaxSum)
                {
                    CurrMaxSum = Sum;
                }
                Sum = Sum - item.Value;
                if (Sum == 0)
                {
                    MaxSum = CurrMaxSum;
                    golder.Add(MaxSum);
                    CurrMaxSum = 0;
                }
            }
        }

        static void Main(string[] args)
        {
            Dictionary<Node, List<Node>> tree = new Dictionary<Node, List<Node>>();

            int n = int.Parse(Console.ReadLine()) - 1;
            string[] input = null;
            Node firstNode = null;
            Node secondNode = null;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(new char[] { ' ', '-', '<', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

                firstNode = new Node(int.Parse(input[0]));
                secondNode = new Node(int.Parse(input[1]));

                foreach (var item in tree)
                {
                    if (item.Key.Equals(firstNode))
                    {
                        firstNode = item.Key;
                        break;
                    }
                    if (item.Key.Equals(secondNode))
                    {
                        secondNode = item.Key;
                        item.Key.HasParrent = true;
                        break;
                    }
                }

                if (!tree.ContainsKey(firstNode))
                {
                    tree.Add(firstNode, new List<Node>());
                }
                if (!tree.ContainsKey(secondNode))
                {
                    tree.Add(secondNode, new List<Node>());
                }
                secondNode.HasParrent = true;
                tree[firstNode].Add(secondNode);

            }

            Traverser(tree);

            golder.Sort();
            if (golder.Count == 1)
            {
                Console.WriteLine(golder[0] + Root.Value);
            }
            else
            {
                Console.WriteLine(golder[golder.Count - 1] + golder[golder.Count -2 ] + Root.Value);
            }

        }
    }
}
