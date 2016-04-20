using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Lesson15_WinForm_Filters
{
    public delegate void NewPersonGeneratedEventHandler(object sender, NewPersonEventArgs args);



    public class PersonGenerator
    {
        public event NewPersonGeneratedEventHandler NewPersonGen;

        Timer timer = new Timer();

        public PersonGenerator() { }

        public PersonGenerator(int interval)
        {
            timer.Interval = interval * 1000;
            timer.AutoReset = true;
            timer.Elapsed += timer_Elapsed;
            timer.Enabled = true;
            timer.Start(); ;
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Generator();
        }


        public string GenerateNewPerson()
        {
            FileHandler fhandler = new FileHandler();
            Random rand = new Random();

            List<string> namesList = fhandler.ReadFileNames();
            List<string> surnamesList = fhandler.ReadSurnamesFile();
            string person = null;

            int namesCount = namesList.Count;
            int surNames = surnamesList.Count;
            int currentName = rand.Next(namesCount);
            int currentSurname = rand.Next(surNames);

            return person = String.Format("{0} {1}", namesList[currentName], surnamesList[currentSurname]);


        }

        public string Generator()
        {
            string person = GenerateNewPerson();
            NewPersonCreated(person);
            return person;
        }

        public void NewPersonCreated(string person)
        {


            if (NewPersonGen == null)
            {
                return;
            }

            NewPersonEventArgs args = new NewPersonEventArgs();
            args.person = person;
            args.genTime = DateTime.Now;
            NewPersonGen(this, args);
        }

    }
}
