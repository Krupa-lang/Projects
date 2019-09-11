using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp50
{
    class Persone
    {
        private string _name;
        public string Name { get; set; }
        public Persone (string name)
        {
            Name = name;
        }
        public void Disp ()
        {
            Console.WriteLine(Name);
        }
    }

    class Root : Persone
    {
        public string Company { get; set; }
        public Root (string name, string company)
            : base(name)
        {
            Company = company;
            Name = name;
        }
        
    }


    class Program
    {
        static void Main(string[] args)
        {
            Persone persone = new Persone("Olli");
            persone.Disp();
            Root root = new Root("Koler", "34");
        
            root.Disp();
            Console.ReadKey();

        }
    }
}
