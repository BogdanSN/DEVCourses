using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Lesson5_Correct
{
    class BubleSorter
    {
        private int tempSwap = 0;

        int[] arrayToSort;
     
        public BubleSorter(int[] array)
        {
            arrayToSort = array;
        }

        public void Swap(int i, int bSwapArLenght)
        {
            tempSwap = arrayToSort[i];
            arrayToSort[i] = arrayToSort[i + 1];
            arrayToSort[i + 1] = tempSwap;
        }

        public void Sort(int bubleArrayLenght)
        {
            bool isSwap = true;
            
            while (isSwap)
            {
                isSwap = false;

                for (int i = 0; i < bubleArrayLenght - 1; i++)
                {
                    if (arrayToSort[i] > arrayToSort[i + 1])
                    {
                        Swap(i, bubleArrayLenght);
                        isSwap = true;
                    }
                }

            }
        }

        public void Print(int PrintArLenght)
        {
            for (int i = 0; i < PrintArLenght; i++)
            {
                Console.Write(" " + arrayToSort[i]);
            }

        }

    }
}
