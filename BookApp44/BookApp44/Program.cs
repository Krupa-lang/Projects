using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp44
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Age = 5;
            int personName = p.Age;
            Console.ReadLine();
        }
    }
    class Person
    {
        private int age;
        public int Age
        {
            set
            {
                if (value<18)
                {
                    Console.Write("число должно быть больше 17 :");
                    Convert.ToString(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine(age = value);
                }
            }

            get
            {
                return age;
            }
           
        }
    }

}
