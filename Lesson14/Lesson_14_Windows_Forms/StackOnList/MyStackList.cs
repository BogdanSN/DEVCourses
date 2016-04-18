using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lesson_14_Windows_Forms
{
    public class MyStackList : StackSpecification
    {
        MyLinkedList<long> myLL = new MyLinkedList<long>();
        
        public long StartList()
        {
            long temp = 0;
            return temp = Start();

        }

        public override void Push()
        {
            for (int i = 0; i < 1000000; i++)
            {
                myLL.InsertFirst();
            }
        }

        public override void Pop()
        {
            for (int i = 1000000; i == 0; i--)
            {
                myLL.RemoveFirst();
            }
        }


    }
}
