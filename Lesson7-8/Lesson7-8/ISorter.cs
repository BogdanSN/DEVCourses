using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_8
{
    public interface ISorter<T> : IPrintable where T : IComparable
    {
        void Sort( int value);
    }
}
