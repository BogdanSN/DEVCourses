using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lesson_14_Windows_Forms
{
    public class MyStackNet
    {
        Stack<long> stackNet = new Stack<long>();

        Random rand = new Random();

        public long Start()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            PushNet();
            PopNet();
            watch.Stop();

            return watch.ElapsedMilliseconds;

        }

        private void PushNet()
        { 
            for (int i=0;i<1000000; i++)
            {
                stackNet.Push(rand.Next(100));
            }
        }

        private void PopNet()
        {
            for (int i = 1000000;i == 0; i--)
            {
                stackNet.Pop();
            }
        }

    }

}
