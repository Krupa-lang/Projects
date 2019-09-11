using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp05._06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Dates and Times:");
            // Этот конструктор принимает год, месяц и день.
            DateTime dt = new DateTime (2011, 10, 17);
            // Какой это день месяца? 
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
            // Сейчас месяц декабрь. 
            dt = dt.AddMonths (2); Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());
            // Этот конструктор принимает часы, минуты и секунды. 
            TimeSpan ts = new TimeSpan (4, 30, 0) ; Console.WriteLine(ts);
            // Вычесть 15 минут иэ текущего TimeSpan и вывести результат. 
            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0) ) ) ;

            Console.ReadLine();


        }
    }
}
