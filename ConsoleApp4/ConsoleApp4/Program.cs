// Простое приложение С#.
using System;
using System.Windows.Forms;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Testing! 1, 2, 3");

            HelloMessage n = new HelloMessage();
            n.Hany("Helllo Hany");


        }           
        
    }
    class  HelloMessage
    {
       internal void Hany (string s)
        {
            MessageBox.Show(caption: s,text: "Milo", buttons: MessageBoxButtons.OKCancel);
            
        }

    }
}


