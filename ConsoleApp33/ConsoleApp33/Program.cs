using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
            foreach (string c in carTypes)
                Console.WriteLine(c);
            int[] mylnts = { 160, 20, 76, 40 };
            foreach (int i in mylnts)
                Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
