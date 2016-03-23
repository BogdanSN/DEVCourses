using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable definition
            double FirstDigit = 0;
            double SecondDigit = 0;
            string StrFirstDigit = null;
            string StrSecondDigit = null;

            //Working with First Digit
            Start1:
            Console.Write("Please enter First Positive Integer Number:");
            StrFirstDigit = Console.ReadLine();
            Console.WriteLine("<->");

                //Check if user enter any digit
                if (StrFirstDigit == "")
                {
                    Console.WriteLine("You forgot to enter digit, try again");
                    Console.WriteLine("<->");
                    goto Start1;
                }
            
                //Check if entered dates are digitals
                if (!double.TryParse(StrFirstDigit, out FirstDigit))
                {
                    Console.WriteLine("You entered incorrect info, try again");
                    Console.WriteLine("<->");
                    goto Start1;
                }
                        
            FirstDigit = double.Parse(StrFirstDigit);
            
            //Checking if entered digit is really positive and integer
            double CheckFirstInt = Math.Round(FirstDigit);
            
                if ((FirstDigit < 0)||(CheckFirstInt-FirstDigit!=0))
                {
                    Console.WriteLine("You entered the incorrect digit, try again");
                    Console.WriteLine("<->");
                    goto Start1;
                }
                          
            //Worknig with Second Digit 
            Start2:
            Console.Write("Please enater Second Positive Integer Number differ from 0:");
            StrSecondDigit = Console.ReadLine();
            Console.WriteLine("<->");
            
                //Check if user enter any digit
                if (StrSecondDigit == "")
                {
                    Console.WriteLine("You forgot to enter digit, try again");
                    Console.WriteLine("<->");
                    goto Start2;
                }

                //Check if entered dates are digitals
                if (!double.TryParse(StrSecondDigit, out SecondDigit))
                {
                    Console.WriteLine("You entered incorrect info, try again");
                    Console.WriteLine("<->");
                    goto Start2;
                }
            SecondDigit = double.Parse(StrSecondDigit);

                //Checking if entered digit is really positive, integer and not 0
            double CheckSecondInt = Math.Round(SecondDigit);

            if ((SecondDigit < 0) || (CheckSecondInt - SecondDigit != 0) || (SecondDigit == 0))
                {
                    Console.WriteLine("You entered the incorrect digit, try again");
                    Console.WriteLine("<->");
                    goto Start2;
                }
                         
            //Checking if second value is divider to frist
            if (FirstDigit % SecondDigit == 0)
            {
                Console.WriteLine("<---Great News!!! Entered digits can be divided entirely--->");
                Console.WriteLine("<->");
            }
            else 
            {
                Console.WriteLine("<---Bad News!!! Entered digits cann't be divided entirely--->");
                Console.WriteLine("<->");
            }
            
            // Keep the console open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
