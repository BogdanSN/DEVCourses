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
       

        FileReader fr = new FileReader();

        public void WhiteListFilter()
        {
            const string outputFile = "Output_whitelist.txt";
            
            List<string> white = fr.ReadWhiteList();
            
            for (int i = 0; i < white.Count; i++)
            {
                tempResult = white[i];
                fr.WriteToFile(outputFile, tempResult);
            }
        }

        public void BlackListFilter()
        {
            const string outputFile = "Output_blacklist.txt";

            List<string> input = fr.ReadInput();
            List<string> black = fr.ReadBlackList();
                                    
            for (int i = 0; i < input.Count; i++)
            {
                tempResult = input[i];
                if (!black.Contains(tempResult))
                {
                    fr.WriteToFile(outputFile, tempResult);
                }
            }
        }

        public void CombinationFilter()
        {
            const string outputFile = "Output_blacklist_whitelist.txt";
            List<string> input = fr.ReadInput();
            List<string> black = fr.ReadBlackList();
            List<string> white = fr.ReadWhiteList();
            

            for (int i = 0; i < input.Count; i++)
            {
                tempResult = input[i];
                if (!black.Contains(tempResult))
                {
                    if (white.Contains(tempResult))
                    {
                        fr.WriteToFile(outputFile, tempResult);
                    }
                }
            }

        }

       
    }
}
