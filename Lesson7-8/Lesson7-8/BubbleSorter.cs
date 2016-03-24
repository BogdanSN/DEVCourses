using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_8
{
    class BubbleSorter<T> : Sorter<T> where T : IComparable
    {
        public BubbleSorter(T[] array)
        {
            arrayToSort = array;
        }

        public override void Sort(int bubleArrayLenght)
        {
            bool isSwap = true;

            while (isSwap)
            {
                isSwap = false;

                for (int i = 0; i < bubleArrayLenght - 1; i++)
                {
                    if (arrayToSort[i].CompareTo(arrayToSort[i + 1])>0)
                    {
                        Swap(i, bubleArrayLenght);
                        isSwap = true;
                    }
                }

            }
        }

        public override void Swap(int i, int bSwapArLenght)
        {
            T tempSwap = arrayToSort[i];
            arrayToSort[i] = arrayToSort[i + 1];
            arrayToSort[i + 1] = tempSwap;
        }
    }
}
