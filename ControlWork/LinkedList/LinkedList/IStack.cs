using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public interface IStack<T>
    {
        void Push(T data);                     // Add new element to Stack
        T Pop();                               // Remove last element from Stack
        void Peek();                           // Show last added Node
        void Print();                          // Display whole Linked List
        bool IsEmpty();                        // Check if Stack is Empty
     }
}
