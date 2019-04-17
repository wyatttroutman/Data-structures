using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Classes.Classes.DataStructures.Stack
{
    interface INode<T>
    {
        INode<T> GetNextNode();
        void SetNextNode(INode<T> node);

        T GetData();
        void SetData(T data);
    }
}
