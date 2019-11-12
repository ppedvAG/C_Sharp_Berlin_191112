using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            int Alter;

            Alter = 31;

            string stadt = "Berlin";

            Console.WriteLine(Alter);
            Console.WriteLine(stadt);

            //traditionell
            string Satz = "Ich bin " + Alter + " Jahre alt und wohne in " + stadt + ".";
            Console.WriteLine("Ich bin " + Alter + " Jahre alt und wohne in " + stadt + ".");
            //Index
            Console.WriteLine("Ich bin {0} Jahre alt und wohne in {1}.", Alter, stadt);
            //$-Operator
            Satz = $"Ich bin {Alter} Jahre alt und wohne in {stadt}.";
            Console.WriteLine($"Ich bin {Alter} Jahre alt und wohne in {stadt}.");

            int a = 15;
            int b = 23;
            Console.WriteLine($"{a} + {b} = {a + b}");

            Console.WriteLine($"Dies ist ein Tabuator \t und dies ein \n Zeilenumbruch");
            Console.WriteLine($"C:\\Programme\\Anwendung.exe");

            Console.WriteLine(@"Dies ist ein Tabulator   und dies ein
Zeilenumbruch");
            Console.WriteLine($@"C:\Programme\Anwendung.exe");


            Console.WriteLine("Bitte gib deinen Namen ein:");
            string name = Console.ReadLine();
            Console.WriteLine($"Du heißt also {name}.");

            Console.WriteLine("Bitte gib eine Zahl ein:");
            string zahlAlsString = Console.ReadLine();
            int umgewandelteZahl = int.Parse(zahlAlsString);
            int doppelteZahl = umgewandelteZahl * 2;

            double erg = 5.7 / 0;
            Console.WriteLine(erg);

            Console.ReadKey();
        }
    }
}
