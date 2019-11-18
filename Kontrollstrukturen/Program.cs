using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrollstrukturen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaration und Initialisierung von Beispiel-Variablen
            int a = 25;
            int b = 30;

            //IF-ELSEIF-ELSE-Block
            ///Das Programm wird den ersten Block ausführen, bei welchem er auf eine wahre Bedingung trifft und dann am Ende des Blocks mit
            ///dem Code weiter machen
            if (a < b)
            {
                Console.WriteLine("A ist kleiner als B");
            }
            else if (a > b)
            {
                //Es kann beliebig viele ELSE-IF-Blöcke geben
                Console.WriteLine("A ist größer B");
            }
            else
            {
                //Wenn keine der Bedingungen wahr ist, wird der (optionale) ELSE-Block ausgeführt
                Console.WriteLine("A und B sind gleich");
            }

            //Kurznotation:
            //(Bedingung) ? TrueAusgabe : FalseAusgabe
            string ergebnis = (a == b) ? "A ist gleich B" : "A ist ungleich B";

            //WHILE-Schleife
            ///Die WHILE-Schleife wird wiederholt, solange die Bedingung wahr ist. Ist die Bedingung von vornherein unwahr, dann wird die Schleife
            ///übersprungen
            while (a < b)
            {
                Console.WriteLine($"{a} ist kleiner als {b}");
                a++;

                //Mit der BREAK-Anweisung wird die Schleife verlassen und der Code wird fortgesetzt.
                if (a == 29) break;
            }

            //DO-WHILE-Schleife
            ///Auch die DO-WHILE-Schleife wird wiederholt, solange die Bedingung wahr ist. Allerdings wird die Bedingung erst am Schleifen_
            ///ende geprüft, weshalb die Schleife mindestens einmal durchläuft.
            do
            {
                Console.WriteLine($"{a} ist kleiner als 100");
                a *= 2;

                //Der CONTINUE-Befehl beendet den aktuellen Schleifendurchlauf und lässt erneut die Bedingung prüfen. Ist die Bedingung wahr
                ///beginnt ein neuer Durchlauf
                continue;

                Console.WriteLine("Wird niemals ausgeführt");

            } while (a < 100);


            //FOR-Schleife
            ///Der FOR-Schleife wird ein Laufindex (i) sowie eine Bedingung und eine Anweisung übergeben. Am Ende jedes Durchlaufes wird die
            ///Anweisung ausgeführt. Wenn die Bedingung nicht (mehr) wahr ist, wird kein (weiterer) Schleifendurchlauf begonnen.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"i ist gerade {i}.");
            }
            //Bsp einer For-Schleife von 1-1000 mit einer Verdoppelung des Index nach jedem Durchlauf
            for (int i = 1; i <= 1000; i *= 2)
            {
                Console.WriteLine(i);
            }
            //Bsp für eine rückwärtslaufende Schleife von 10-1
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            //ARRAYS
            ///Arrays sind Collections, welche mehrere Variablen eines Datentyps speichern können. Die Größe des Arrays muss bei der
            ///Initialisierung entweder durch eine Zahl oder durch eine bestimmte Anzahl von spezifischen Elementen definiert werden.
            int[] zahlenarray = { 2, 4, 56, 78, 96, 12, 12 };

            //Der Zurgiff auf einzelne Array-Positionen erfolgt durch einen Nullbasierten Index
            Console.WriteLine(zahlenarray[4]);
            zahlenarray[4] = 123;
            Console.WriteLine(zahlenarray[4]);

            //Iteration über ein Array mittels For-Schleife
            for (int i = 0; i < zahlenarray.Length; i++)
            {
                Console.WriteLine(zahlenarray[i]);
            }

            //FOREACH-Schleifen können über Collections laufen und sprechen dabei jedes Element genau einmal an
            foreach (var item in zahlenarray)
            {
                Console.WriteLine(item);
            }

            //Mehrdimensionales Array
            int[,] zweiDimArray = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    zweiDimArray[i, j] = i * j;
                }
            }

            Console.WriteLine(zweiDimArray[5, 8]);

            //String als Char-Array
            string beispiel = "Hallo";
            Console.WriteLine(beispiel[2]);

            //Verwendung der Contains-Funktion eines Arrays (überprüft auf das Vorhandensein eines Elements)
            Console.WriteLine(beispiel.Contains('a'));

            Console.ReadKey();
        }
    }
}
