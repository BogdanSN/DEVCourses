using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_homework
{
    public abstract class Sorter<T> : ISorter<T> where T : IComparable
    {
        public void Sort() { }
        public void Print() { }
    }
}
