using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_WinForm_Filters
{
    public class PersonSaver
    {
        private string resultPerson = null;

        public string Result
        {
            get
            {
                return resultPerson;
            }
        }
        
        public void PersonToSave(object sender, NewPersonEventArgs args)
        {
            FilterApplier fApplier = new FilterApplier();
            FileHandler fHandler = new FileHandler();


            resultPerson = fApplier.SearchPerson(args.person);

            if (resultPerson != null)
            {
                fHandler.WriteToFile(resultPerson+"\t"+args.genTime);
                
            }
            
        }
    }
}
