using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lesson_14_Windows_Forms
{
    public class QueueSpecification : IQueueSpecification
    {
        private long[] queueArray = new long[1000000];
        private long head = 0;
        private long tail = 0;
        private long count = 0;
        Random rand = new Random();

        public long Start()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            QEnqueue();
            QDequeue();
            watch.Stop();

            return watch.ElapsedMilliseconds;

        }


        public virtual bool IsFull()
        {
            if (count == 0) { return true; }
            else { return false; }

        }


        public virtual bool IsEmpty()
        {
            count = queueArray.Length;

            if ((head == tail) && (count == queueArray.Length))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual void QEnqueue()
        {
            for (int i = 0; i < queueArray.Length; i++)
            {
                if (!IsFull())
                {
                    if ((tail + 1 > queueArray.Length) && (head != 0))
                    {
                        tail = 0;
                        queueArray[tail] = rand.Next(100);
                        tail++;
                    }
                    else
                    {
                        queueArray[tail] = rand.Next(100);
                        tail++;
                    }
                    count--;
                }
            }
        }

        public virtual void QDequeue()
        {

            for (int i = queueArray.Length; i == 0; i--)
            {
                if (!IsEmpty())
                {
                    long element = 0;
                    element = queueArray[head];
                    queueArray[head] = 0;

                    if (head + 1 < queueArray.Length)
                    {
                        head++;
                    }
                    else { head = 0; }

                    if ((tail == queueArray.Length) && (head != 0))
                    {
                        tail = head - 1;
                    }

                    if (count < queueArray.Length + 1)
                    {
                        count++;
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }
        }
    }
}
