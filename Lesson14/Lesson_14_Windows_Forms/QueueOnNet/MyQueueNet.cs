using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lesson_14_Windows_Forms
{
    public class MyQueueNet
    {
        private Queue<long> myQueueNet = new Queue<long>();

        Random rand = new Random();

        public long Start()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            EnqueueNet();
            DeqNet();
            watch.Stop();

            return watch.ElapsedMilliseconds;

        }

        private void EnqueueNet()
        {
            for (int i = 0; i < 1000000; i++)
            {
                myQueueNet.Enqueue(rand.Next(100));
            }
        }

        private void DeqNet()
        {
            for (int i = 1000000; i == 0; i--)
            {
                myQueueNet.Dequeue();
            }
        }

    }
}
