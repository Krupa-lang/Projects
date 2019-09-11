using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zp
{
    public class FtoCRaw
    {

        public static void Main(string[] args)
        {
            bool done = false;
            while (!done)
            {
                string fahrString = Console.In.ReadLine();
                if (fahrString == null || fahrString.Length == 0)
                {
                    done = true;
                }
                else
                {
                    double fahr = Double.Parse(fahrString);

                    double celcius = 5.0 / 9.0 * (fahr - 32);
                    Console.Out.WriteLine($"F={fahr}, C={celcius}");
                }
            }
            Console.Out.WriteLine("froc exit");
        }
    }

    public class FtoCTemplateMethod : Application
    {
        private TextReader input;
        private TextWriter output;

        public static void Main(string[] args)
        {
            new FtoCTemplateMethod().Run();
        }

        protected override void Init()
        {
            input = Console.In;
            output = Console.Out;
        }

        protected override void Idle()
        {
            string fahrString = input.ReadLine();
            if (fahrString == null || fahrString.Length == 0)
            {
                SetDone();
            }
            else
            {
                double fahr = Double.Parse(fahrString);

                double celcius = 5.0 / 9.0 * (fahr - 32);
                Console.Out.WriteLine($"F={fahr}, C={celcius}");
            }
        }

        protected override void Cleanup()
        {
            output.WriteLine("ftoc exit");
        }
    }
}
