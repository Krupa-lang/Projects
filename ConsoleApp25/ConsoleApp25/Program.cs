using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            Objects();
            Console.ReadLine();
            
        }

        static void Objects ()
        {
            object[] my = new object[4];
            my[0] = 10;
            my[1] = false;
            my[2] = new DateTime(1659, 3, 24);
            my[3] = "Lina + Lanaya";
            foreach (object i in my)
            {

                Console.WriteLine("Type : {0}, Valye : {1}", i.GetType(), i);
            }
            Console.WriteLine();





        }


    }
}
