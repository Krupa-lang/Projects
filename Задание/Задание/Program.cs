using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание
{
    class Program
    {
        static void Main(string[] args)
        {
            //ValidNumber2();

            InputNumberInArray();
            Console.ReadLine();
        }

        static void ValidNumber2()
        {
            string a = Console.ReadLine();
            if (Int32.TryParse(a, out int number))
            {
                Console.WriteLine("Эт число: " + number);
            }
            else
            {
                Console.WriteLine("Эт не число");
            }
        }

        static void  ValidNuber()
        {
            try
            {
               int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a);

            }
            catch (Exception)
            {
                Console.WriteLine("Ты ввел фигню");
            }
        }




        static void InputNumberInArray()
        {

            int size = 5;

            int[] a = new int[size];

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Введите элемент: " );
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " * ");
            }


        }

        static void CheckLimitNumber()
        {
            int z = Convert.ToInt32(Console.ReadLine());

            if (z < 1 || z >= 20)
            {
                Console.WriteLine("Выход за диапазон");
            }
            else
            {
                Console.WriteLine("Норм");
            }
        }

        static void Chislo()
        {      

        }

    }
}
