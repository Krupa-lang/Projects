using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("C# or VB");
                Console.Write("Please pick your language preference: ");
                string langChoice = Console.ReadLine();
                switch (langChoice)
                {
                    case "C#":
                        Console.WriteLine("Good choice, C# is a fine language.");
                        break;
                    case "VB":
                        Console.WriteLine("VB: OOP, multithreading and more!");
                        break;
                    default:
                        Console.WriteLine("Well.. .good luck with that!");
                        break;
                }

            Console.ReadLine();
        }
    }   }
