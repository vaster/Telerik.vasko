using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.LinkedOut
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
        public string Id { get; private set; }

        public bool Visited { get; set; }

        public List<Edge> Edges { get; private set; }

        public Node(string id)
        {
            this.Id = id;
            this.Edges = new List<Edge>();
            this.Visited = false;
        }

        public void AddConection(Edge edge)
        {
            this.Edges.Add(edge);
        }
    }

    public class Program
    {

        public static int countOfMoves = 0;
        public static List<int> result = new List<int>();
        public static Node start = null;
        public static bool notConnected = true;

        public static void Traverse(Dictionary<string, Node> graph, Node target, Node lookFor)
        {

            if (graph[target.Id].Visited)
            {
                return;
            }

            countOfMoves++;
            graph[target.Id].Visited = true;
            foreach (var item in graph[target.Id].Edges)
            {
                if (item.Destination.Id == lookFor.Id)
                {
                    result.Add(countOfMoves);
                    countOfMoves = 0;
                    return;
                }
            }
            
            foreach (var item in graph[target.Id].Edges)
            {
                Traverse(graph, item.Destination, lookFor);
            }

            
        }

        //public static void Traverse(Dictionary<string, Node> graph, Node currNode, Node lookFor)
        //{

        //}

        static void Main(string[] args)
        {

            string targetName = Console.ReadLine();
            Node target = null;

            Dictionary<string, Node> graph = new Dictionary<string, Node>();

            int n = int.Parse(Console.ReadLine());

            string[] connection = null;

            Node firstConnection = null;
            Node secondConnetcion = null;

            for (int i = 0; i < n; i++)
            {
                connection = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                firstConnection = new Node(connection[0]);
                secondConnetcion = new Node(connection[1]);

                if (!graph.ContainsKey(connection[0]))
                {
                    if (connection[0] == targetName)
                    {
                        target = firstConnection;
                        start = target;
                    }
                    graph.Add(connection[0], firstConnection);
                }
                if (!graph.ContainsKey(connection[1]))
                {
                    graph.Add(connection[1], secondConnetcion);
                }
                graph[connection[0]].AddConection(new Edge(graph[connection[1]]));
                graph[connection[1]].AddConection(new Edge(graph[connection[0]]));

            }

            int m = int.Parse(Console.ReadLine());
            List<Node> lookFor = new List<Node>();


            Node currLookFor = null;
            string currLookForName = null;

            for (int i = 0; i < m; i++)
            {
               
                currLookForName = Console.ReadLine();
                currLookFor = new Node(currLookForName);
                ////////////////////////////////////
                Traverse(graph, target, currLookFor);
                ////////////////////////////////////
                lookFor.Add(currLookFor);

                notConnected = true;
                foreach (var item in graph)
                {
                    if (item.Value.Visited == false)
                    {
                        notConnected = false;
                    }
                    item.Value.Visited = false;
                }
                if (notConnected)
                {
                    result.Add(-1);
                    countOfMoves = 0;
                }
            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
