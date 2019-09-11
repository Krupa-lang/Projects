using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp47
{
    class User
    {
        public Phon Phon { get; set; }
    }
    class Phon
    {
        public Comon Comon { get; set; }
    }
    class Comon
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            if (u!=null)
            {
                if (u.Phon!=null)
                {
                    if (u.Phon.Comon!=null)
                    {
                        string t = u.Phon.Comon.Name;
                        Console.WriteLine(t);
                    }
                }
            }
            
            Console.ReadLine();
        }
    }
}
