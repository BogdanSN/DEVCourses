using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_homework
{
    public interface ISorter<T> : IPrintable where T : IComparable
    {
        void Sort();


    }
}
