using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper helper = new Helper();
            Arguments arguments = new Arguments();
            string path = arguments.CommandArgs(args);
            helper.ReadFile(path);
            Console.ReadLine();
        }
    }
}
