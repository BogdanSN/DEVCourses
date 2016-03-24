using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_8
{
    class InsertionSorter<T> : Sorter<T> where T : IComparable
    {
        private int tempSwap = 0;

        public InsertionSorter(T[] array)
        {
            arrayToSort = array;
        }

        public override void Swap(int i, int insSwapArLenght)
        {
            T tempSwap = arrayToSort[i - 1];
            arrayToSort[i - 1] = arrayToSort[i];
            arrayToSort[i] = tempSwap;
        }

        public override void Sort(int insArrayLenght)
        {
            bool isSwap = true;

            while (isSwap)
            {
                isSwap = false;

                for (int i = 0; i < insArrayLenght; i++)
                {
                    if ((i > 0) && (arrayToSort[i - 1].CompareTo(arrayToSort[i]))>0)
                    {
                        Swap(i, insArrayLenght);
                        isSwap = true;
                    }
                }

            }
        }
    }
}
