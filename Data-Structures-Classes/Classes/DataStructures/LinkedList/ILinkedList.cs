namespace Data_Structures_Classes.Classes.DataStructures.LinkedList
{
    internal interface ILinkedList<T>
    {
        Node<T> GetHead();
        Node<T> GetTail();
        Node<T> Find(T data);

        void InsertAfter(Node<T> node, T newData);
        void InsertAfter(Node<T> node, Node<T> newNode);
        void InsertBeginning(T newData);
        void InsertBeginning(Node<T> newNode);
        
        void RemoveAfter(Node<T> node);
        void RemoveBeginning();

        void Print();
        void Clear();
    }
}