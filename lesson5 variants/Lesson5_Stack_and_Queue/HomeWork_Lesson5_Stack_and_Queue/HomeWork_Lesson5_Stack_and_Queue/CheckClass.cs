using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Lesson5_Stack_and_Queue
{
    public class CheckClass
    {
        public int topPossition = 0;
        
        public bool IsFull()
        {
            if (topPossition == 10)
            {
                Console.WriteLine("The Element can't be added to Stack due to it's Full, please make pop or clear");
                return true;
            }
            else { return false; } 
        }

        public bool IsEmpty()
        {
            if (topPossition == 0)
            {
                Console.WriteLine("The Stack is Empty, the Pop isn't avaliable, try to Push element before");
                return true;
            }
            else { return false; }
        }
        public int Size(int arrayLenght)
        {
            int sizeCount = arrayLenght - topPossition;
            Console.WriteLine("The Stack Size is {0}", sizeCount);
            return sizeCount;
        }
    }
}
