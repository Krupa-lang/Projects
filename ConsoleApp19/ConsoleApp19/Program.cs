using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            string st = "Floop";
            string st2 = "Flip";
            
            
            Console.WriteLine($"Before= {st},{st2}");
            Add(ref st, ref st2);
            Console.WriteLine($"After= {st},{st2}");
            
            Console.ReadLine();


        }
        
        static void Add(ref string s1, ref string s2)
        {
            string Foo = s1;
            s1 = s2;
            s2 = Foo;
            
           


        }



    }



}




