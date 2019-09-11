using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string var in args)
            {

            }
            {
                Conf();
                Console.ReadLine();

            }
        }

        private static void Conf()
        {
            Console.Title = "My Rocking App";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;

            Console.WriteLine("***** Welcome to My Rocking App *****");

            Console.BackgroundColor = ConsoleColor.Gray;
        }
    }
}