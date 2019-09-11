using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleStrategy
{
    public class FtoCStrategy : Application
    {
        private TextReader input;
        private TextWriter output;

        private bool _isDone = false;

        public static void Main(string[] args)
        {
            (new ApplicationRunner(new FtoCStrategy())).Run();
        }

        public void Init()
        {
            input = Console.In;
            output = Console.Out;
        }

        public void Idle()
        {
            string fahrString = input.ReadLine();
            if (fahrString == null || fahrString.Length == 0)
            {
                _isDone = true;
            }
            else
            {
                double fahr = Double.Parse(fahrString);
                double celcius = 5.0 / 9.0 * (fahr - 32);
                output.WriteLine($"F={fahr}, C={celcius}");
            }
        }

        public void Cleanup()
        {
            output.WriteLine("froc exit");
        }

        public bool Done()
        {
            return _isDone;
        }
    }
}
