using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_8
{
    public abstract class Buffer<T> : IBuffer<T>
    {
        protected T[] bufferArray;
        protected int topPossition = 0;
               
        public virtual bool IsFull()
        {
            return false;
        }

        public virtual bool IsEmpty()
        {
            return false;
        }
        
        public void Print()
        {
            Console.WriteLine("");
            for (int i = 0; i < bufferArray.Length; i++)
            {
                Console.Write("Sorted Array:\n {0} ", bufferArray[i]);
            }
        }

        public virtual T Peek() 
        {
            if (!IsEmpty())
            {
                Console.WriteLine("The last element in Stack is {0}", bufferArray[topPossition - 1]);
                return bufferArray[topPossition - 1];
            }
            else 
            { 
                return default(T); 
            }
        }

    }
}
