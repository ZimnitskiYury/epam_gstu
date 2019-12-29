using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test5
{
    public class Node<T> where T : IComparable
    {
        public T Data{get; set;}
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
        public int CompareTo(object obj)
        {

            if (obj is Node<T> name)
            {
                return this.Data.CompareTo(name.Data);
            }
            else throw new Exception("Wrong Input Node");
        }
    }
}
