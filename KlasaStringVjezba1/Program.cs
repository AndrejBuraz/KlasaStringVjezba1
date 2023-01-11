using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaStringVjezba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string recenica = "Danas radimo s klasom String.";
            //Ispis broja znakova u rečenici
            Console.WriteLine("Broj znakova u rečenici: {0}",recenica.Length);
            //Ispis malim i velikim slovima
            Console.WriteLine("Ispis velikim slovima: {0} \nIspis malim slovima: {1}", recenica.ToUpper(), recenica.ToLower());
            //Substring metoda
            Console.WriteLine("- - - - - Substring metoda - - - - - ");
            Console.WriteLine(recenica.Substring(0, 5));
            Console.WriteLine(recenica.Substring(recenica.Length-5,5));
            //zamjena znakova u stringu
            Console.WriteLine("\n- - - - - Replace - - - - - ");
            Console.Write(recenica.Replace("Danas", "Sutra"));
            //Razdvajanje stringa u više stringova
            Console.WriteLine("\n- - - - - Razdvajanje - - - - - ");
            string[] rijeci = recenica.Split(' ');
            for(int i = 0; i < rijeci.Length; i++)
            {
                Console.Write(rijeci[i] + "\n");
            }
            //Umetanje znakova u string
            Console.WriteLine("\n- - - - - Umetanje - - - - - ");
            Console.WriteLine(recenica.IndexOf("radimo"));
            Console.WriteLine(recenica.Insert(recenica.IndexOf("radimo"), "intenzivno "));

            Console.ReadKey();

        }
    }
}
