using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Rect();

        }


        static void Rect()
        {
            int[,] Matrixs;
            Matrixs = new int[6,6];
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 6; j++)
                    Matrixs[i, j] = i * j;
            for (int i = 0; i < 6; i++)
            {
                for(int j = 0; j < 6; j++)
                    Console.WriteLine(Matrixs[i,j] + "/t");
                Console.WriteLine();
            }

            Console.WriteLine();


        }
        

       



    }
}
