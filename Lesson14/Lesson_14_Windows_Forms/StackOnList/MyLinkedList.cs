using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14_Windows_Forms
{
    public class MyLinkedList<T>
    {
        Random rand = new Random();
        private Node<T> head = null;
        private int size = 0;
                
        public int Count
        {
            get
            {
                return size;
            }
        }


        // The method Allows user to insert a new Node to Begining of Linked List 
        public void InsertFirst()
        {
            Node<T> insFirst = new Node<T>();
                insFirst.data = rand.Next(100);
                insFirst.next = head;
                head = insFirst;
                size++;
        }

        public void RemoveFirst()
        {
                long temp = head.data;
                head = head.next;
                size--;
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
        
    }
}
