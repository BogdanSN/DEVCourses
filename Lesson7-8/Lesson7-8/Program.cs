using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_8
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Please enter the Lenght of your Array:");
            int arrayLenght = Int32.Parse(Console.ReadLine());

            int[] intArray = new int[arrayLenght];
            Random rand = new Random();

            for (int i = 0; i < arrayLenght; i++)
            {
                intArray[i] = rand.Next(100);
            }

            Console.WriteLine("Generated Array:");
            
            for (int i = 0; i < arrayLenght; i++)
            {
                Console.Write(" "+ intArray[i]);
            }

            childSorter chSort = new childSorter(intArray);
            chSort.Sort();
            chSort.Print();
           
            Console.ReadKey();

        }
    }
}
