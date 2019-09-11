using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {

            string userlsDone = "";
            while (userlsDone.ToLower() != "yes")
            {
                Console.WriteLine("In do/while loop");
                Console.Write("Are you done [yes] [no]: ");
                userlsDone = Console.ReadLine();
            }
            Console.ReadLine();
        }       }
    }
