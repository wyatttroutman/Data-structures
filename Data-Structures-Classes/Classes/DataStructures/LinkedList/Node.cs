using System;

namespace Data_Structures_Classes.Classes.DataStructures.LinkedList
{
    public class Node<T>: INode<T>
    {
        public Node<T> NextNode { get; set; }

        private T data;

        public Node(T data)
        {
            this.data = data;
        }

        public T GetData()
        {
            return this.data;
        }

        public override string ToString()
        {
            return data.ToString();
        }
    }
}