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
     
        public DynamicArray()
        {
            dArray = new T[4];
        }
        
        public int Size
        {
            set;
            get;
        }
        
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
                Console.WriteLine("The new element {0} was sucessfully added to Array", value);
                Size++;
            }
            
            else
            {
                T[] resizeArray = new T[Capacity * 2];

                for (int i = 0; i < dArray.Length; i++)
                {
                    resizeArray[i] = dArray[i];

                }

                dArray = resizeArray;
                resizeArray[Size] = value;
                Size++;
            }


        }

        public void Insert(int index, T value)
        {
            if ((!IsFull()) && (index + 1 <= Size))
            {
                T temp = dArray[index];
                for (int i = index; i < dArray.Length; i++)
                {
                   
                    dArray[i++] = temp;
                }
                dArray[index] = value;
                for (int i = 0; i < dArray.Length; i++)
                {
                    Console.WriteLine("Index - {0}, Element - {1}", i, dArray[i]);
                }
                Size++;
            }
            else
            { 
                
            }
        }

        // The method find element located under specific index mentioned 
        // by user in Array and return it.
        // Before returning the code check if Array isn't Empty and if no
        // decrease index by 1 for user friendly return
        // If user enter 1 - the program return element under index 0 
        public T Get(int index)
        {
            if (!IsEmpty())
            {
                index--;
                Console.WriteLine("The  element - {0}", dArray[index]);
                return dArray[index];
            }
            else
            {
                return default(T);
            }
            
        }


        public void Remove(int index)
        {
        }

       
    }
}
