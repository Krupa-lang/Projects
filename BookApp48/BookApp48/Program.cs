using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp48
{
    class Person
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People();
            people[1] = new Person { Name = "Tom" };
            people[2] = new Person { Name = "Nicci" };
            Person person = people[2];
            Console.WriteLine(person?.Name);
            Console.ReadKey();
        }
    }
    class People
    {
        Person[] data;
        public People()
        {
            data = new Person[5];
        }
        public Person this [ int indecs]
        {
            get
            {
                return data[indecs];
            }
            set
            {
                data[indecs] = value;
            }
        }
    }
}

