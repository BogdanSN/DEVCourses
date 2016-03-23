using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Lesson5_Sorts
{
    class InsertionSort
    {
        public void InsertionSortFunc(int[] insSortArray, int insArrayLenght)
        {
            bool isSwap = true;
            InsertionSwap insSwap = new InsertionSwap();
            
            while (isSwap)
            {
                isSwap = false;

                for (int i = 0; i < insArrayLenght; i++)
                {
                    if ((i > 0) && (insSortArray[i - 1] > insSortArray[i]))
                    {
                        insSwap.insertSwap(insSortArray, i, insArrayLenght);
                        isSwap = true;
                    }
                }

            }
        }

    }
}
