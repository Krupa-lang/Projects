using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls.Ribbon;


namespace SimpleCSharpApp
{
    static class Program
    {


        public static void Kola(string q, string w, string e)
        {
            Console.WriteLine($"{q} 2 {w} 1 {e}  3");
            int r = 3;

        }

        public static void Main(string[] args)
        {
            
            Kola("Hello", "Big", "World");
            Kola("Big", "Dima", "Ionas");
            Console.WriteLine("nnn");


            Console.ReadLine();
        }


      
    }
}
