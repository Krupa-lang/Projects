using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookApp41
{
    class Person
    {
        public string name; 
        public int age;
        public Person(): this("Неизвестно")
        {

        }
        public Person(string name):this(name, 18)
        {

        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person();
            Person bob = new Person("Bob");
            Person jul = new Person("Jullia", 25);
            tom.GetInfo();
            tom.name = "Jon";
            tom.age = 23;
            tom.GetInfo();
            bob.GetInfo();
            jul.GetInfo();

            Console.ReadKey();
        }
    }


}

