using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._06
{
    class Program
    {
        static void Main(string[] args)
        {
            Good();
            Console.ReadLine();



        }


        private static void Good()
        {


            Console.WriteLine("=> Basic Strig functionality: ");
            string FirstName = "Freddy";
            Console.WriteLine("Value of FirstName: {0}", FirstName);
            Console.WriteLine("FirstName has : {0} characters", FirstName.Length);
            Console.WriteLine("FirstName in uppercase: {0}", FirstName.ToUpper());
            Console.WriteLine("FurstName in lowercase :{0}", FirstName.ToLower());
            Console.WriteLine("FurstName contains the letter y ? {0}", FirstName.Contains("y"));
            Console.WriteLine("FurstName after replace : {0}", FirstName.Replace("dy", ""));

        }
    }
}   




       


