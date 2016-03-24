using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_8
{
    public class MyQueue<T> : Buffer<T>, IMyQueue<T>
    {

        private T[] mQA;          //internal array
        private int head = 0;       //possition which will be removed from Queue
        private int tail = 0;       //possition where new element will be added
        private int count = 0;      //quantity of free possitions in Queue



        //Constructor
        public MyQueue(T[] array)
        {
            mQA = array;
            count = mQA.Length;
        }

        //Check if Queue is Full
        public override bool IsFull()
        {
            if (count == 0)
            {
                Console.WriteLine("The Queue is Full");
                return true;
            }
            else { return false; }

        }

        //Check if Queue is Empty
        public override bool IsEmpty()
        {
            if ((head == tail) && (count == mQA.Length))
            {
                Console.WriteLine("The Queue is Empty");
                return true;
            }
            else
            {
                return false;
            }
        }

        // Enqueue API
        // Firstly need to check if tail+1 possition wouldn't be more than array lenght
        // If this check will be missed - the bufferOverflow occured once the tail will be tail+1
        // This check also helps to move tail to possition Array[0]
        // Once tail was correctly moved to next possition - the count should be decreased by 1
        public void Enqueue(T element)
        {
            if (!IsFull())
            {
                if ((tail + 1 > mQA.Length) && (head != 0))
                {
                    tail = 0;
                    mQA[tail] = element;
                    tail++;
                }
                else
                {
                    mQA[tail] = element;
                    tail++;

                }

                count--;

                Console.WriteLine("The {0} was added", element);
            }
        }

        //Deq API
        // Firstly we return element from Queue in possition Array[head]
        // Next step - need to check if head+1 not more that Array lenght to avoid BufferOverFlow
        // Next step - need to return tail in possition Array[0] in case the head isn't 0 
        // Last step - to calculate count, which is use in IsEmpty method
        public T Deq()
        {

            if (!IsEmpty())
            {
                T element = default (T);
                element = mQA[head];
                mQA[head] = default(T);
                if (head + 1 < mQA.Length)
                {
                    head++;
                }
                else { head = 0; }

                if ((tail == mQA.Length) && (head != 0))
                {
                    tail = head - 1;
                }

                if (count < mQA.Length + 1)
                {
                    count++;
                }
                else
                {
                    count = 0;
                }

                Console.WriteLine("The {0} was dequeued", element);

                return element;
            }
            else { return default (T); }
                        
        }
    }
}
