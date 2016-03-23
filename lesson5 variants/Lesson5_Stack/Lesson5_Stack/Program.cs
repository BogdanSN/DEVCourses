using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_Stack
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] stackArray = new int[10];
            MyStack stack = new MyStack(stackArray);
        

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
       
            
        
        

    }
}

