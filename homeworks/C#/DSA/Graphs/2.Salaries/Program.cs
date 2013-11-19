using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Salaries
{
    public class Edge
    {
        public Node Destination { get; private set; }

        public Edge(Node destination)
        {
            this.Destination = destination;
        }
    }

    public class Node : IEquatable<Node>, IComparable<Node>
    {
        public int Id { get; private set; }

        public int Sellary { get; set; }

        public bool Visited { get; set; }

        public Node(int id)
        {
            this.Id = id;
            this.Sellary = 0;
        }

        public bool Equals(Node other)
        {
            if (this.Id == other.Id)
            {
                return true;
            }

            return false;
        }

        public int CompareTo(Node other)
        {
            if (this.Id > other.Id)
            {
                return 1;
            }
            if (this.Id < other.Id)
            {
                return -1;
            }
            return 0;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string relativity = null;
            Node currNode = null;

            Dictionary<Node, List<Edge>> graph = new Dictionary<Node, List<Edge>>();

            Node sub = null;

            for (int i = 0; i < n; i++)
            {
                currNode = new Node(i + 1);
                if (!graph.ContainsKey(currNode))
                {
                    graph.Add(currNode, new List<Edge>());
                }
                relativity = Console.ReadLine();

                int coeff = 0;


                if (relativity.Contains('Y'))
                {
                    foreach (char symbol in relativity)
                    {
                        coeff++;
                        if (symbol == 'Y')
                        {
                            sub = new Node(coeff);
                            if (graph.ContainsKey(sub))
                            {
                                foreach (Node item in graph.Keys)
                                {
                                    if (item.Equals(sub))
                                    {
                                        graph[currNode].Add(new Edge(item));
                                        break;
                                    }
                                }

                            }
                            else
                            {
                                graph[currNode].Add(new Edge(sub));
                                graph.Add(sub, new List<Edge>());
                            }
                        }
                    }
                }
                else
                {
                    if (graph.ContainsKey(currNode))
                    {
                        foreach (Node item in graph.Keys)
                        {
                            if (item.Equals(currNode))
                            {
                                item.Sellary = 1;
                                break;
                            }
                        }
                    }
                }
            }


            Traverser(graph, n);
            int result = 0;

            foreach (var item in graph)
            {
                result = result + item.Key.Sellary;
            }

            Console.WriteLine(result);

        }
        public static void Traverser(Dictionary<Node, List<Edge>> graph, int n)
        {
            int salarayCount = 0;
            bool go = true;
           while (go)
            {
                foreach (var item in graph)
                {
                    if (item.Key.Sellary == 0)
                    {
                        Traverse(item.Key, graph, ref salarayCount, n);
                    }
                }

                foreach (var item in graph)
                {
                    if (item.Key.Sellary == 0)
                    {
                        go = true;
                        break;
                    }
                }

                go = false;
            }
        }

        private static void Traverse(Node startNode, Dictionary<Node, List<Edge>> graph, ref int salaryCount, int n)
        {

            if (salaryCount >= n)
            {
                return;
            }

            foreach (Edge item in graph[startNode])
            {
                
                if (item.Destination.Sellary == 0)
                {
                    Traverse(item.Destination, graph, ref salaryCount, n);
                }
                startNode.Sellary = startNode.Sellary + item.Destination.Sellary;
                //salaryCount++;
            }
        }
    }
}
