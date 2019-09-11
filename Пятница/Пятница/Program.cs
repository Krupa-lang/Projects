using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Пятница
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Console I/O *****");

            string a = "прет";
            
            Console.WriteLine(Guid.NewGuid());
            GetUserData();
            Method();

            Console.WriteLine(a.Equals("прет"));
            Console.ReadLine();

        }

        static void Method()
        {
            DateTime dt = new DateTime(2019, 01, 29);

            Console.WriteLine(dt.AddMonths(-4).Date);
        }


        static void GetUserData()
        {
            Console.Write("Please enter your name: "); 
            string userName = Console.ReadLine();
            Console.Write("Please enter your age: "); 
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("пожалуйста введите год: ");
            string userГод = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Hello : {userName} You are : {userAge} years old {userГод}.");

        }
    } 
}



    

        

    
     
