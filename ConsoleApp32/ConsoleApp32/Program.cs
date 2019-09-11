using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{

    class Program
    {
        static void Main(string[] args)
        {
            EmpType e = EmpType.Contractor;
            AskForBonus(e);
            Console.ReadLine();

        }

        static void AskForBonus(EmpType e)
        {
            switch (e)
            {
                case EmpType.Manager:
                    Console.WriteLine("option");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("Realy");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("Oh no...");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("GOOD");
                    break;
            }

        }
    }
}
