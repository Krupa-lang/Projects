using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp52
{
    class Person
    {
        public string Name { get; set; }
        public Person (string name)
        {
            Name = name;
        }
        public void Display ()
        {
            Console.WriteLine($"Person {Name}");
        }
    }
    class Emp : Person
    {
        public string Company { get; set; }
        public Emp (string name, string company) : base(name)
        {
            Company = company;
        }

    }
    class Client : Person
    {
        public string Bank { get; set; }
        public Client (string name, string bank) : base(name)
        {
            Bank = bank;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Tom");
            Emp emp = person as Emp;
            if (emp== null)
            {
                Console.WriteLine("Преобраование прошло неудачно");
            }
            else
            {
                Console.WriteLine(emp.Company);
            }
            //Emp emp = new Emp ( "Tom", "cotik" );
            //Person person = emp;
            //Emp emp2 = (Emp)person;
            //object obj = new Emp("yt", "jon");
            //((Emp)obj).Display();
            //Person person2 = new Client("Bob", "goy");
            //Console.WriteLine( person.Name);
            Console.ReadKey();
        }
    }
}
