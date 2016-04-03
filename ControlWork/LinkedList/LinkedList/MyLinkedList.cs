using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
     public class MyLinkedList<T> : ILinked<T>
    {
        private int size = 0;
        private Node<T> head = null;

        
        // The class property Count allows to find out the quantity of Added Nodes to Linked List
        private int Count
        {
            get
            {
                return size;
            }
        }

        // The method allows to check Linked List if it's Empty or not
        private bool IsEmpty()
        {
            if (head == null)
            {
                Console.WriteLine("The Linked List is Empty");
                return true;
            }
            return false;
        }



        // The method will be use for displaing all Datas from all Nodes
        public void Print()
        {
            Node<T> current = head;

            if (!IsEmpty())
            {
                for (int i = 0; i  < Count && current != null; i++)
                {
                    Console.WriteLine("{0}) Element is - {1}", i, current.data);
                    current = current.next;
                }
            }
          
        }

        
        // The method Allows user to insert a new Node to Begining of Linked List 
        public void InsertFirst(T data)
        {
            Node<T> addBegin = new Node<T>();
            addBegin.data = data;
            addBegin.next = head;
            head = addBegin;
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
                Node<T> addLast = new Node<T>();
                addLast.data = data;

                Node<T> current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = addLast;
                size++;
            }
        }


        
        // The method allows user to see last added element in the Linked List
        public void Peek()
        {
            if (!IsEmpty())
            {
                Node<T> peek = head;
                Console.WriteLine("Last Element is  - {0}", peek.data);
            }
        }
       

        // The method allows user to Pop last added element from Linked List
        public T Pop()
        {
            Node<T> popNode = new Node<T>();
            if (!IsEmpty())
            {
                
                popNode = head;
                head = popNode.next;

                Console.WriteLine("The Element - {0} - was removed", popNode.data);
                size--;
                
            }
            return popNode.data;
        }

        // The method allows to check if Node with specified by user possition is exist in Linked List
        private bool IsPossition(int possition)
        {
            if (possition < Count)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Entered possition isn't valid");
                return false;
            }
        }

        // The method allows user to check review Element by specific possition in Linked List
        public Node<T> Retrieve(int possition)
        {
            Node<T> retNode = head;
            if (IsPossition(possition))
            {
                for (int i = 0; i < possition && retNode != null; i++)
                {
                    retNode = retNode.next;
                }
                Console.WriteLine("The Element is - {0}", retNode.data);
            }
            return retNode;
        }


        // The method allows user to Remove element from Linked List by specific possition
        //public void Remove(int possition)
        //{
        //    Node remNode = Retrieve(possition);
            
        //    this.Retrieve(possition - 1).Next = this.Retrieve(possition + 1);
        //    size--;
            
        //    Console.WriteLine("The Element - {0} - was removed", remNode.data);
        //}
    }
}
