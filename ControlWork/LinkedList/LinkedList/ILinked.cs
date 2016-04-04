using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public interface ILinked<T>
    {
        void InsertFirst(T data);                       // Insert new Node to the Start of Linked List
        void InsertMiddle(int possition, T data);       // Insert new Node on specific possition with data
        void InsertLast(T data);                        // Insert new Node to the End to Linked List
        T RemoveFirst();                                // Remove First Node from Linked List
        T RemoveLast();                                 // Remove Node on specific possition 
        bool IsListEmpty();                             // Check if List is Empty
    }
}
