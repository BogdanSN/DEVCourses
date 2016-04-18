using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lesson_14_Windows_Forms
{
    public abstract class StackSpecification : IStackSpecification
    {
        private long[] stackArray = new long[10000000];

        Random rand = new Random();

        public long Start()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Push();
            Pop();
            watch.Stop();

            return watch.ElapsedMilliseconds;
        }

        
        public virtual bool IsFull()
        {
            int temp = 0;
            if (temp == 1000000)
            {
                return true;
            }
            else
            {
                return false;
            }
            
            
        }

        public virtual bool IsEmpty()
        {
            int temp = 0;
            if (temp != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public virtual void Push()
        {
            for (int i = 0; i < stackArray.Length - 1; i++)
            {
                if (!IsFull())
                {
                    stackArray[i] = rand.Next(100);
                }
            }
        }

        public virtual void Pop()
        {
            for (int i = stackArray.Length; i == 0; i--)
            {
                if (!IsEmpty())
                {
                    stackArray[i] = 0;
                }
            }
        }

    }
}
