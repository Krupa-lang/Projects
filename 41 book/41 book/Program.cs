using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_book
{
    class Program
    {
        static void Main(string[] args)
        {
            YYY(1, 2, 3, 4, 5);

            int[] array = new int[] { 1, 2, 3, 4 };
            YYmas(array, 2);

            Console.ReadLine();
        }

        static void YYY(params int[] inte)
        {
            int result = 0;
            for (int i = 0; i < inte.Length; i++)
            {
                result += inte[i];
            }
            Console.WriteLine(result);
        }
        static void YYmas(int[] inte, int k)
        {
            int result = 0;
            for (int i = 0; i < inte.Length; i++)
            {
                result += (inte[i] * k);
            }
            Console.WriteLine(result);

        }
    }
}
