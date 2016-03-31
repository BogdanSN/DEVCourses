using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    public class DynamicArray<T>: IDynamicArray<T>
    {
        private T[] dArray;
        
        // The Class Constructor which creates new T Array with Size 4
        public DynamicArray()
        {
            dArray = new T[4];
        }
        
        // The Class Property which allows to get possition in Array
        public int Size
        {
            set;
            get;
        }
        
        // The Class Property which will use to for checking if Array is Full and Empty
        // Also this property will use for Resize method 
        public int Capacity
        {
            get
            {
                return dArray.Length;
            }
        }
        
        // The method checks if Array is Full
        // The Array is full if Size == Capasity
        private bool IsFull()
        {
            if (Size == Capacity)
            {
                return true;
            }
            return false;
        }
        
        // The menthod checks if Array is empty 
        // The Array is empty of Size == 0
        private bool IsEmpty()
        {
            if (Size == 0)
            {
                Console.WriteLine("The Array is empty");
                return true;
            }
            return false;
        }
        
        // The method Add adds to Array a new element
        // If the Array Size equal to Capasity the array going to be resize
        // and new element will be added to new Resized array
        public void Add(T value)
        {
            if (!IsFull())
            {
                dArray[Size] = value;
                Console.WriteLine("Index - {0}, Element - {1}", Size,value);
                Size++;
            }
            
            else
            {
                Resize();
                dArray[Size] = value;
                Size++;
            }


        }
        
        // The method provides Insertion mechanism with adding checking logic on Full Array
        // In case the Array is Full or inserted element will cause missing element
        // The Resize Array firstly occur and than Insertion value will be performed
        public void Insert(int index, T value)
        {
            if ((!IsFull()) && (index + 1 <= Capacity))
            {
                SimpleInsert(index, value);
            }
            else
            {
                Resize();
                SimpleInsert(index, value);
            }
        }

        // The method perform Insertion value into Array based on specified index
        private void SimpleInsert(int index, T value)
        {
            for (int i = dArray.Length - 1; i > index; i--)
            {
                dArray[i] = dArray[i - 1];
            }
            dArray[index] = value;
            Print();
            Size++;
        }

        // The method find element located under specific index mentioned 
        // by user in Array and return it.
        // Before returning the code check if Array isn't Empty and if no
        // decrease index by 1 for user friendly return
        public T Get(int index)
        {
            if (!IsEmpty())
            {
           
                Console.WriteLine("The  element - {0}", dArray[index]);
                return dArray[index];
            }
            else
            {
                return default(T);
            }
            
        }

        // The method allows to remove element form Array in specified possition
        public void Remove(int index)
        {
            if (!IsEmpty())
            {
                for (int i = index; i < dArray.Length-1; i++)
                {
                    if (((i + 1) != dArray.Length + 1))
                    {
                        dArray[i] = dArray[i + 1];
                    }
                }

                Size--;
            }
            Print();
        }

        // The method perform Resize Array function
        private void Resize()
        {
            T[] resizeArray = new T[Capacity * 2];

            for (int i = 0; i < dArray.Length; i++)
            {
                resizeArray[i] = dArray[i];

            }

            dArray = resizeArray;
        }

        //The method is use for show result
        public void Print()
        {
            for (int i = 0; i < dArray.Length; i++)
            {
                Console.WriteLine("Index - {0}, Element - {1}", i, dArray[i]);
            }
        }

    }
}
