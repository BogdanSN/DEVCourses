using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Lesson5_Stack_and_Queue
{
    public class CommandClass
    {
        CheckClass tpPos = new CheckClass();
        
        public void PuchToStack(int element, int arrayLenght)
        {
            if (!tpPos.IsFull())
            {
                Console.WriteLine("The new element {0} was added to Stack", element);
            }
            tpPos.topPossition++;
            
        }
        public void PopFromStack(int arrayLenght) 
        {

            tpPos.topPossition--;
            if (!tpPos.IsEmpty(arrayLenght))
            {
            
               // Console.WriteLine("The last element {0} was removed from Stack", element);
            }
            
        
        }
        public void PeekFromStack(int element, int arrayLenght)
        {

        }
        public void ClearStack(int arrayLenght)
        {
            for (int i = 0; i < arrayLenght; i++)
            { 
              
            }
        }
        private int StArray(int arrayLenght)
        {
            
            for (int i = 0; i < arrayLenght; i++)
            {
                stackArray[i] = PuchToStack;
            }
        }

       
    }
}
