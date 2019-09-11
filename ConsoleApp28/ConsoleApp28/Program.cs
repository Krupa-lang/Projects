using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            Lagger();
            Console.ReadLine();
        }

        static void Lagger()
        {

            int[][] My = new int[5][];
            for (int i = 0; i < My.Length; i++)
                My[i] = new int[i + 7];
            for (int i = 0;i<5;i++)
            {
               for(int j=0; j<My[i].Length;j++)
                    Console.WriteLine(My[i] [j] + "");
                Console.WriteLine();

            }

            Console.WriteLine();
        }


    }       }
