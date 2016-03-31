using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    public interface IDynamicArray <T>
    {
        void Add(T value);
        void Insert(int possition, T value);
        T Get(int possition);
        void Remove(int possition);
    }
}
