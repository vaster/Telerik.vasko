using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.MostPopularFriend
{
    public class Graph
    {
        public List<Node> Nodes { get; private set; }

        public Graph()
        {
            this.Nodes = new List<Node>();
        }

        public void Add(Node node)
        {
            this.Nodes.Add(node);
        }
    }
}
