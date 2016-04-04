using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
     public class MyLinkedList<T> : ILinked<T>
    {
        public Node<T> head = null;
                        
        // The method Allows user to insert a new Node to Begining of Linked List 
        public void InsertFirst(T data)
        {
            Node<T> insFirst = new Node<T>();
            insFirst.data = data;
            insFirst.next = head;
            head = insFirst;
        }

        // The method Allows user to insert a new Node to the End of Linked List 
        public void InsertLast(T data)
        {
            if (head == null)
            {
                head = new Node<T>();
                head.data = data;
                head.next = null;
            }
            else
            {
                Node<T> insLast = new Node<T>();
                insLast.data = data;

                Node<T> current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = insLast;
            }
        }
         
        // The method allows user to Remove last added Node from Linked List
        public void RemoveFirst()
        {
            head = head.next;
         }
        
         
         
        //---------------------------------------------------------------------------
        // Will be deployed later

        // The method allows user to insert Node in specific possition of Linked List
        public void InsertMiddle(int possition, T data)
        { }

        // The method allows user to Remove Last Node from Linked List
        public void RemoveLast()
        { }
    }
}
