using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaProvjeraZnanjaZadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi jednu rijec: ");
            string text = Console.ReadLine();

            for (int i = 1; i <= text.Length; i++)
            {
                for(int j = text.Length-i; j >0; j--)
                {
                    Console.Write(" ");
                }
                Console.Write(text.Substring( text.Length -i));
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
