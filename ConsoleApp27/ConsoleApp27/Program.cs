using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            try
            {
                i = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Вы ввели не те значения. Необходимо вводить только цифры. \n\n\n\n\n" +
                    "Сообщение для разработчика:" + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


    Console.WriteLine("Вы ввели: " + i);
            Console.ReadLine();

        }


    }
}
