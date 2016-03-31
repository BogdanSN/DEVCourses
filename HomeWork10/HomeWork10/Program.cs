using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select what you want to do:");
            Console.WriteLine("1. Work with Dynamic Array");
            Console.WriteLine("2. Work with buffer by Stack method");
            Console.WriteLine("3. Work with buffer by Queue method");
            Console.Write("Your variant is - ");
            int method = Int32.Parse(Console.ReadLine());

            switch (method)
            {
                case 1:
                    DynamicArray();
                    break;
                case 2:
                    StackBuffering();
                    break;
                case 3:
                    QueueBuffering();
                    break;
            }
            // Press any key before close CMD
            Console.Read();
        }

        static void DynamicArray()
        {
            DynamicArray<int> dynArr = new DynamicArray<int>();
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("------------Commands for 4 size Dynamic Array-----");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Please type  - add - to put new element to Array");
            Console.WriteLine("Please type  - ins - to insert element into specific possition");
            Console.WriteLine("Please type  - get - to show element from specific possition");
            Console.WriteLine("Please type  - rem - to remove element from specific position");
            Console.WriteLine("Please type  - show - to show all elements in Array");
            Console.WriteLine("Please type  - exit - to program exit");
            Console.WriteLine("--------------------------------------------------");

            while (true)
            {
                Console.Write("Please type command:");
                string stackCommand = Console.ReadLine();

                switch (stackCommand)
                {
                    case "add":
                        Console.WriteLine("Please enter element which will be added to Array:");
                        int addElement = Int32.Parse(Console.ReadLine());
                        dynArr.Add(addElement);
                        break;

                    case "get":
                        Console.WriteLine("Please enter element possition in Array:");
                        int getPos = Int32.Parse(Console.ReadLine());
                        dynArr.Get(getPos);
                        break;


                    case "ins":
                        Console.WriteLine("Possition in Array:");
                        int insPos = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Element:");
                        int insElem = Int32.Parse(Console.ReadLine());
                        dynArr.Insert(insPos, insElem);
                        break;

                    case "rem":
                        Console.WriteLine("Possition in Array:");
                        int remPos = Int32.Parse(Console.ReadLine());
                        dynArr.Remove(remPos);
                        break;

                    case "show":
                        Console.WriteLine("See whole Array:");
                        dynArr.Print();
                        break;


                    case "exit":
                        System.Environment.Exit(1);
                        break;
                }
            }
        }

        static void StackBuffering()
        {

            DynamicStack<int> stack = new DynamicStack<int>();
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("------------Commands for Dynamic Stack------------");
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

            DynamicQueue<int> queue = new DynamicQueue<int>();
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("------------Commands for Dynamic Queue------------");
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

                    case "show":
                        Console.WriteLine("See whole Queue:");
                        queue.Print();
                        break;

                    case "exit":
                        System.Environment.Exit(1);
                        break;
                }
            }
        }
    }
}
