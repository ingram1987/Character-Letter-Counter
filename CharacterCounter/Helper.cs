using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace CharacterCounter
{
    class Helper
    {
        //Checks is a charachter is a valid letter
        private static bool IsValid(Char chr)
        {
            string testString = chr.ToString();
            Regex rgx = new Regex(@"[a-zA-Z]");
            try
            {
                return rgx.IsMatch(testString);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public void ReadFile(string txtPath)
        {
            var letterDict = new Dictionary<char, int>
            {
                ['a'] = 0,
                ['b'] = 0,
                ['c'] = 0,
                ['d'] = 0,
                ['e'] = 0,
                ['f'] = 0,
                ['g'] = 0,
                ['h'] = 0,
                ['i'] = 0,
                ['j'] = 0,
                ['k'] = 0,
                ['l'] = 0,
                ['m'] = 0,
                ['n'] = 0,
                ['o'] = 0,
                ['p'] = 0,
                ['q'] = 0,
                ['r'] = 0,
                ['s'] = 0,
                ['t'] = 0,
                ['u'] = 0,
                ['v'] = 0,
                ['w'] = 0,
                ['x'] = 0,
                ['y'] = 0,
                ['z'] = 0
            };
            TimeSpan totalProcessingTime = new TimeSpan();
            DateTime timeStart = DateTime.Now;
            StreamReader sr = new StreamReader(txtPath);
            char[] buffer = new char[1024];
            int read = 0;
            try
            {
                while ((read = sr.ReadBlock(buffer, 0, buffer.Length)) > 0)
                {
                    for (int j = 0; j < read; j++)
                    {
                        //bool test1 = IsValid(buffer[j]);
                        if (IsValid(buffer[j]))
                        {
                            letterDict[Char.ToLower(buffer[j])] = letterDict[Char.ToLower(buffer[j])] + 1;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            
            //Print dictionary sorted alphabetically
            Console.WriteLine("Sorted by letter:\n");
            foreach (KeyValuePair<char, int> code in letterDict)
            {
                Console.WriteLine((char)code.Key + " - " + code.Value);
            }

            //Print dictionary sorted by letter count
            var sortedCharDictionary = from entry in letterDict orderby entry.Value descending select entry;
            Console.WriteLine("\nSorted by count:\n");
            foreach (KeyValuePair<char, int> code in sortedCharDictionary)
            {
                Console.WriteLine((char)code.Key + " - " + code.Value);
            }
            totalProcessingTime = DateTime.Now - timeStart;
            Console.WriteLine("\nTotal Time Processing: " + totalProcessingTime);
            
        }
    }
}
