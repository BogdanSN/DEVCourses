using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lesson_14_Windows_Forms
{
    public class MyStackNet : StackSpecification
    {
        Stack<long> stackNet = new Stack<long>();

        Random rand = new Random();

        public long StartNet()
        {
            long temp = 0;
            return temp = Start();

        }

        public override void Push()
        { 
            for (int i=0;i<1000000; i++)
            {
                stackNet.Push(rand.Next(100));
            }
        }

        public override void Pop()
        {
            for (int i = 1000000;i == 0; i--)
            {
                stackNet.Pop();
            }
        }

    }

}
