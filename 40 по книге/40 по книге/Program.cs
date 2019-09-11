using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_по_книге
{
    class Program
    {
        static void Main(string[] args)
        {
            Yota(1, 2, 3, 4, 5, 6);
            int[] array = new int[] { 1, 2, 3, 4, 5 };
                  Yota(array);
            Yota();
            Console.ReadLine();



        }
        static void Yota( params int[] integers)
        {

            int res = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                res += integers[i];
            }
            Console.WriteLine(res);

        }
                    
    }
}
