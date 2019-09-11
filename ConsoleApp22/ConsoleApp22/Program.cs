using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            Message(message: "Wow", textColor: ConsoleColor.DarkRed, backgraungColor: ConsoleColor.White);
            Message(backgraungColor: ConsoleColor.Green,
            message: "Testing...",
             textColor: ConsoleColor.DarkBlue);
            Console.ReadLine();


        }

       static void Message(ConsoleColor textColor, ConsoleColor backgraungColor, string message)
        {
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldbackgraungColor = Console.BackgroundColor;
            Console.BackgroundColor = backgraungColor;
            Console.ForegroundColor = textColor;
            Console.WriteLine(message);
            Console.BackgroundColor = oldbackgraungColor;
            Console.ForegroundColor = oldTextColor;
            Console.WriteLine(message + "--------");

        }
    }
}
