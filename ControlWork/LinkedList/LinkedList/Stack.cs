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

        public void PushToStart(T data)
        {
           mll.InsertFirst(data);
        }

        public void PushToLast(T data)
        {
            mll.InsertLast(data);
        }

        public void PeekLast()
        {
            mll.Peek();
        }

        public T PopLast()
        {
            return mll.Pop();
        }

        public void ShowStack()
        {
            mll.Print();
        }

       

    }
}
