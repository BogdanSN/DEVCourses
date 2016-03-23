using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLenght = 0;


            // The user enter the Array size
            Console.Write("Please enter the Lenght of your Array:");
            arrayLenght = Int32.Parse(Console.ReadLine());

            //Declare the new Array with Lenght = arLenght
            int[] intArray = new int[arrayLenght];

            // Fill each element of Array and find Min and Max Value
              int minValue = intArray[0];
              int maxValue = intArray[0];

            for (int i = 0; i < arrayLenght; i++)
            {
                Console.Write("Please enter the value for Array element " + i + " - ");
                intArray[i] = Convert.ToInt32(Console.ReadLine());

                if (maxValue < intArray[i])
                {
                    maxValue = intArray[i];
                }

                if (minValue > intArray[i])
                {
                    minValue = intArray[i];
                }
            }

            Console.WriteLine("The Max Value is: " + maxValue);
            Console.WriteLine("The Min Value is: " + minValue);

            Console.ReadLine();
        }
     
    }


}
