using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Classes.Classes.DataStructures.Stack
{
    public class Stack<T> : IStack<T>
    {
        private Node<T> top;
        private int count;

        public int GetCount()
        {
            return count;
        }

        public bool IsEmpty()
        {
            return (count == 0) ? true : false;
        }

        public T Peek()
        {
            return top.GetData();
        }

        public T Pop()
        {
            T data = top.GetData();
            if (top.GetNextNode() != null)
            {
                top = (Node<T>)top.GetNextNode();
            } else
            {
                top = null;
            }
            count--;
            return data;
        }

        public void Push(T data)
        {
            Node<T> newTop = new Node<T>(data);
            if (top != null)
            {
                newTop.SetNextNode(top);
            }
            top = newTop;
            count++;
        }
    }
}
