using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_WinForm_Filters
{
    public class Person
    {
        public void NewPerson(int timerInterval)
        {
            PersonGenerator personGen = new PersonGenerator(timerInterval);
            PersonSaver personSave = new PersonSaver();
            personGen.NewPersonGen += personSave.PersonToSave;
            string newPerson = personGen.Generator();
        }      
    }
}
