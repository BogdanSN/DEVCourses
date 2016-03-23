using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Lesson2_BogdanSntitsaruk
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Start the program...");
            
            //Create a cicle which will do our checking 
            for (int i = 1; i <= 100;  i++)
            {
                if ( (i % 3 == 0) && (i % 5 == 0)) // Check if number can be devided on 3 and 5
                {
                    Console.WriteLine("The "+i+" is - Lizz+Bizz");
                }
                else if (i % 5 == 0)                // Check if number can be devided on 5
                {
                    Console.WriteLine("The "+ i + " is - Bizz only");
                }
                else if (i % 3 == 0)                // Check if number can be devided on 3 
                {
                    Console.WriteLine("The "+ i + " is - Lizz only");
                }
                                                    // All other cases
                else
                {
                    Console.WriteLine("The "+ i + " is - Simple");
                }
            }
            Console.ReadKey();

        }
    }
}
