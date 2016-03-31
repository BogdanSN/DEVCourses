using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    public class DynamicStack <T>
    {
        protected T[] myStackArray;
        protected int topPossition = 0;

        // The Class Constructor which creates new T Array with Size 4
        public DynamicStack()
        {
            myStackArray = new T[4];
        }

        // The Class Property which allows to get possition in Array
        private int Capacity
        {
            get
            {
                return myStackArray.Length;
            }
        }
        
        
        //The method checks if Stack is Full
        public bool IsFull()
        {
            if (topPossition == Capacity)
            {
                return true;
            }
            return false;
        }

        //The method checks if Stack is Empty
        public bool IsEmpty()
        {
            if (topPossition == 0)
            {
                Console.WriteLine("The Array is empty");
                return true;
            }
            return false;
        }

        // The method allows to Push new element to Stack
        // In case the new element is going to go out the Stack 
        // The Resize method occur and increase Stack
        // The new element will be added in resized Stack
        public void Push(T element)
        {
            if (!IsFull())
            {
                myStackArray[topPossition] = element;
                Console.WriteLine("The new element {0} was sucessfully added to Stack", element);
                topPossition++;
            }
            else
            {
                Resize();
                myStackArray[topPossition] = element;
                topPossition++; 
            }
        }

        // The method allow to Remove last element from Stack
        // In the Stack is Empty - relevant message appears
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

        // The method Peek allows user to see last element in Stack
        public T Peek()
        {
            if (!IsEmpty())
            {
                Console.WriteLine("The last element in Stack is {0}", myStackArray[topPossition - 1]);
                return myStackArray[topPossition - 1];
            }
            else { return default (T); }
        }
        
        // The method perform Resize Stack function
        private void Resize()
        {
            T[] resizeArray = new T[Capacity * 2];

            for (int i = 0; i < myStackArray.Length; i++)
            {
                resizeArray[i] = myStackArray[i];

            }

            myStackArray = resizeArray;
        }
    }
}
