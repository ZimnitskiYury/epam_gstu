using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test5
{
    public class BinaryTree<T> where T : IComparable
    {
        public Node<T> Root { get; set; }
        public int Count { get; set; }
        public void Add(T data)
        {
            var node = new Node<T>(data);
            if (Root == null)
            {
                Root = node;
                Count = 1;
                return;
            }
            Add(node, Root);
        }
        private void Add(Node<T> node, Node<T> root)
        {
            if (node.CompareTo(root)==-1)
            {
                if (root.Left == null)
                {
                    root.Left = node;
                    Count++;
                }
                else Add(node, root.Left);
            }
            else
            {
                if (root.Right == null)
                {
                    root.Right = node;
                    Count++;
                }
                else
                    Add(node, root.Right);
            }
        }
        public void Clear()
        {
            Root = null;
            Count = 0;
        }
        public void Balance()
        {
            var _temp = new List<T>(Count);
            _temp= InOrder();
            var contains = _temp.Count()-1;
            Clear();
            Balance(_temp, 0, contains);
        }
        private void Balance(List <T> temp, int start, int end)
        {
            if (start > end)
            {
                return;
            }
            int mid = (start + end) / 2;
            Add(temp[mid]);
            Balance(temp, start, mid-1);
            Balance(temp, mid + 1, end);
        }
        public List<T> InOrder()
        {
            var output = new List<T>();
            if (Root != null)
            {
                output = InOrder(Root);
                return output;
            }
            else
            {
                throw new Exception("Empty BinaryTree");
            }
        }
        private List<T> InOrder(Node<T> node)
        {
            var output = new List<T>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    output.AddRange(InOrder(node.Left));
                }
                output.Add(node.Data);
                if (node.Right != null)
                {
                    output.AddRange(InOrder(node.Right));
                }
            }
            return output;
        }
    }
}
