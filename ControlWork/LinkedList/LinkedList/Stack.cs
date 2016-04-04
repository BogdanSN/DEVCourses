using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Stack<T> 
    {
        MyLinkedList<T> mll = new MyLinkedList<T>();
               
        private int size = 0;

        // The class property Count allows to find out quantity of elements in Stack
        private int Count
        {
            get
            {
                return size;
            }
        }
        
        // The method allows to add new element to Stack
        public void Push(T data)
        { 
                mll.InsertFirst(data);
                size++;
        }

        
        // The method allows user to Pop element from Stack
        public T Pop()
        {
            Node<T> popNode = new Node<T>();
            if (!IsEmpty())
            {

                popNode = mll.head;
                mll.head = popNode.next;

                Console.WriteLine("The Element - {0} - was removed", popNode.data);
                size--;

            }
            return popNode.data;
        }

        // The method allows user to see last added element in Stack
        public void Peek()
        {
            if (!IsEmpty())
            {
                Node<T> peek = mll.head;
                Console.WriteLine("Last Element is  - {0}", peek.data);
            }
        }

        // The method will be use for displaing all elements in Stack
        public void Print()
        {
            Node<T> current = mll.head;

            if (!IsEmpty())
            {
                for (int i = 0; i < Count && current != null; i++)
                {
                    Console.WriteLine("{0}) Element is - {1}", i, current.data);
                    current = current.next;
                }
            }

        }
        
        // The method allows to check if Stack is Empty
        public bool IsEmpty()
        {
            if (mll.head == null)
            {
                Console.WriteLine("The Linked List is Empty");
                return true;
            }
            return false;
        }

    }
}
