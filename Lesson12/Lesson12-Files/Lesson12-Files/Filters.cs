using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Files
{
    public class Filters
    {
        private string tempResult = null;
       

        FileHandler fhandler = new FileHandler();

        public void WhiteListFilter()
        {
            const string outputFile = "Output_whitelist.txt";
            
            List<string> white = fhandler.ReadWhiteList();
            
            for (int i = 0; i < white.Count; i++)
            {
                tempResult = white[i];
                fhandler.WriteToFile(outputFile, tempResult);
            }
        }

        public void BlackListFilter()
        {
            const string outputFile = "Output_blacklist.txt";

            List<string> input = fhandler.ReadInput();
            List<string> black = fhandler.ReadBlackList();
                                    
            for (int i = 0; i < input.Count; i++)
            {
                tempResult = input[i];
                if (!black.Contains(tempResult))
                {
                    fhandler.WriteToFile(outputFile, tempResult);
                }
            }
        }

        public void CombinationFilter()
        {
            const string outputFile = "Output_blacklist_whitelist.txt";
            List<string> input = fhandler.ReadInput();
            List<string> black = fhandler.ReadBlackList();
            List<string> white = fhandler.ReadWhiteList();
            

            for (int i = 0; i < input.Count; i++)
            {
                tempResult = input[i];
                if (!black.Contains(tempResult))
                {
                    if (white.Contains(tempResult))
                    {
                        fhandler.WriteToFile(outputFile, tempResult);
                    }
                }
            }

        }

       
    }
}
