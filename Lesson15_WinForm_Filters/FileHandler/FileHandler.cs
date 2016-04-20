using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson15_WinForm_Filters
{
    public class FileHandler
    {
        private const string fileNames = "Names.txt";
        private const string fileSurnames = "Surnames.txt";
        private const string fileBlackList = "Blacklist.txt";
        private const string fileWhiteList = "Whitelist.txt";
        private const string fileOutput = "Output.txt";


        List<string> namesList = new List<string>();
        List<string> surnamesList = new List<string>();
        List<string> blackList = new List<string>();
        List<string> whiteList = new List<string>();



        // Common method for reading from files and put info to List<string> Collection
        private void ReadFromFile(string filePath, List<string> outputList)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    outputList.Add(line);

                }
            }
        }

        // Common method for writing to files 
        public void WriteToFile(string result)
        {
            using (StreamWriter writer = new StreamWriter(fileOutput, true))
            {
                writer.WriteLine(result);

            }
        }

        // Reading Names.txt file
        public List<string> ReadFileNames()
        {
            ReadFromFile(fileNames, namesList);
            return namesList;
        }

        // Reading Surname.txt file
        public List<string> ReadSurnamesFile()
        {
            ReadFromFile(fileSurnames, surnamesList);
            return surnamesList;
        }

        // Reading WhiteList.txt file
        public List<string> ReadWhiteList()
        {
            ReadFromFile(fileWhiteList, whiteList);
            return whiteList;
        }

        // Reading BlackList.txt file
        public List<string> ReadBlackList()
        {
            ReadFromFile(fileBlackList, blackList);
            return blackList;
        }
    }
}
