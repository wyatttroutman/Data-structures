using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Classes.Classes.DataStructures.Stack
{
    interface IStack<T>
    {
        T Peek();
        T Pop();
        void Push(T data);
        bool IsEmpty();
    }
}
