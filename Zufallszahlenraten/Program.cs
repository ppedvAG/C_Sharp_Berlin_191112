using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zufallszahlenraten
{
    class Program
    {
        static void Main(string[] args)
        {
            //Schleife zum Wdh des Programms
            do
            {
                //Deklarationen
                Random generator;
                int zufallszahl;
                int eingabe;

                //Initialisierung eines Random-Objekts mittels Konstruktor-Aufruf (vgl. Modul 04)
                generator = new Random();
                //Aufruf der Würfel-Funktion des Random-Objekts (beachte: 1. Grenze inklusiv / 2. Grenze exklusiv)
                zufallszahl = generator.Next(1, 6);

                //Schleife für erneuten Versuch
                do
                {
                    //Abfrage des Tipps des Benutzers
                    Console.Write("Gib bitte eine ganze Zahl zwischen 1 und 5 ein: ");
                    eingabe = int.Parse(Console.ReadLine());

                    //Vergleich Tipp <> Zufallszahl mittels If
                    if (eingabe < zufallszahl)
                        Console.WriteLine("Deine Zahl ist zu klein!");
                    else if (eingabe > zufallszahl)
                        Console.WriteLine("Deine Zahl ist zu groß!");
                    else
                        Console.WriteLine("Herzlichen Glückwunsch. Deine Zahl ist richtig.");

                    //Bedingung für neuen Versuch (= falsche Zahl getippt)
                } while (eingabe != zufallszahl);

                //Bedingung für Wiederholung (Benutzer muss Taste 'Y' drücken)
                Console.WriteLine("Möchtest du noch einmal spielen? (Y/N)");
            } while (Console.ReadKey().Key == ConsoleKey.Y);
        }
    }
}
