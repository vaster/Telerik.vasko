using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DirTree
{
    // Not working !

    /*
     * Define classes File { string name, int size } 
     * and Folder { string name, File[] files, Folder[] childFolders } 
     * and using them build a tree keeping all files and folders on the hard drive starting from C:\WINDOWS.
     * Implement a method that calculates the sum of the file sizes in given subtree of the tree and test it accordingly.
     * Use recursive DFS traversal.
    */
    public class Program
    {
        public const string PATH = @"C:\WINDOWS";

        static void Main(string[] args)
        {
            DirTreeCreator creator = new DirTreeCreator(Program.PATH);
            Tree tree = creator.Create();

            Sumator sumator = new Sumator(tree,"WINDOWS");

            BigInteger sizeOfFiles = sumator.GetSum();

            Console.WriteLine(sizeOfFiles);
        }
    }
}
