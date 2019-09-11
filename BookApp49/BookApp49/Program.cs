using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp49
{
    class Root
    {
        string name;
        string phone;
        string data;
        public string  this[ string hooc ]
        {
            get
            {
                switch (hooc)
                {
                    case "name": return "lololo  " + name;
                    case "phone": return phone;
                    case "data": return data;

                    default:return null;
                }
            }
            set
            {
                switch (hooc)
                {
                    case "name": name = value;
                        break;
                    case "phone": phone = value;
                        break;
                    case "data": data = value;
                        break;
                    
                }
            }
                
        }
            
    }
    class Program
    {
        static void Main(string[] args)
        {
            Root root = new Root();
            root["name"] = "jon";
            root["data"] = "13.08.2019";
            //Console.WriteLine(root["name"]);           почему 2 раза, а не в 1 строку?
            //Console.WriteLine(root["data"]);
            Console.ReadLine();
        }
    }
}
