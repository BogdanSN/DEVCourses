using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_lesson6
{
    class Buffer
    {
        public virtual bool IsFull()
        {
            return false;
        }

        public virtual bool IsEmpty()
        {
            return false;
        }

        public virtual void Push(int pushValue){}

        public virtual int Pop()
        {
            return -1;
        }

        public virtual int Peek()
        {
            return -1;
        }

        public virtual void Enqueue(int enqueueValue) { }

        public virtual int Deq()
        {
            return -1;
        }    
    }
}
