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
            DynamicArray<int> dynArr = new DynamicArray<int>();
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("------------Commands for 4 size Dynamic Array-----");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Please type  - add - to put new element to Array");
            Console.WriteLine("Please type  - insert - to insert ");
            Console.WriteLine("Please type  - get - to get");
            Console.WriteLine("Please type  - remove - to remove");
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
                        

                    case "insert":
                        Console.WriteLine("Possition in Array:");
                        int insPos = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Element:");
                        int insElem = Int32.Parse(Console.ReadLine());
                        dynArr.Insert(insPos,insElem);
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
