using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_homework
{
    public abstract class MyQueue<T> : Buffer<T>, IMyQueue<T>
    {
        public T Dequeue()
        {
            throw new NotImplementedException();
        }

        public T Enqueue(T value)
        {
            throw new NotImplementedException();
        }
    }
}
