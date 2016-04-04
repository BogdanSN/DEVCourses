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
               
        
        
        // The method allows to add new element to Stack
        public void Push(T data)
        { 
                mll.InsertFirst(data);
        }

        
        // The method allows user to Pop element from Stack
        public T Pop()
        {
            T tempPop;
            if (!IsEmpty())
            {
                tempPop = mll.RemoveFirst();
                Console.WriteLine("The Element - {0} - was removed", tempPop);
                return tempPop;
            }
            
                return default(T);
        }

        // The method allows user to see last added element in Stack
        public T Peek()
        {
            T tempPeak;
            if (!IsEmpty())
            {
                tempPeak = mll.GetFirstNode();
                Console.WriteLine("Last Element is  - {0}", tempPeak);
                return tempPeak;
            }
            return default(T);
        }

        // The method will be use for displaing all elements in Stack
        public void Print()
        {
            if (!IsEmpty())
            {
                mll.ReviewList();
            }
        }
        
        // The method allows to check if Stack is Empty
        public bool IsEmpty()
        {
            if (mll.IsListEmpty())
            {
                Console.WriteLine("The Stack is Empty");
                return true;
            }
            return false;
        }

    }
}
