using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CharacterCounter
{
    class Arguments
    {
        public string CommandArgs(string[] commandArgs)
        {
            if (commandArgs.Length == 0 || commandArgs == null)
            {
                Console.WriteLine("Please specify a txt file");
                return null;
            
            }
            else if (commandArgs.Length == 1)
            {
                if (File.Exists(commandArgs[0]))
                {
                    return commandArgs[0];
                }
                Console.WriteLine("File doesn't exist");
                return null;
            }
            else
            {
                Console.WriteLine("Please specify a txt file. Check path format");
                return null;
            }
            
        }
    }
}
