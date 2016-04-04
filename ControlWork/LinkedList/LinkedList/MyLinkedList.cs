using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
     public class MyLinkedList<T> : ILinked<T>
    {
        private Node<T> head = null;
        private int size = 0;

        // The class property Count allows to find out quantity of elements in Linked List
        public int Count
        {
            get
            {
                return size;
            }
        }
         
       
        // The method Allows user to insert a new Node to Begining of Linked List 
        public void InsertFirst(T data)
        {
            Node<T> insFirst = new Node<T>();
            insFirst.data = data;
            insFirst.next = head;
            head = insFirst;
            size++;
        }

        // The method Allows user to insert a new Node to the End of Linked List 
        public void InsertLast(T data)
        {
            if (head == null)
            {
                head = new Node<T>();
                head.data = data;
                head.next = null;
                size++;
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
                size++;
            }
        }
         
        // The method allows user to Remove last added Node from Linked List
        public T RemoveFirst()
        {
            T temp = head.data;
            head = head.next;
            size--;
            return temp;
        }


        // The method allows to check if Stack is Empty
        public bool IsListEmpty()
        {
            if (head == null)
            {
                return true;
            }
            return false;
        }

        // The method allows to get First Node from Linked List
        public T GetFirstNode()
        {
            return head.data;
        }



        // The method allows to review all Nodes in Linked List
        public void ReviewList()
        {
            Node<T> current = head;
            
                while (current != null)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
                                                
            
        }

        //---------------------------------------------------------------------------
        // Will be designed later

        // The method allows user to insert Node in specific possition of Linked List
        public void InsertMiddle(int possition, T data)
        { }

        // The method allows user to Remove Last Node from Linked List
        public T RemoveLast()
        {
            return default(T);
        }
    }
}
