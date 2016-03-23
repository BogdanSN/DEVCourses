using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Lesson5_Sorting
{
    class SwapMethod
    {

        private int tempSwap = 0;

        public void insertSwap(int[] insSwapArray, int i, int insSwapArLenght)
        {
            tempSwap = insSwapArray[i - 1];
            insSwapArray[i - 1] = insSwapArray[i];
            insSwapArray[i] = tempSwap;
        }

        public void bSwap(int[] bSwapArray, int i, int bSwapArLenght)
        {
            tempSwap = bSwapArray[i];
            bSwapArray[i] = bSwapArray[i + 1];
            bSwapArray[i + 1] = tempSwap;
        }

    }
}
