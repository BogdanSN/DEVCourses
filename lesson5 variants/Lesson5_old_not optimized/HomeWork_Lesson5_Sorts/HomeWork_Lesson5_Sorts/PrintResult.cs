using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Lesson5_Sorts
{
    class PrintResult
    {
        public void PrintResultFunc(int[] PrintArray, int PrintArLenght)
        {
            for (int i = 0; i < PrintArLenght; i++)
            { 
            Console.Write(" "+PrintArray[i]);
            }

        }

    }
}
