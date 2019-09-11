using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x=");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y=");
            var y = Convert.ToInt32(Console.ReadLine());
            Console.Write("z=");
            var z = Convert.ToInt32(Console.ReadLine());
            int c;
            decimal b;
            decimal r;

            c = One(x, y, z);
            b = Two(x, y, z);
            r = Free(x, y, z);
            Console.Write($" x + y * (z - y)= {c}");
            Console.ReadLine();
            Console.Write($"(x + x - 3 * y - 15) * z= {b}");
            Console.ReadLine();
            Console.Write($"x / (y + 5) ^ 2 * 12= {r}");
            Console.ReadLine();

        }

        public static int One(int x, int y, int z)
        {

            int q= x + y * (z - y);
            
            return q;      

        }

        public static decimal Two(int x, int y, int z)
        {
            decimal w = (x + x - 3 * y - 15) * z;

            Math.Round(w);
            return w;

        }
        public static decimal Free(int x, int y, int z)

        {
            decimal e = x / (decimal)Math.Pow((y + 5), 2) * 12;
            Math.Truncate(e);
            return e;

        }


    }
}  









