using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Main2("dima","1");
            Main2("tanya","2");
        
            Console.ReadLine();

        }


        static void Main2(string s, string w)
        {
            Console.WriteLine(s+" "+s+" "+w+" ");
            
        }
    }
}