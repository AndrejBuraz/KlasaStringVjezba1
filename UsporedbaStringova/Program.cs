using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsporedbaStringova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst1 = "Ovo je neki tekst.";
            string tekst2 = "Ovo je NEKI tekst.";
            string tekst3 = "ovo je neki tekst.";
            string tekst4 = "Ovo je neki tekst.";
            if((string.Compare(tekst1, tekst4) == 0))
            {
                Console.WriteLine("Stringovi 1 i 4 su isti.");
            }
            else
            {
                Console.WriteLine("Stringovi 1 i 4 su različiti");
            }
            if ((string.Compare(tekst1, tekst2) == 0))
            {
                Console.WriteLine("Stringovi 1 i 2 su isti.");
            }
            else
            {
                Console.WriteLine("Stringovi 1 i 2 su različiti");
            }
            if ((string.Compare(tekst1, tekst3) == 0))
            {
                Console.WriteLine("Stringovi 1 i 3 su isti.");
            }
            else
            {
                Console.WriteLine("Stringovi 1 i 3 su različiti");
            }
            Console.ReadKey();

        }
    }
}
