using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_с_массивами
{
    class Program
    {
        static void Main(string[] args)
        {
            Chiclo();
            Console.ReadLine();



            //string st = "a#cdif;h";
            //st = st.Remove(st.IndexOf('#'), st.IndexOf(';')/* -*/ /*st.IndexOf('#')*/);
            //Console.WriteLine(st);
            //Console.ReadLine();
        }

        static void Chiclo()
        {
            try
            {
                Console.Write("Введите колличество строк: ");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a < 10 & a > 0)
                {
                    string[] e = new string[a];

                    for (var i = 0; i < e.Length; i++)
                    {     
                        Console.Write($"Введите строку {i+1}:");
                        e[i] = Convert.ToString(Console.ReadLine());
                    }
                    string st = "";
                    string r = "";
                    

                    for (int i = 0; i < e.Length; i++)
   
                    {
                        st = $"{e[i]},";
                        r = r+ st;
                 
                    }
                    
                   

                    Console.Write(r.TrimEnd(new Char[] { ',' })+".");
                    
                }
                else
                {
                    Console.WriteLine("Вы ввели число, которое не входит в диапазон!");
                    Console.Read();
                }
            }
            catch
            {
                Console.WriteLine("Вы ввели неверный формат");
            }
            

            
            
        }

       
    }
}
