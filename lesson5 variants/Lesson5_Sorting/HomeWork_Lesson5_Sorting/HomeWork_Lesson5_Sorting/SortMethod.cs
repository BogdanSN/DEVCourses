using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Lesson5_Sorting
{
    class SortMethod
    {
        SwapMethod swapMeth = new SwapMethod();
        
        public void InsertionSortFunc(int[] insSortArray, int insArrayLenght)
        {
            bool isSwap = true;
        
            while (isSwap)
            {
                isSwap = false;

                for (int i = 0; i < insArrayLenght; i++)
                {
                    if ((i > 0) && (insSortArray[i - 1] > insSortArray[i]))
                    {
                        swapMeth.insertSwap(insSortArray, i, insArrayLenght);
                        isSwap = true;
                    }
                }

            }
        }

        public void BubleSortFunc(int[] bubleSortArray, int bubleArrayLenght)
        {
            bool isSwap = true;
            
            while (isSwap)
            {
                isSwap = false;

                for (int i = 0; i < bubleArrayLenght - 1; i++)
                {
                    if (bubleSortArray[i] > bubleSortArray[i + 1])
                    {
                        swapMeth.bSwap(bubleSortArray, i, bubleArrayLenght);
                        isSwap = true;
                    }
                }

            }
        }
    }
}
