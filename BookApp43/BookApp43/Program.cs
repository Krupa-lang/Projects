using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            State state = new State();
            state.d = 5;
            state.e = 8;
            state.f = 7;
            state.A();
            state.B();
            Console.ReadLine();
        }
        
    }
    public class State
    {
        int a;
        private int b;
        protected int c;
        internal int d;
        protected internal int e;
        public int f;
        //protected private int q;

        private void F()
        {
            Console.WriteLine($"Переменная f = :{f}");         
        }
        public void A()
        {
            Console.WriteLine($"Переменная a = :{a}");
        }
        internal void B()
        {
            Console.WriteLine($"Переменная b= :{b}");
        }
        protected void E()
        {
            Console.WriteLine($"Переменная e= :{e}");
        }
    }

   
}
