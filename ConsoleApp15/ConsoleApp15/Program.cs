using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            //string you = "My textyal Data";
            //if (you.Length > 0) 
            //Console.WriteLine("string is greater 0 characters ");

            //ShowCurrentSpeedAndLimitSpeed();
            //IfElseIfElse();

            //ShortToInt();
            Console.ReadLine();

        }

        //static void ShortToInt()
        //{
        //    short a = 30000;
        //    short b = 30000;

        //    short result = (short)(a + b);

        //    Console.WriteLine(result);
        }

        static void DimaTanya()
        {
            StringBuilder dima = new StringBuilder("dima");
            dima.Append("aaaa");
            dima.Append("bbbbb");

            

            string a = dima.ToString();        
        }


        // Если скорость автомобиля > 60 км, то сбросить до 40.
        // Если скорость автомобиля > 80 км, то сбросить до 60.
        // Иначе увеличить скорость на 10. 
        // После всех операций вывести итоговую скорость
        static void IfElseIfElse()
        {
            // текущая скорость
            int currentSpeed = 70;

            // Ограничитель скорост
            int limitSpeed = 80;

            // сбросить до
            int resetSpeed = 60;

            if (currentSpeed > 60)
            {
                int a = 10;

                if (true)
                {
                    currentSpeed = 0;
                }


                currentSpeed = 40;
            }
          
        }

        // Если скорость автомобиля > 80 км, то сбросить до 60.
        // Иначе увеличить скорость на 10. 
        // После всех операций вывести итоговую скорость
        static void LimitOrAddSpeed()
        {
            // текущая скорость
            int currentSpeed = 50;

            // Ограничитель скорост
            int limitSpeed = 80;

            // сбросить до
            int resetSpeed = 60;


            if (currentSpeed > limitSpeed)
            {
                currentSpeed = resetSpeed;
            }
            else
            {
                currentSpeed += 10;
            }

            Console.WriteLine(currentSpeed);

        }

        // Если скорость автомобиля > 80 км, то сбросить до 60.
        // Если скорость до сброса > 100, то вывести на консоль данную скорость и только после ограничить. 
        // После ограничения вывести итоговую скорость
        static void ShowCurrentSpeedAndLimitSpeed()
        {
            // текущая скорость
            int currentSpeed = 90;

            // Ограничитель скорост
            int limitSpeed = 80;

            // сбросить до
            int resetSpeed = 60;

            if (currentSpeed > 80)
            {
                if (currentSpeed > 100)
                {
                    Console.WriteLine(currentSpeed);
                }
                currentSpeed = 60;

            }

            Console.WriteLine(currentSpeed);


        }

        // Отобразить скорость автомобиля на консоль. Если скорость автомобиля > 80 км, то сбросить до 60. 
        static void LimitSpeed()
        {

            // текущая скорость
            int currentSpeed = 10;

            // Ограничитель скорост
            int limitSpeed = 80;

            if (currentSpeed > 80)
            {
                currentSpeed = 60;

            }

            Console.WriteLine(currentSpeed);
        }
    }
}
