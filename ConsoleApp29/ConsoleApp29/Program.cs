using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {  
            Pass();
            Console.ReadLine();
        }
        static void Print(int[] myInts)
        {
            for(int i=0; i<myInts.Length; i++)
            {
                Console.WriteLine($"{i}, {myInts[i]}");
            }
        }

        static string[] App()
        {

            string[] The = { "Hello", "From", "GetStringsArray" };
            return The;
        }
        static void Pass()
        {
            int [] ages = { 20, 22, 23, 0 };
            Print(ages);
            string[] str = App();
            foreach(string s in str)
            {
                Console.WriteLine(s);
            }
            
        }
        
    }
}
