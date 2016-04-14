﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lesson_14_Windows_Forms
{
    public class MyQueueDynamicArray
    {
        private long[] queueDynamicArray = new long[4];
        private long head = 0;
        private long tail = 0;
        Random rand = new Random();
        
        public long Start()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            EnqueueDynamicArray();
            DeqDynamicArray();
            watch.Stop();

            return watch.ElapsedMilliseconds;

        }



        public int Size
        {
            set;
            get;
        }

        public int Capacity
        {
            get
            {
                return queueDynamicArray.Length;
            }
        }

        private bool IsFull()
        {
            if (Size == 0) 
            {
                Resize();
                return false; 
            }
            else { return false; }

        }


        private bool IsEmpty()
        {
            Size = queueDynamicArray.Length;

            if ((head == tail) && (Size == Capacity))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void EnqueueDynamicArray()
        {
            //Size = queueDynamicArray.Length;
            for (int i = 0; i < 1000000; i++)
            {
                if (!IsFull())
                {
                    if ((tail + 1 > Capacity) && (head != 0))
                    {
                        tail = 0;
                        queueDynamicArray[tail] = rand.Next(100);
                        tail++;
                    }
                    else
                    {
                        queueDynamicArray[tail] = rand.Next(100);
                        tail++;
                    }
                    Size--;
                }
            }
        }

        private void DeqDynamicArray()
        {

            for (int i = 1000000; i == 0; i--)
            {
                if (!IsEmpty())
                {
                    long element = 0;
                    element = queueDynamicArray[head];
                    queueDynamicArray[head] = 0;

                    if (head + 1 < Capacity)
                    {
                        head++;
                    }
                    else { head = 0; }

                    if ((tail == Capacity) && (head != 0))
                    {
                        tail = head - 1;
                    }

                    if (Size < Capacity + 1)
                    {
                        Size++;
                    }
                    else
                    {
                        Size = 0;
                    }
                }
            }
        }
        
        private void Resize()
        {
            long[] resizeArray = new long[Capacity * 2];
            Size = Capacity/2;
            for (int i = 0; i < queueDynamicArray.Length; i++)
            {
                resizeArray[i] = queueDynamicArray[i];
            }
            queueDynamicArray = resizeArray;
        }
    }
}


