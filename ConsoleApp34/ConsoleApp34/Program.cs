using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = { { 1, 2, 3 }, 
                            { 4, 5, 6 }, 
                            { 7, 8,4 }, 
                            { 10, 11, 12 }, 
                            { 1, 2, 3 } };
            int[,] m = { { 1, 2, 3 },
                            { 4, 5, 6 },
                            { 7, 8,4 },
                            { 10, 11, 12 },
                            { 1, 2, 3 } };

            

            m[0, 0] = 90;


            int rows = mas.GetLength(0);
            int columns = mas.GetLength(1);
            // или так
            //int columns = mas.GetUpperBound(1) + 1;


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
