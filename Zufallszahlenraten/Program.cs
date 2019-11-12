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
            Random generator = new Random();
            int zufallszahl = generator.Next(1, 6);
            int eingabe;

            do
            {
                Console.Write("Gib bitte eine ganze Zahl zwischen 1 und 5 ein: ");
                eingabe = int.Parse(Console.ReadLine());

                if (eingabe < zufallszahl)
                    Console.WriteLine("Deine Zahl ist zu klein!");
                else if (eingabe > zufallszahl)
                    Console.WriteLine("Deine Zahl ist zu groß!");
                else
                    Console.WriteLine("Herzlichen Glückwunsch. Deine Zahl ist richtig.");

            } while (eingabe != zufallszahl);

            Console.ReadKey();
        }
    }
}
