using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    public class DynamicQueue<T>
    {
        private T[] mQA;            //internal array
        private int head = 0;       //possition which will be removed from Queue
        private int tail = 0;       //possition where new element will be added
        private int count = 0;      //quantity of free possitions in Queue



        //Constructor
        public DynamicQueue()
        {
            mQA = new T[4];
            count = mQA.Length;
        }

        public int Size
        {
            set
            {
                if (Size >= 1000)
                {
                    Console.WriteLine("The Queue is Full");
                    count = 0;
                }
                head = value;
            }
            get
            {
                return head;
            }
        }
        
        private int Capacity
        {
            get
            {
                return mQA.Length;
            }
        }

        //Check if Queue is Full
        public bool IsFull()
        {
            if (count == 0)
            {
                Resize();
                count = Capacity / 2; 

                //Console.WriteLine("The Queue is Full");
                return false;
            }
            else { return false; }

        }

        //Check if Queue is Empty
        public bool IsEmpty()
        {
            if ((Size == tail) && (count == Capacity))
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
                if ((tail + 1 > Capacity) && (Size != 0))
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
                element = mQA[Size];
                mQA[Size] = default(T);
                if (Size + 1 < Capacity)
                {
                    Size = Size+1;
                }
                else { Size = 0; }

                if ((tail == Capacity) && (Size != 0))
                {
                    tail = Size - 1;
                }

                if (count < Capacity + 1)
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
        // The method perform Resize Array function
        private void Resize()
        {
            T[] resizeArray = new T[Capacity * 2];

            for (int i = 0; i < mQA.Length; i++)
            {
                resizeArray[i] = mQA[i];

            }

            mQA = resizeArray;
        }
        //The method is use for show result
        public void Print()
        {
            for (int i = 0; i < mQA.Length; i++)
            {
                Console.WriteLine("Index - {0}, Element - {1}", i, mQA[i]);
            }
        }
    }
}
