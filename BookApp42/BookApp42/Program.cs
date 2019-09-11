using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace BookApp42
{
    struct User
    {
        public int age;
        public string name;
         
         public User (string name, int age)
        {
            this.age = age;
            this.name = name;
        }
        public void Disp()
        {
            Console.WriteLine($"Name :{name}  Age: {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User tom = new User("Tom", 34);
            tom.Disp();
            User bob = new User();
            bob.Disp();
            Console.Read();
        }
    }
}
