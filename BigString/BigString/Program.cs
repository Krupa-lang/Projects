using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BigString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Use Biglnteger:");
            BigInteger biggy =
                BigInteger.Parse("99");
            Console.WriteLine("Value of biggy is {0}", biggy);
            // Значение biggy
            Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
            // biggy четное? 
            Console.WriteLine("Is biggy a power of two?: {0}", biggy.IsPowerOfTwo) ;
            // biggy степень 2? 
            BigInteger reallyBig = BigInteger.Multiply(biggy, BigInteger.Parse ("88"));
            Console.WriteLine("Value of reallyBig is {0}", reallyBig);
            // Значение reallyBig
            Console.ReadLine();
        }
    }
}
