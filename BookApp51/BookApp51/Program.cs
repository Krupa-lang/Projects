using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp51
{
    class Persone
    {
        int age;
        string name;
        public Persone (string name)
        {
            this.name = name;
            Console.WriteLine("Persone(string name)");
        }
        public Persone(string name, int age) : this(name)
        {
            this.age = age;
            Console.WriteLine("Persone(string name, int age)");
        }
    }

    class Emp : Persone
    {
        string company;
        public Emp(string name, int age, string company) : base (name, age)
        {
            this.company = company;
            Console.WriteLine("Emp(string name, int age, string company )");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp("Bill", 45, "B.B.C.");
            Console.ReadLine();
        }
    }
}
