using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static int a = 0;

        static void Main(string[] args)
        {
            LogData(3, "Oh no! ", "Admin");
            LogData(message:"I Cant ");
            LogData();
            Console.ReadLine();

        }

        static void LogData(int errorNumm = 0, string message = "Сообщение по умолчанию",
            string owner = "Programmer")
        {
            Console.WriteLine();
            if (a == 1)
            {
                Console.Beep();
            }
            a++;
            Console.Write($"Error= {message}");
            Console.Write($"\tOwner of Error={owner}");


        }
    }
}
