using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Files
{
    public class Person
    {
        public string Name { set; get; }
        public string Surname { set; get; }
        
        
        public void NewPerson()
        {

            Console.WriteLine("Please specify Timer interval:");
            int timerInterval = Int32.Parse(Console.ReadLine());
            
            PersonGenerator personGen = new PersonGenerator(timerInterval);
            PersonSaver personSave = new PersonSaver();
            personGen.NewPersonGen += personSave.PersonToSave;
            string newPerson = personGen.Generator();
            

            
            
        }      

    }
}
