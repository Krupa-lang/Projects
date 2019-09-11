using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToCaseString("ПривЕтики", CaseType.ToUpper));
            Console.ReadKey();
        }



















        // Преобразовать строку в необходимый регистр
        static string ToCaseString(string str, CaseType registr)
        {
            switch (registr)
            {
                case CaseType.ToUpper:
                    str = str.ToUpper();
                    break;
                case CaseType.ToLower:
                    str = str.ToLower();
                    break;
                default:
                    str = "void";
                    break;
            }
            return str;
        }
    }
}
