using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.MostPopularFriend
{

    public class Edge
    {
        public Node Destination { get; private set; }

        public Edge(Node destination)
        {
            this.Destination = destination;
        }
    }

    public class Node
    {
        public int Id { get; private set; }

        public int Popularity { get; set; }

        public List<Edge> Edges { get; private set; }

        public Node(int id)
        {
            this.Id = id;
            this.Edges = new List<Edge>();
        }

        public void AddConnection(Edge edge)
        {
            this.Edges.Add(edge);
        }
    }

    public class Program
    {
        public static int bestPopularity = 0;

        public static int currPopulity = 0;

        public static void Traverse(Node[] nodes)
        {

            bool[] visited = new bool[nodes.Length];
            int cycles = 0;
            //foreach (Node item in nodes)
            {
                Program.Traverse(nodes, visited, ref cycles);
            }
        }

        private static void Traverse(Node[] start, bool[] visited, ref int cycles)
        {
            foreach (Node item in start)
            {
                visited = new bool[start.Length];
                visited[item.Id - 1] = true;
                foreach (Edge innerItem in item.Edges)
                {
                    if (!visited[innerItem.Destination.Id - 1])
                    {
                        currPopulity++;
                        visited[innerItem.Destination.Id - 1] = true;
                        foreach (Edge inner2 in innerItem.Destination.Edges)
                        {
                            if (!visited[inner2.Destination.Id - 1])
                            {
                                currPopulity++;
                                visited[inner2.Destination.Id - 1] = true;
                                break;
                            }
                        }  
                    }
                }

                if (currPopulity > bestPopularity)
                {
                    bestPopularity = currPopulity;
                    
                }
                currPopulity = 0;
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Node[] nodes = new Node[n];
            Node currNode = null;
            for (int i = 0; i < n; i++)
            {
                currNode = new Node(i + 1);
                currNode.Popularity = 1;
                nodes[i] = currNode;
            }

            for (int i = 0; i < n; i++)
            {
                string relativity = Console.ReadLine();

                for (int charSymbol = 0; charSymbol < relativity.Length; charSymbol++)
                {
                    if (relativity[charSymbol] == 'Y')
                    {
                        nodes[i].AddConnection(new Edge(nodes[charSymbol]));
                    }
                }
            }

            Program.Traverse(nodes);

            Console.WriteLine(bestPopularity);
        }
    }
}
