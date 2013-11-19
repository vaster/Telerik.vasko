using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeUnderstanding
{
    public class Tree<T>
    {
        public TreeNode<T> Root { get; private set; }

        public Tree(TreeNode<T> root)
        {
            this.Root = root;
        }
    }
}
