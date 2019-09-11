using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            double ar;

            //double[] data = { 5, 6, 7 };
            ar = Awa(6, 7, 9);
            Console.WriteLine($"Liniya= {ar}");
            Console.ReadLine();

        }

        static double Awa(params double[] x)
        {
            Console.WriteLine($"You stnt me {x.Length}");
            double sum = 0;
            if (x.Length == 0) 
                return sum;
            for (int i = 0; i < x.Length; i++) 
                sum += x[i];
            return (sum / x.Length);
        }



    }


}
