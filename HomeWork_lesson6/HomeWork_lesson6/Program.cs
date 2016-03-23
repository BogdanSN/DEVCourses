using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_lesson6
{
    class Program
    {
        static int arrayLenght = 0;
        static Random rand = new Random();
        static int[] stackArray = new int[10];

        static void Main(string[] args)
        {
            Console.WriteLine("Please select what you want to do:");
            Console.WriteLine("1. Sort array by Buble Sort method");
            Console.WriteLine("2. Sort array by Insertion Sort method");
            Console.WriteLine("3. Work with buffer by Stack method");
            Console.WriteLine("4. Work with buffer by Queue method");
            Console.Write("Your variant is - ");
            int method = Int32.Parse(Console.ReadLine());

            switch (method)
            {
                case 1:
                    BubleSorting ();
                    break;
                case 2:
                    InsertionSorting();
                    break;
                case 3:
                    StackBuffering();
                    break;
                case 4:
                    QueueBuffering();
                    break;
            }   
                // Press any key before close CMD
                Console.Read();
        }
        static void BubleSorting() 
        {
            // Create a new Array with Lenght defined by user and fill by Random
            Console.WriteLine("");
            Console.Write("Please enter the Lenght of your Array:");
            arrayLenght = Int32.Parse(Console.ReadLine());
            int[] intArray = new int[arrayLenght];
            for (int i = 0; i < arrayLenght; i++)
            {
                intArray[i] = rand.Next(100);
            }
            BubbleSorter bubS = new BubbleSorter(intArray);
            
            for (int i = 0; i < arrayLenght; i++)
            {
                Console.Write(" " + intArray[i]);
            }

            bubS.Sort(arrayLenght);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("sorted array by buble sort:");
            bubS.Print(arrayLenght);
                        
        }
        
        static void InsertionSorting()
        {
            // Create a new Array with Lenght defined by user and fill by Random

            Console.WriteLine(""); 
            Console.Write("Please enter the Lenght of your Array:");
            arrayLenght = Int32.Parse(Console.ReadLine());
            int[] intArray = new int[arrayLenght];
            for (int i = 0; i < arrayLenght; i++)
            {
                intArray[i] = rand.Next(100);
            }
            
            InsertionSorter insS = new InsertionSorter(intArray);
            for (int i = 0; i < arrayLenght; i++)
            {
                Console.Write(" " + intArray[i]);
            }
            
            insS.Sort(arrayLenght);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Sorted Array by Insertion Sort:");
            insS.Print(arrayLenght);
        }

        static void StackBuffering() 
        { 
            
            MyStack stack = new MyStack(stackArray);
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("------------Commands for 10 size Stack------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Please type  - push - to put new element to Stack");
            Console.WriteLine("Please type  - pop - to remove last element from Stack");
            Console.WriteLine("Please type  - peek - to show last element from Stack");
            Console.WriteLine("Please type  - exit - to program exit");
            Console.WriteLine("--------------------------------------------------");

            while (true)
            {
                Console.Write("Please type command:");
                string stackCommand = Console.ReadLine();

                switch (stackCommand)
                    {
                        case "push":
                            Console.WriteLine("Please enter element which will be added to Stack:");
                            int pushElement = Int32.Parse(Console.ReadLine());
                            stack.Push(pushElement);
                            break;

                        case "pop":
                            stack.Pop();
                            break;

                        case "peek":
                            stack.Peek();
                            break;

                        case "exit":
                            System.Environment.Exit(1);
                            break;
                    }
            }
                    
        }
        static void QueueBuffering() 
        {
            
            MyQueue queue = new MyQueue(stackArray);
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("------------Commands for 10 size Queue------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Please type  - enq - to put new element to Queue");
            Console.WriteLine("Please type  - deq - to remove last element from Queue");
            Console.WriteLine("Please type  - exit - to program exit");
            Console.WriteLine("--------------------------------------------------");

            while (true)
                        {
                            Console.Write("Please type command:");
                            string queueCommand = Console.ReadLine();

                            switch (queueCommand)
                            {
                                case "enq":
                                    Console.WriteLine("Please enter element which will be added to Queue");
                                    int pushElement = Int32.Parse(Console.ReadLine());
                                    queue.Enqueue(pushElement);
                                    break;

                                case "deq":
                                    queue.Deq();
                                    break;

                               case "exit":
                                    System.Environment.Exit(1);
                                    break;
                            }
                        }
        }
    }
}
