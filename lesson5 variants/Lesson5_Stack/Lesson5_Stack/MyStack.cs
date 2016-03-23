using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_Stack
{
    public class MyStack
    {
        private int[] myStackArray;
        private int topPossition = 0;
        
        //Constructor
        public MyStack(int[] array)
        {
            myStackArray = array;
        }

        //Check if Stack is Full
        public bool IsFull()
        {
            if (topPossition == myStackArray.Length)
            {
                Console.WriteLine("The Element can't be added to Stack due to it's Full, please make pop or clear");
                return true;
            }   else { return false; }
        }

        //Check if Stack is Empty
        public bool IsEmpty()
        {
            if (topPossition == 0)
            {
                Console.WriteLine("The Stack is Empty, the Pop or Peek isn't avaliable, try to Push element before");
                return true;
            }   else { return false; }
        }

        // Push API
        public void Push(int element)
        {
            if (!IsFull())
            {
                myStackArray[topPossition] = element;
                Console.WriteLine("The new element {0} was sucessfully added to Stack", element);
                topPossition++;
            }
        }
        
        //Pop API
        public int Pop()
        {
            if (!IsEmpty())
            {
                int element = myStackArray[topPossition - 1];
                Console.WriteLine("The last element {0} was sucessfully removed from Stack", element);
                topPossition--;
                return element;
            } else { return -1; }
        }

        // Peek API
        public int Peek()
        {
            if (!IsEmpty())
            {
                int element = myStackArray[topPossition - 1];
                Console.WriteLine("The last element in Stack is {0}", element);
                return element;
            }   else {return -1;}
       }
    }

}
