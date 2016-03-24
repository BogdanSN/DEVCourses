using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_8
{
    public abstract class Sorter<T> : ISorter<T> where T : IComparable
    {
        protected T[] arrayToSort;

        public virtual void Sort(int SortArrayLenght) { }

        public virtual  void Swap(int i, int bSwapArLenght) {}

        public void Print() 
        {
            Console.WriteLine("\nSorted Array:");
            for (int i = 0; i < arrayToSort.Length; i++)
            {
                Console.Write(" "+arrayToSort[i]);
            }
        }

    }
}
