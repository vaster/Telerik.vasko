using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirTree
{
    public class Tree
    {
        public Folder Root { get; private set; }

        public Tree(Folder root)
        {
            this.Root = root;
        }
    }
}
