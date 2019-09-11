using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 45;

            //while(i != 500)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            string userIsDone = "";
            while (userIsDone.ToLower() != "yes")
            {
                Console.WriteLine("In while loop");
                Console.Write("Are you done [no] [yes] : ");
                userIsDone = Console.ReadLine();
            }
            
            Console.ReadLine();

            

        }
    }   }
