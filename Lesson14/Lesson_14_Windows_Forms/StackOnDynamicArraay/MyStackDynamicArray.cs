using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lesson_14_Windows_Forms
{
    public class MyStackDynamicArray : StackSpecification
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



        public long StartDynamicArray()
        {
            long temp = 0;
            return temp = Start();

        }

        public override void Push()
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

        public override void Pop()
        {
            for (int i = stackDynamicArray.Length; i == 0; i--)
            {
                if (!IsEmpty())
                {
                    stackDynamicArray[i] = 0;
                    Size--;
                }
            }
            
        }

        public override bool IsFull()
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
