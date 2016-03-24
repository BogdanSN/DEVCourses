using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_8
{
    public class MyStack<T> : Buffer<T>, IMyStack<T> 
    {
        protected T[] myStackArray;
        protected int topPossition = 0;
                
        public MyStack(T[] array)
        {
            myStackArray = array;
        }

        //Check if Stack is Full
        public override bool IsFull()
        {
            if (topPossition == myStackArray.Length)
            {
                Console.WriteLine("The Element can't be added to Stack due to it's Full, please make pop or clear");
                return true;
            }
            else { return false; }
        }

        //Check if Stack is Empty
        public override bool IsEmpty()
        {
            if (topPossition == 0)
            {
                Console.WriteLine("The Stack is Empty, the Pop or Peek isn't avaliable, try to Push element before");
                return true;
            }
            else { return false; }
        }

        // Push API
        public void Push(T element)
        {
            if (!IsFull())
            {
                myStackArray[topPossition] = element;
                Console.WriteLine("The new element {0} was sucessfully added to Stack", element);
                topPossition++;
            }
        }

        //Pop API
        public T Pop()
        {
            if (!IsEmpty())
            {
                 Console.WriteLine("The last element {0} was sucessfully removed from Stack", myStackArray[topPossition - 1]);
                topPossition--;
                return myStackArray[topPossition];
            }
            else { return default (T); }
        }

        // Peek API
        public override T Peek()
        {
            if (!IsEmpty())
            {
                Console.WriteLine("The last element in Stack is {0}", myStackArray[topPossition - 1]);
                return myStackArray[topPossition - 1];
            }
            else { return default (T); }
        }
    }
}
