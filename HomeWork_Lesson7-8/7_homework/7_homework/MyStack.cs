using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_homework
{
    public abstract class MyStack<T> : Buffer<T>, IMyStack<T>
    {
        public T Pop()
        {
            throw new NotImplementedException();
        }

        public T Push(T value)
        {
            throw new NotImplementedException();
        }
    }
}
