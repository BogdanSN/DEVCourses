using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_8
{
    public abstract class MyStack<T> : Buffer<T>, IMyStack<T>
    {
        protected T[] bufferArray;

        public T Pop()
        {
            throw new NotImplementedException();
        }

        public T Push(T value)
        {
            throw new NotImplementedException();
        }

        public T Peek(T value)
        {
            throw new NotImplementedException();
        }
    }
}
