using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lesson_14_Windows_Forms
{
    public class MyStackDynamicArray
    {
        private long[] stackDynamicArray = new long[4];

        Random rand = new Random();


        public int Size
        {
            set;
            get;
        }

        public int Capacity
        {
            get
            {
                return stackDynamicArray.Length;
            }
        }



        public long Start()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            PushDynamicArray();
            PopDynamicArray();
            watch.Stop();

            return watch.ElapsedMilliseconds;

        }

        private void PushDynamicArray()
        {
            for (int i = 0; i < 1000000; i++)
            {
                if (!IsFull())
                {
                    stackDynamicArray[i] = rand.Next(100);
                    Size++;
                }
                else
                {
                    Resize();
                    stackDynamicArray[i] = rand.Next(100);
                    Size++;
                }
            }
        }

        private void PopDynamicArray()
        {
            for (int i = 1000000; i == 0; i--)
            {
                stackDynamicArray[i] = 0;
                Size--;
            }
        }

        private bool IsFull()
        {
            if (Size == Capacity)
            {
                return true;
            }
            return false;
        }

        private void Resize()
        {
            long[] resizeArray = new long[Capacity * 2];

            for (int i = 0; i < stackDynamicArray.Length; i++)
            {
                resizeArray[i] = stackDynamicArray[i];

            }

            stackDynamicArray = resizeArray;
        }
    }
}
