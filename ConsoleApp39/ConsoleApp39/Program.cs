using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 25;
            int b = 35;
            int result = Sum(a, b);
            Console.WriteLine(result);  // 60

            result = Sum(b, 45);
            Console.WriteLine(result);  // 80

            result = Sum(a + b + 12, 18); // "a + b + 12" представляет значение параметра x
            Console.WriteLine(result);  // 90

            Console.ReadKey();
        }
        static int Sum(int x, int y)
        {
            return x + y;
        }
    }
    }
}
