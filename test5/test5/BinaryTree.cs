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
        public void Add(Node<T> _node, Node<T> _root)
        {
            if (_node.CompareTo(_root) == -1)
            {
                if (_root.Left == null)
                {
                    _root.Left = _node;
                    Count++;
                }
                else Add(_node, _root.Left);
            }
            else
            {
                if (_root.Right == null)
                {
                    _root.Right = _node;
                    Count++;
                }
                else
                    Add(_node, _root);
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
            var contains = _temp.Count();
            Clear();
            Balance(_temp, 1, contains);
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
