using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace _1.FriendsOfPesho
{
    public class Edge
    {
        public int EdgeDistance { get; private set; }

        public Node Destination { get; private set; }


        public Edge(Node destination, int edgeDistance)
        {
            this.EdgeDistance = edgeDistance;
            this.Destination = destination;
        }
    }

    public class Mapper
    {
        private UndirectedGraph Graph { get; set; }

        public Node Source { get; set; }

        private OrderedBag<Node> Base { get; set; }

        public Mapper(UndirectedGraph graph)
        {
            this.Graph = graph;
            this.Base = new OrderedBag<Node>();
        }

        public void MakeMapping(Node source = null)
        {
           
            this.InitializeBase();

            while (this.Base.Count > 0)
            {

                Node currNode = this.Base.GetFirst();

                if (currNode.Id == int.MaxValue)
                {
                    break;
                }

                int possibleMinimalDistance = 0;

                foreach (Edge currEdge in currNode.Edges)
                {
                    possibleMinimalDistance = 0;
                    possibleMinimalDistance = currNode.ShortestDistence + currEdge.EdgeDistance;

                    if (possibleMinimalDistance < currEdge.Destination.ShortestDistence)
                    {
                        currEdge.Destination.ShortestDistence = possibleMinimalDistance;
                        this.Base.Clear();
                        this.InitializeBase();
                    }
                }

                this.Base.RemoveFirst();
            }

        }

        public void SetShortestDistancesToDefautlt()
        {
            this.Source.ShortestDistence = 0;

            foreach (Node item in this.Graph.Nodes)
            {
                if (item.Id != this.Source.Id)
                {
                    item.ShortestDistence = int.MaxValue;
                }
            }
        }

        private void InitializeBase()
        {
            foreach (Node item in this.Graph.Nodes)
            {
                this.Base.Add(item);
            }
        }
    }

    public class UndirectedGraph
    {
        public List<Node> Nodes { get; private set; }

        public UndirectedGraph()
        {
            this.Nodes = new List<Node>();
        }

        public void Add(Node node)
        {
            this.Nodes.Add(node);
        }
    }

    public class Node : IComparable<Node>, IEquatable<Node>
    {
        public int Id { get; private set; }

        public int ShortestDistence { get; set; }

        public List<Edge> Edges { get; private set; }

        public bool IsHospital { get; private set; }

        public Node(int id, bool isHospital)
        {
            this.Id = id;
            this.Edges = new List<Edge>();
            this.IsHospital = isHospital;
        }

        public void AddConnection(Edge currEdge)
        {
            this.Edges.Add(currEdge);
        }

        public int CompareTo(Node other)
        {
            if (this.ShortestDistence > other.ShortestDistence)
            {
                return 1;
            }
            if (this.ShortestDistence < other.ShortestDistence)
            {
                return -1;
            }

            return 0;
        }


        public bool Equals(Node other)
        {
            if (this.Id == other.Id)
            {
                return true;
            }

            return false;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            string streetsAndBuildingsInput = Console.ReadLine();
            string[] streetAndBuildings = streetsAndBuildingsInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int countOfBuildings = Convert.ToInt32(streetAndBuildings[0]);
            int countOfStreets = Convert.ToInt32(streetAndBuildings[1]);
            int countOfHospitals = Convert.ToInt32(streetAndBuildings[2]);

            int countOfHaouses = countOfBuildings - countOfHospitals;

            List<Node> buildings = new List<Node>();

            string hospitalIds = null;
            Node hospital = null;


            hospitalIds = Console.ReadLine();
            string[] hospitalId = hospitalIds.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
         
            for (int i = 0; i < hospitalId.Length; i++)
            {
                hospital = new Node(int.Parse(hospitalId[i]), true);
                buildings.Add(hospital);
            }



            //List<Node> houses = new List<Node>();
            int houseId = 0;
            Node house = null;

            for (int currHouse = 0 + 1; currHouse <= countOfBuildings; currHouse++)
            {
                houseId = currHouse;
                house = new Node(houseId, false);
                if (!buildings.Contains(house))
                {
                    buildings.Add(house);
                }
            }

            string[] streets = null;
            string street = null;
            for (int currStreet = 0; currStreet < countOfStreets; currStreet++)
            {
                street = Console.ReadLine();
                streets = street.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Node source = null;
                foreach (Node item in buildings)
                {
                    if (item.Id == int.Parse(streets[0]))
                    {
                        source = item;
                        break;
                    }
                }
                //
                foreach (Node item in buildings)
                {
                    if (item.Id == int.Parse(streets[1]))
                    {
                        {
                            source.AddConnection(new Edge(item, int.Parse(streets[2])));
                            item.AddConnection(new Edge(source, int.Parse(streets[2])));
                        }
                        break;
                    }
                }
            }

            UndirectedGraph graph = new UndirectedGraph();

            foreach (Node item in buildings)
            {
                graph.Add(item);
            }

            bool allow = true;
            Mapper mapper = new Mapper(graph);
            int result = 0;
            int maxResult = int.MaxValue;
            foreach (Node item in graph.Nodes)
            {
                if (item.IsHospital)
                {
                    mapper.Source = item;
                    //if (allow)
                    {
                        mapper.SetShortestDistancesToDefautlt();
                        allow = false;
                    }
                    mapper.MakeMapping();
                    result = 0;
                    foreach (Node item2 in graph.Nodes)
                    {
                        if (!item2.IsHospital)
                        {
                            result = result + item2.ShortestDistence;
                        }
                    }
                    if (maxResult > result)
                    {
                        maxResult = result;
                    }
                }
            }

            Console.WriteLine(maxResult);
        }
    }
}
