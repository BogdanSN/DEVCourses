using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_lesson6
{
    class InsertionSorter : Sorter
    {
        private int tempSwap = 0;

        int[] arrayToSort;

        public InsertionSorter(int[] array)
        {
            arrayToSort = array;
        }

        public override void Swap(int i, int insSwapArLenght)
        {
            tempSwap = arrayToSort[i - 1];
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
                    if ((i > 0) && (arrayToSort[i - 1] > arrayToSort[i]))
                    {
                        Swap(i, insArrayLenght);
                        isSwap = true;
                    }
                }

            }
        }

        public override void Print(int PrintArLenght)
        {
            for (int i = 0; i < PrintArLenght; i++)
            {
                Console.Write(" " + arrayToSort[i]);
            }

        }
    }
}
