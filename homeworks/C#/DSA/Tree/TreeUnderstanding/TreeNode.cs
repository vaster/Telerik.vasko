using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeUnderstanding
{
    public class TreeNode<T>
    {
        public T Value { get; private set; }

        public bool HasParrent { get; private set; }

        public bool HasChild { get; private set; }

        private IList<TreeNode<T>> SubItems { get; set; }

        public TreeNode(T element)
        {
            this.Value = element;
            this.HasParrent = false;
            this.SubItems = new List<TreeNode<T>>();
        }

        public void AppendSubItems(TreeNode<T> subItem)
        {
            this.SubItems.Add(subItem);
            foreach (var item in this.SubItems)
            {
                item.HasParrent = true;
            }
            this.HasChild = true;
        }

        public TreeNode<T> GetSubItem(int index)
        {
            return this.SubItems[index];
        }

        public int SubItemsCount
        {
            get
            {
                return this.SubItems.Count;
            }
        }
    }
}
