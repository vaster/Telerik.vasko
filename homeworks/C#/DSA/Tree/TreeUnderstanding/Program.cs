using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeUnderstanding
{
    /*
     * You are given a tree of N nodes represented as a set of N-1 pairs of nodes (parent node, child node), each in the range (0..N-1).
     * Example: ...
     * Write a program to read the tree and find:
            the root node
            all leaf nodes
            all middle nodes
            the longest path in the tree
            * all paths in the tree with given sum S of their nodes
            * all subtrees with given sum S of their nodes (not implemented!!!!!!!!!!!!!!!!!!!!!!!!!!!)
*/
    public class Program
    {
        static void Main(string[] args)
        {
            TreeCreator<int> creator = new TreeCreator<int>();
            creator.ConsoleReader();
            Tree<int> sampleTree = creator.CreateTree();

            TreeInterator<int> interator = new TreeInterator<int>(sampleTree);
            Console.WriteLine("Enter sum(int) of elements to look for:");
            int seekedSum = int.Parse(Console.ReadLine());
            interator.DepthFirstSearch(seekedSum);
            Console.WriteLine(interator.NodesInformation);

            Console.WriteLine("Lognest path from root to leaf: " + interator.LongestPathStepCount + " jumps.");

            Console.WriteLine(interator.LongestPathSteps);
            Console.WriteLine("Paths sum equlas to {0}:", seekedSum);
            Console.WriteLine(interator.PathsWithSpecifedSum);
        }
    }
}
