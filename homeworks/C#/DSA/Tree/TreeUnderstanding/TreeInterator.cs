using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeUnderstanding
{
    public class TreeInterator<T>
    {
        private Tree<T> Tree { get; set; }

        public int LongestPathStepCount { get; private set; }

        public StringBuilder PathsWithSpecifedSum { get; private set; }

        public StringBuilder LongestPathSteps { get; private set; }

        public StringBuilder NodesInformation { get; private set; }

        private int SeekedSum { get; set; }

        public TreeInterator(Tree<T> tree)
        {
            this.Tree = tree;
            this.LongestPathStepCount = 0;
            this.LongestPathSteps = new StringBuilder();
            this.PathsWithSpecifedSum = new StringBuilder();
            this.NodesInformation = new StringBuilder();
        }
        /// <summary>
        /// Interate the tree and in the process of interating it:
        ///     find:
        ///         the root node
        ///         all leaf nodes
        ///         all middle nodes
        ///         the longest path in the tree
        ///         all paths in the tree with given sum S of their nodes
        ///         all subtrees with given sum S of their nodes(not implemented !!!!!!!!!!!!!!!!)
        /// </summary>
        /// <param name="seekedSum">Sum to search from the different paths.</param>
        public void DepthFirstSearch(int seekedSum)
        {
            this.SeekedSum = seekedSum;
            int currStepCount = 0;
            StringBuilder currPath = new StringBuilder();
            T currSum = default(T);

            this.DepthFirstSearch(this.Tree.Root, ref currStepCount, ref currPath, ref currSum);
        }

        // by 'path' is understood a combination of nodes that has started from the root and has not
        // been in one node twice. This is how 'path' logic works in this implementation.
        private void DepthFirstSearch(TreeNode<T> currInterator, ref int currStepCount, ref StringBuilder currPath, ref T currSum)
        {
            int seekedSum = this.SeekedSum;
            TreeNode<T> child = null;
            currStepCount++;
          
            currPath.Append(currInterator.Value + "->");
            currSum = currSum.Sum<T>(currInterator.Value);

            for (int index = 0; index < currInterator.SubItemsCount; index++)
            {
                if (currInterator.SubItemsCount != 0)
                {
                    child = currInterator.GetSubItem(index);
                    this.DepthFirstSearch(child, ref currStepCount, ref currPath, ref currSum);
                }
            }
            
            if (currSum.Equals(seekedSum))
            {
                this.PathsWithSpecifedSum.AppendLine(currPath.ToString());
             
            }

            if (currStepCount >= this.LongestPathStepCount)
            {
                this.LongestPathStepCount = currStepCount;
                this.LongestPathSteps.AppendLine(currPath.ToString());
            }
           
            currStepCount--;
            // remove node value from the current path due to recursive stack calls.
            currPath.Replace(currInterator.Value.ToString() + "->","");
            // decrement the current sum with current nodes value due to recursive stack calls.
            currSum = currSum.Sum<T>((object)(-((dynamic)currInterator.Value)));

            if (!currInterator.HasParrent)
            {
               this.NodesInformation.AppendLine("I am the root " + currInterator.Value);
              
            }

            if (currInterator.HasParrent && currInterator.HasChild)
            {
                this.NodesInformation.AppendLine("I am middle Node " + currInterator.Value);
            }

            if (currInterator.HasParrent && (!currInterator.HasChild))
            {
                this.NodesInformation.AppendLine("I am leaf " + currInterator.Value);
            }
        }
    }
}
