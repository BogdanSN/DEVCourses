using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lesson_14_Windows_Forms
{
    public class MyQueueNet : QueueSpecification
    {
        private Queue<long> myQueueNet = new Queue<long>();

        Random rand = new Random();

        public long StartQueueNet()
        {
            return Start();
        }

        public override void QEnqueue()
        {
            for (int i = 0; i < 1000000; i++)
            {
                myQueueNet.Enqueue(rand.Next(100));
            }
        }

        public override void QDequeue()
        {
            for (int i = 1000000; i == 0; i--)
            {
                myQueueNet.Dequeue();
            }
        }

    }
}
