using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Lesson4_buble
{
    class Program
    {
        static void Main(string[] args)
        {

            int arrayLenght = 0;
            Random rand = new Random();

            // The user enter the Array size
            Console.Write("Please enter the Lenght of your Array:");
            arrayLenght = Int32.Parse(Console.ReadLine());

            //Declare the new Array with Lenght = arLenght
            int[] intArray = new int[arrayLenght];

            // Fill array by Random values
            for (int i = 0; i < arrayLenght; i++)
            {
                intArray[i] = rand.Next(100);
                Console.Write(" "+intArray[i]);
            }

            //Sort Array
            buble_Swap(intArray, arrayLenght);

            // Show sorted array
            Console.WriteLine("");
            Console.WriteLine("Sorted Array:");
            for (int i = 0;i < arrayLenght; i++)
            {
                Console.Write(" " + intArray[i]);
            }
                        
            // Press any key before close CMD
            Console.Read();
        }
        
        static void buble_Swap(int[] array, int arrLenght)
        {
            // Declare new value which will check if any Swaps occurs
            bool isSwap = false;

            // Do Swaps while we have no Swaps at all
            while (!isSwap)
            {
                isSwap = true; 

                for (int i = 0; i < arrLenght - 1; i++)
                {
                    if (array[0] > array[i + 1])
                    {
                        int swapTemp = array[0];
                        array[0] = array[i + 1];
                        array[i + 1] = swapTemp;
                        isSwap = false;
                    }
                }
                
            }
        }
       
        

    }
}
