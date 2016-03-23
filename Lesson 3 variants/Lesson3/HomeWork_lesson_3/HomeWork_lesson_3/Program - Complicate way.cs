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
         
            for (int i = 0; i < arrayLenght; i++ )
            {
                Console.Write("Please enter the value for Array element " + i + " - ");
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The Max Value is: " + GetMaxValue(intArray));
            Console.WriteLine("The Min Value is: " + GetMinValue(intArray));

            Console.ReadLine();
        }
        static int GetMaxValue(int[] arrayMaxValue)
        {
            int maxValue = arrayMaxValue[0];
            
            for (int i = 0; i < arrayMaxValue.Length; i++)
            {
                if (maxValue < arrayMaxValue[i])
                {
                    maxValue = arrayMaxValue[i];
                } 
            }
            return maxValue;
        }
        
        static int GetMinValue(int[] arrayMinValue)
        {
            int minValue = arrayMinValue[0];

            for (int i = 0; i < arrayMinValue.Length; i++)
            {
                if (minValue > arrayMinValue[i])
                {
                    minValue = arrayMinValue[i];
                }
            }
            return minValue;
        }
    }


}
