using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stackArray = new int[4];
            MyQueue queue = new MyQueue(stackArray);

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
