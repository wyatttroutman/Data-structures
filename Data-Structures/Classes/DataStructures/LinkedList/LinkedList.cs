using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Classes.DataStructures.LinkedList
{
    internal class LinkedList<T> : ILinkedList<T>, IEnumerable<T>
    {
        private Node<T> head;
        
        public LinkedList()
        {
            head = null;
        }

        public LinkedList(T headData)
        {
            head = new Node<T>(headData);
        }

        public Node<T> Find(T data)
        {
            Node<T> node = GetHead();
            while(node != null)
            {
                if (EqualityComparer<T>.Default.Equals(node.GetData(), data))
                    return node;

                node = node.NextNode;
            }
            return null;
        }

        public Node<T> GetHead()
        {
            return head;
        }

        public Node<T> GetTail()
        {
            Node<T> node = GetHead();
            while (node != null)
            {
                if (node.NextNode == null)
                    return node;

                node = node.NextNode;
            }
            return null;
        }

        public void InsertAfter(Node<T> node, T newData)
        {
            InsertAfter(node, new Node<T>(newData));
        }

        public void InsertAfter(Node<T> node, Node<T> newNode)
        {
            newNode.NextNode = node.NextNode;
            node.NextNode = newNode;
        }

        public void InsertBeginning(T newData)
        {
            InsertBeginning(new Node<T>(newData));
        }

        public void InsertBeginning(Node<T> newNode)
        {
            newNode.NextNode = GetHead();
            head = newNode;
        }


        public void RemoveAfter(Node<T> node)
        {
            node.NextNode = node.NextNode.NextNode;
        }

        public void RemoveBeginning()
        {
            head = head.NextNode;
        }

        public void Clear()
        {
            Node<T> node = GetHead();
            while (node != null)
            {
                head = node.NextNode;
                node = head;
            }
        }

        public void Print()
        {
            Node<T> node = GetHead();
            while (node != null)
            {
                node.Print();
                node = node.NextNode;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
