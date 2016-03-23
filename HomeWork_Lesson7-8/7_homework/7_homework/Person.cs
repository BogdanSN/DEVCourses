using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_homework
{
    public class Person  : IComparable
    {
        public int Age { set; get; }
        public string Name { set; get; }



        public int CompareTo(object obj)
        {
            Person that;
            that = (Person)obj;

            if (this.Age > that.Age)
            {
                return 1;
            }
            if (this.Age < that.Age)
            {
                return -1;
            }
            return 0;



        }
    }
}
