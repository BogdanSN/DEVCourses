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

        
        // The method Allows user to create a new Node with dates and Link to Next Node. 
        // After creating a new Node - the Data and Next will contain Null till they will be fill
        public void Push(T data)
        {
            Node<T> newAdd = new Node<T>();
            newAdd.data = data;
            newAdd.next = head;
            head = newAdd;
            size++;
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
