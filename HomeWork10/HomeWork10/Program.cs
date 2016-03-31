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
                        dynArr.Insert(insPos,insElem);
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


                Console.ReadKey();
            }
        }
    }
}
