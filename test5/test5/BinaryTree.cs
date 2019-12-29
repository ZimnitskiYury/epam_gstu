using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test5
{
    class BinaryTree<T> where T : IComparable
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
                }
                else Add(_node, _root.Left);
            }
            else
            {
                if (_root.Right == null)
                    _root.Right = _node;
                else
                    Add(_node, _root);
            }
        }
    }
}
