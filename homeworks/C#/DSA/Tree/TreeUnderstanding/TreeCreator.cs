using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeUnderstanding
{
    public class TreeCreator<T>
    {
        private Dictionary<T, TreeNode<T>> Nodes { get; set; }

        /// <summary>
        /// Reads from the console node connections and save the connections
        /// between the nodes at appropriate way in a dictionary.
        /// </summary>
        public void ConsoleReader()
        {
            int nodeCount = int.Parse(Console.ReadLine());
            string input = null;
            string[] nodeConnection = null;

            this.Nodes = new Dictionary<T, TreeNode<T>>();

            for (int nodeNumber = 0; nodeNumber < nodeCount - 1; nodeNumber++)
            {
                input = Console.ReadLine();
                nodeConnection = input.Split(' ');

                T currRootItem = (T)Convert.ChangeType(nodeConnection[0], typeof(T));
                T subItem = (T)Convert.ChangeType(nodeConnection[1], typeof(T));

                TreeNode<T> currRoot = null;
                TreeNode<T> currSubItem = null;

                if (this.Nodes.ContainsKey(currRootItem))
                {
                    currRoot = this.Nodes[currRootItem];
                }
                else
                {
                    currRoot = new TreeNode<T>(currRootItem);
                    this.Nodes.Add(currRootItem, currRoot);
                }
                if (this.Nodes.ContainsKey(subItem))
                {
                    currSubItem = this.Nodes[subItem];
                }
                else
                {
                    currSubItem = new TreeNode<T>(subItem);
                    this.Nodes.Add(subItem, currSubItem);
                }

                currRoot.AppendSubItems(currSubItem);
            }
        }

        /// <summary>
        /// Create a tree from the information read from the ConsoleReader method.
        /// </summary>
        /// <returns>Tree structure.</returns>
        public Tree<T> CreateTree()
        {
            Tree<T> tree = null;
            TreeNode<T> root = this.FindRoot();

            tree = new Tree<T>(root);

            return tree;
        }

        private TreeNode<T> FindRoot()
        {
            TreeNode<T> root = null;

            foreach (var item in this.Nodes.Values)
            {
                if (!item.HasParrent)
                {
                    root = item;
                    break;
                }
            }
            return root;
        }
    }
}
