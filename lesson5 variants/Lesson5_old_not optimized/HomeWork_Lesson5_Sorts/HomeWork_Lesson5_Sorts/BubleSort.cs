using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Lesson5_Sorts
{
    class BubleSort
    {
        public void BubleSortFunc(int[] bubleSortArray, int bubleArrayLenght)
        {
            bool isSwap = true;
            BubleSwap bubSwap = new BubleSwap();

            while (isSwap)
            {
                isSwap = false;

                for (int i = 0; i < bubleArrayLenght - 1; i++)
                {
                    if (bubleSortArray[i] > bubleSortArray[i + 1])
                    {
                        bubSwap.bSwap(bubleSortArray, i, bubleArrayLenght);
                        isSwap = true;
                    }
                }

            }
        }
    }
}
