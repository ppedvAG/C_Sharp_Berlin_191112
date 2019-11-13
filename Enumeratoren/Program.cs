using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeratoren
{
    enum Wochentag { Montag = 1, Dienstag, Mittwoch, Donnerstag, Freitag, Samstag, Sonntag}
    class Program
    {
        static void Main(string[] args)
        {
            Wochentag heute = Wochentag.Mittwoch;
            Console.WriteLine($"Heute ist {heute}.");

            Console.WriteLine("Welcher Wochentag ist heute?");
            for (int i = 1; i < 8; i++)
            {
                Console.WriteLine($"{i}: {(Wochentag)i}");
            }

            heute = (Wochentag)int.Parse(Console.ReadLine());
            Console.WriteLine($"Heute ist also {heute}.");

            switch (heute)
            {
                case Wochentag.Montag:
                    Console.WriteLine("Schöne Woche");
                    break;
                case Wochentag.Dienstag:
                case Wochentag.Mittwoch:
                case Wochentag.Donnerstag:
                    Console.WriteLine("Nicht überarbeiten!");
                    break;
                case Wochentag.Freitag:
                    Console.WriteLine("Bald ist Wochenende");
                    break;
                default:
                    Console.WriteLine("Endlich Wochenende");
                    break;
            }

            int a = 11;
            switch (a)
            {
                case 5:
                    Console.WriteLine("Irgendwas");
                    break;
                case int b when b > 10:
                    Console.WriteLine("a ist größer 10");
                    break;
                default:
                    break;
            }


            Console.ReadKey();
        }
    }
}
