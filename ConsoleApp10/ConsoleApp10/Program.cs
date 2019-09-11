using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Using the StringBuilder");
            StringBuilder sd = new StringBuilder("Fantastic Games");
            sd.Append("\n");
            sd.AppendLine("Half Life");
            sd.AppendLine("WarCraft");
            sd.AppendLine("Deus" + "Ex" + "2");
            sd.AppendLine("Sistem Shok");
            Console.WriteLine(sd.ToString());
            sd.Replace("2", "Invisibli War");
            Console.WriteLine(sd.ToString());
            Console.WriteLine("sd has {0} shars.",sd.Length);
            Console.ReadLine();

                

            
        }
    }
}
