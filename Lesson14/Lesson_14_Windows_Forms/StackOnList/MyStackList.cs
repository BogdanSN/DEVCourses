using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lesson_14_Windows_Forms
{
    public class MyStackList
    {
        MyLinkedList<long> myLL = new MyLinkedList<long>();
        
        public long Start()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            PushList();
            PopList();
            watch.Stop();

            return watch.ElapsedMilliseconds;

        }

        private void PushList()
        {
            for (int i = 0; i < 1000000; i++)
            {
                myLL.InsertFirst();
            }
        }

        private void PopList()
        {
            for (int i = 1000000; i == 0; i--)
            {
                myLL.RemoveFirst();
            }
        }


    }
}
