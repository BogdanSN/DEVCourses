using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Filters filters = new Filters();
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("------------Commands for applying filters---------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Please type  - 1 - to apply WhiteList filter");
            Console.WriteLine("Please type  - 2 - to apply BlackList filter");
            Console.WriteLine("Please type  - 3 - to apply BlackList after WhiteList filter");
            Console.WriteLine("Please type  - 4 - to exit");
            Console.WriteLine("--------------------------------------------------");

            while (true)
            {
                Console.Write("Please type command:");
                int filterNumber = Int32.Parse(Console.ReadLine());
                
                switch (filterNumber)
                {
                    case 1:
                        filters.WhiteListFilter();
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Please review file Output_whitelist.txt");
                        break;

                    case 2:
                        filters.BlackListFilter();
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Please review file Output_blacklist.txt");
                        break;

                    case 3:
                        filters.CombinationFilter();
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Please review file Output_blacklist_whitelist.txt");
                        break;

                   case 4:
                        System.Environment.Exit(1);
                        break;
                }
            }
      
            Console.ReadKey();
        }
    }
}
