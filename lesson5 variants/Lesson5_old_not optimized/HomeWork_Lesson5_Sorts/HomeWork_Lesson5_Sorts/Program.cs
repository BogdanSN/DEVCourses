using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Lesson5_Sorts
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLenght = 0;
            Random rand = new Random();
            PrintResult prRes = new PrintResult();
            BubleSort bubSort = new BubleSort();
            InsertionSort insSort = new InsertionSort();
            
            // Create a new Array with Lenght defined by user and fill by Random
            Console.Write("Please enter the Lenght of your Array:");
            arrayLenght = Int32.Parse(Console.ReadLine());
            int[] intArray = new int[arrayLenght];
            for (int i = 0; i < arrayLenght; i++)
            {
                intArray[i] = rand.Next(100);
            }
            prRes.PrintResultFunc(intArray, arrayLenght);

            Console.WriteLine(""); 
            Console.WriteLine("");
            Console.WriteLine("Please select Sorting Method to sort your array:");
            Console.WriteLine("Enter - 1 - to sort by Buble Sort Method");
            Console.WriteLine("Enter - 2 - to sort by Insertion Sort Method");
            Console.Write("Your variant is - ");
            int methodCase = Int32.Parse(Console.ReadLine());

            switch (methodCase)
            { 
                case 1:
                    //Sorting array by Buble Sort Method
                    bubSort.BubleSortFunc(intArray, arrayLenght);
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("sorted array by buble sort:");
                    prRes.PrintResultFunc(intArray, arrayLenght);
                    break;

                case 2:
                    //Sorting array by Insertion Sort Method
                    insSort.InsertionSortFunc(intArray, arrayLenght);
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Sorted Array by Insertion Sort:");
                    prRes.PrintResultFunc(intArray, arrayLenght);
                    break;
            }

            // Press any key before close CMD
            Console.Read();
        }
                
    }
    }
