using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 [C#], 2 [VB]");
            Console.Write("Please pick the language preference: ");
            string lang = Console.ReadLine();
            int n = int.Parse(lang);
            switch (n)
            {
                case 1:
                    Console.WriteLine("Good  shoice, C# is a fine language");
                    break;
                case 2:
                    Console.WriteLine("VB: OOP, multithreading, and more!");
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;
                   
            }
            Console.ReadLine();
        }
    }
}
