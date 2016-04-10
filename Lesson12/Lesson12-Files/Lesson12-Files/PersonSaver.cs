using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Files
{
    public class PersonSaver
    {
         public void PersonToSave(object sender, NewPersonEventArgs args)
        {
            FilterApplier fApplier = new FilterApplier();
            FileHandler fHandler = new FileHandler();


            string result = fApplier.SearchPerson(args.person);

            if (result != null)
            {
                fHandler.WriteToFile(result);
                Console.WriteLine("Welcome new person generated - {0} at {1}", result, args.genTime);
            }
        }
    }
}
