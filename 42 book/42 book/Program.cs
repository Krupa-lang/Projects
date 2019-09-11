using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_book
{
    class Program
    {
        enum Up
        {
            Таня=1,
            молодец,
            но,
            голова, 
            болит, 
            еще
        }
        static void Main(string[] args)
        {
            Troi(4, 6, Up.голова);
            Troi(6, 8, Up.но);
            Console.ReadLine();
        }
        static void Troi(double x, double y, Up kola)
        {
            double res = 10;      //тут может быть любое значение, потому что свичь все перекрывает?
            switch (kola)
            {
                case Up.Таня:
                    res = x + y;
                    break;
                case Up.молодец:
                    res = x - y;
                    break;
                case Up.но:
                    res = x * y;
                    break;
                case Up.голова:
                    res = x / y;
                    break;
                case Up.болит:
                    res = x + x;
                    break;
                case Up.еще:
                    res = y + y;
                    break;              
            }
            Console.WriteLine($"Реултат операций равен = {res}");

        }
    }
}
