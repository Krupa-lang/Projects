using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escape characters : \a ");
            string Thaps = "Model \tColor \tSpeed \tPet Name\a ";

        

            Console.WriteLine("{0}", Thaps);
            Console.WriteLine("Everony loves \" Hello ",
                "World\"\r " );
            Console.WriteLine("C: \\MyApp\\bin +",
                "\\debug\r");
            Console.WriteLine("All finished.\n \n \n \n \a\r ");
            Console.WriteLine(@"C:\aMyApp
                                      \bin
                                            \adebug");
            Console.ReadLine();


        }
    }
}
