using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Classes.Classes.DataStructures.Stack
{
    class Node<T> : INode<T>
    {
        private T data;
        private Node<T> nextNode;

        public Node(T data)
        {
            this.data = data;
        }

        public T GetData()
        {
            return data;
        }

        public INode<T> GetNextNode()
        {
            return nextNode;
        }

        public void SetData(T data)
        {
            this.data = data;
        }

        public void SetNextNode(INode<T> node)
        {
            this.nextNode = (Node<T>)node;
        }
    }
}
