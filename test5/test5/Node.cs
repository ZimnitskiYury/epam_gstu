using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test5
{
    public class Node<T> where T : IComparable
    {
        public T Data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public Node(T data)
        {
            Data = data;
        }
        public Node(T data, Node<T> left, Node<T> right)
        {
            Data = data;
            Left = left;
            Right = right;
        }
        public int CompareTo(Node<T> other)
        {
            if (other is Node<T> c)
            {
                return this.Data.CompareTo(c.Data);
            }
            else throw new Exception("Wrong node");
        }
    }
}
