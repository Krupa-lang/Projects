using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sstring equality: ");
            string s1 = "Hello!";
            string s2 = "Yo";
            
            Console.WriteLine($"s1= {s1}");
            Console.WriteLine("s2= {0}", s2);
            Console.WriteLine($"s1==s2:{s1==s2}");
            Console.WriteLine($"s1== HELLO!: {s1=="HELLO!"}");
            Console.WriteLine($"s1==Hello! : {s1=="Hello!"}");
            Console.WriteLine($"s1==hello! : {s1=="hello"}");
            Console.WriteLine($"s1.Equals(s2) : {s1.Equals(s2)}");
            Console.WriteLine($"Yo.Equals(s2) : {"Yo".Equals(s2)}");
            Console.ReadLine();

        } 
    }
}
