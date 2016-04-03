using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public interface ILinked<T>
    {
        void InsertFirst(T data);                     // Add/Push new Node with Data to Linked List
        T Pop();                               // Remove last Node
        void Peek();                           // Show last added Node
        void Print();                          // Display whole Linked List
        Node<T> Retrieve(int possition);       // Retrieving element from specified possition
        
        //void Insert(int possition, T data);    // Insert new Node on specific possition with data
        //void Remove(int possition, T data);    // Remove Node on specific possition
        
        

    }
}
