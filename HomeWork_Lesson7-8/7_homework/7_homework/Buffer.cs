using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_homework
{
    public abstract class Buffer<T> : IBuffer<T> 
    {
        protected T[] myArray = null;
        public bool isEmpty()
        {
            throw new NotImplementedException();
        }

        public bool isFull()
        {
            throw new NotImplementedException();
        }

        public T Peek()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}
