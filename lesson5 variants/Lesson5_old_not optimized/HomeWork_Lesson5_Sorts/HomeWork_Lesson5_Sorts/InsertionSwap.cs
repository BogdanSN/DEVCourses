using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Lesson5_Sorts
{
    class InsertionSwap
    {
        private int tempSwap = 0;

        public void insertSwap(int[] insSwapArray, int i, int insSwapArLenght)
        {
            tempSwap = insSwapArray[i-1];
            insSwapArray[i-1] = insSwapArray[i];
            insSwapArray[i] = tempSwap;
        }

    }
}
