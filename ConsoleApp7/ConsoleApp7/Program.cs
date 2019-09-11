using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Таня, реши следующие примеры: 
            //a) -1 * 5 + 12, 
            // b) 5 * 5 + 3, 
            // c) 4 * 2 + 1


            var a = 8;
            float b = ReshiPrimer(5, 5, 3);
            Single c = ReshiPrimer(4, 2, 1);

            // d) a / c

            float d = a / c;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " +c);
            Console.WriteLine("d = " + d);


            Console.ReadLine();
        }

        static float ReshiPrimer(float x, float y, float z)
        {
            float result = x * y + z;
            return result;
        }


    }
}
