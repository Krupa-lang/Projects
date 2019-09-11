using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nus = new int[7];
            Console.WriteLine("Введте семь чисел: ");
            for (int i = 0; i < nus.Length; i++)
            {
                Console.Write($"{i+1}-е число: ");
                nus[i] = Convert.ToInt32(Console.ReadLine());
            }
            int temp;
            for (int i = 0; i < nus.Length-1; i++)
            {
                for (int j = i+1; j < nus.Length; j++)
                {
                    if (nus [i]> nus [j])
                    {
                        temp = nus[i];
                        nus[i] = nus[j];
                        nus[j] = temp;
                    }
                }
            }
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < nus.Length; i++)
            {
                Console.WriteLine(nus[i]);
            }
            Console.ReadLine();
        }
    }
}
