using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lesson_14_Windows_Forms
{
    public class MyStackArray
    {
        private long[] stackArray = new long[10000000];

        Random rand = new Random();

        public long Start()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            PushArray();
            PopArray();
            watch.Stop();

            return watch.ElapsedMilliseconds;

        }

        private void PushArray()
        {
            for (int i = 0; i < stackArray.Length - 1; i++)
            {
                stackArray[i] = rand.Next(100);
            }
        }

        private void PopArray()
        {
            for (int i = stackArray.Length; i == 0; i--)
            {
                stackArray[i] = 0;
            }
        }
    }
}
