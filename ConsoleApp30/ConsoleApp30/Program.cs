using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrayz();
            Console.ReadLine();
        }

        static void Arrayz()
        {
            string[] Bands = { "My", "Family", "Zek" };
            Console.WriteLine("-> : ");
            for(int i = 0; i< Bands.Length; i++)
            {
                Console.WriteLine(Bands[i] + ",");
            }
            Console.WriteLine("\n");
            Array.Reverse(Bands);
                for(int i = 0; i < Bands.Length; i++)
            {
                Console.WriteLine(Bands[i] + ",");
            }

            Console.WriteLine("\n");
            Array.Clear(Bands, 5, 10);
            for(int i=0;i<Bands.Length;i++)
            {
                Console.WriteLine(Bands[i] + ",");
            }

            Console.WriteLine();
        }
    }
}
