using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp46
{
    class Counter
    {
        public int Vaiue { get; set; }
        public static Counter operator +(Counter c1, Counter c2)
        {
            return new Counter { Vaiue = c1.Vaiue + c2.Vaiue };
        }

        public static bool operator >(Counter c1, Counter c2)
        {
            return c1.Vaiue > c2.Vaiue;
        }
        public static bool operator <(Counter c1, Counter c2)
        {
            return c1.Vaiue < c2.Vaiue;
        }
        public static int operator +(Counter c1, int set)
        {
            return c1.Vaiue + set;
                }
        public static Counter operator ++( Counter c1)
        {
            return new Counter { Vaiue = c1.Vaiue + 10 };
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Counter c1 = new Counter { Vaiue = 23 };
            Counter c2 = new Counter { Vaiue = 45 };
            int d = c1 + 56;
            Console.WriteLine( d);
            bool r = c1 > c2;
            Console.WriteLine(r);
            Counter c3 = c1 + c2;
            Console.WriteLine(c3.Vaiue);
            Console.ReadLine();
        }
    }
}
