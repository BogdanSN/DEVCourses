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
              
        public virtual bool isEmpty()
        {
            return false;
        }

        public virtual bool isFull()
        {
            return false;
        }

        //public virtual T Peek()
        //{
            
        //}

        public void Print()
        {
            Console.WriteLine("");
            for (int i = 0; i < bufferArray.Length; i++)
            {
                Console.Write("Sorted Array:\n {0} ", bufferArray[i]);
            }
        }
       
    }
}
