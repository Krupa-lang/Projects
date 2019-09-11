using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            Simple();
            Console.ReadLine();

        }

        static void Simple()
        {
            int[] My = new int[3];
            My[0] = 100;
            My[1] = 200;
            My[2] = 300;
            foreach (int i in My)
                Console.WriteLine(i);

            

            
            Console.WriteLine();



        }



    }
}
