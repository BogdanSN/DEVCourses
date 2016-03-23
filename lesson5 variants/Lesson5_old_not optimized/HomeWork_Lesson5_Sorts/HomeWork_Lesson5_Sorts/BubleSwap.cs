using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Lesson5_Sorts
{
    class BubleSwap
    {
        private int tempSwap = 0;

        public void bSwap(int[] bSwapArray, int i, int bSwapArLenght)
        {
            tempSwap = bSwapArray[i];
            bSwapArray[i] = bSwapArray[i + 1];
            bSwapArray[i + 1] = tempSwap;
        }
    }
}
