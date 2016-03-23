using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Lesson5_Stack_and_Queue
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] stackArray = new int[10];
            CommandClass comMeth = new CommandClass();
            CheckClass checkMeth = new CheckClass();
            
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("------------Commands for 10 size Stack------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Please type  - push - to put new element to Stack");
            Console.WriteLine("Please type  - pop - to remove last element from Stack");
            Console.WriteLine("Please type  - peek - to show last element from Stack");
            Console.WriteLine("Please type  - size - to get free size of Stack");
            Console.WriteLine("Please type  - clear - to clear Stack");
            Console.WriteLine("Please type  - exit - to clear Stack");
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
                        comMeth.PuchToStack(pushElement);
                        break;
                    
                    case "pop":
                        comMeth.PopFromStack();
                        break;
                    
                    case "peek":
                        //Command Peek
                        Console.WriteLine("The last element of Stack is {0}");
                        break;
                    
                    case "size":
                        checkMeth.Size(stackArray.Length);                        
                        break;
                    
                    case "clear":
                        Console.WriteLine("The Stack was succesfully cleared");
                        break;
 
                    case "exit":
                        System.Environment.Exit(1);
                        break;
                }
                Console.ReadKey();
            }
        }

    }
}
