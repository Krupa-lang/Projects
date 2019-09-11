using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            Account.MinSum = 560;
            decimal result = Account.GetS(1000, 5, 10);
            Console.ReadLine();
        }
    }
    class Account
    {
        
        public Account (decimal sum, decimal rate)
        {
            if (sum<MinSum)
            {
                throw new Exception("Недопустимая сумма");
                sum = Sum;
                rate = Rate;

            }

        }
        private static decimal minSum = 100;
        public static decimal MinSum
        {
            get { return minSum; }
            set
            {
                if (value>0)
                {
                     minSum = value;
                }
            } }
        public decimal Sum { get; private set; }
        public decimal Rate { get; private set; }
        public static decimal GetS (decimal sum, decimal rate, int period)
        {
            decimal result = sum;
            for (int i = 0; i <= period; i++)
            {
                result = result + result * rate / 100;
            }
                return result;
            
        }
        
    }
       
}
