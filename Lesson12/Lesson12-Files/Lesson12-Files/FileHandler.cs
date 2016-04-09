using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Files
{
    public class FileHandler
    {
        private const string inputFile  = "Input.txt";
        private const string blackFile  = "Blacklist.txt";
        private const string whiteFile  = "Whitelist.txt";


        List<string> inputList = new List<string>();
        List<string> blackList = new List<string>();
        List<string> whiteList = new List<string>();

      

        // Common method for reading from files and put info to List<string> Collection
        private void ReadFromFile (string filePath, List<string> outputList)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    outputList.Add(line);
                    Console.WriteLine(line);
                }
            }
        }

        // Common method for writing to files 
        public void WriteToFile(string filePath, string result)
        {
            using (StreamWriter writer = new StreamWriter(filePath,true))
            {
                writer.WriteLine(result);
                
            }
        }

        // Reading Input.txt file
        public List<string> ReadInput()
        {
            ReadFromFile(inputFile, inputList);
            return inputList;
        }

        // Reading WhiteList.txt file
        public List<string> ReadWhiteList()
        {
            ReadFromFile(whiteFile, whiteList);
            return whiteList;
        }

        // Reading BlackList.txt file
        public List<string> ReadBlackList()
        {
            ReadFromFile(blackFile, blackList);
            return blackList;
        }
    }
}
