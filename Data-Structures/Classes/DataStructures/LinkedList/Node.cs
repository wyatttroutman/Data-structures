using System;

namespace Data_Structures.Classes.DataStructures.LinkedList
{
    internal class Node<T>: INode<T>
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

        public void Print()
        {
            Console.WriteLine(data.ToString());
        }
    }
}