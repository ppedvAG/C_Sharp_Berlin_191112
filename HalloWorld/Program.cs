//Mittels der USING-Anweisungen kann ein vereinfachter Zugriff auf Programm-Externe Klassen ermöglicht werden. Es muss nun nicht mehr der
///vollständige Pfad angegeben werden, sondern es reicht der Klassenbezeichner
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//NAMESPACE: Die Umgebung unseres aktuellen Programms: Alles innerhalb des Namespaces gehört zu dem Programm
namespace HalloWorld
{
    //Die PROGRAM-Klasse beinhaltet den Einstiegspunkt des Programms und muss in jedem C#-Programm vorhanden sein
    class Program
    {
        //Die MAIN()-Methode ist der Einstiegspunkt jedes C#-Programms: Hier beginnt das Programm IMMER
        static void Main(string[] args)
        {
            //Ausgabe eines String-Literals
            Console.WriteLine("Hello World");

            //Deklaration einer Integer-Variable 
            int Alter;
            //Initialisierung der Integer-Variablen
            Alter = 31;
            //Gleichzeitige Deklaration und Initialisierung einer String-Variablen
            string stadt = "Berlin";
            //Ausgabe der Variablen
            Console.WriteLine(Alter);
            Console.WriteLine(stadt);

            ///Einfügen dynamischer Inhalte in Strings
            //'traditionell' über Stringverknüpfung (+-Operator)
            string Satz = "Ich bin " + Alter + " Jahre alt und wohne in " + stadt + ".";
            Console.WriteLine("Ich bin " + Alter + " Jahre alt und wohne in " + stadt + ".");
            //Index (Variablen werden durch Index-Platzhalter vertreten und später definiert)
            Console.WriteLine("Ich bin {0} Jahre alt und wohne in {1}.", Alter, stadt);
            //$-Operator (Variablen werde direkt in {}-Klammern geschrieben 
            Satz = $"Ich bin {Alter} Jahre alt und wohne in {stadt}.";
            Console.WriteLine($"Ich bin {Alter} Jahre alt und wohne in {stadt}.");

            //Ausgabe einer Berchnung in Strings
            int a = 15;
            int b = 23;
            Console.WriteLine($"{a} + {b} = {a + b}");

            //String-Formatierung mittels Escape-Sequenzen
            Console.WriteLine($"Dies ist ein Tabulator \t und dies ein \n Zeilenumbruch");
            //Bsp für Pfadausgabe mittels Escape-Sequenzen
            Console.WriteLine($"C:\\Programme\\Anwendung.exe");

            //String-Formatierung mittels VerbaTim-String (Einleitung mittels @ / Escape-Sequenzen sind nicht möglich, 
            ///dynamische Inhalte mittels $ schon)
            Console.WriteLine(@"Dies ist ein Tabulator   und dies ein
Zeilenumbruch");
            //Bsp für Pfadausgabe in Verbatim-String
            Console.WriteLine($@"C:\Programme\Anwendung.exe");


            //Eingabe eines Strings durch den Benutzer und Abspeichern in einer String-Variablen
            Console.WriteLine("Bitte gib deinen Namen ein:");
            string name = Console.ReadLine();
            //Ausgabe
            Console.WriteLine($"Du heißt also {name}.");

            //Eingabe eines Strings, Umwandlung in einen Integer (Parse()-Funktion) und Abspeichern in einer Integer-Variablen
            Console.WriteLine("Bitte gib eine Zahl ein:");
            string zahlAlsString = Console.ReadLine();
            int umgewandelteZahl = int.Parse(zahlAlsString);
            int doppelteZahl = umgewandelteZahl * 2;
            //Ausgabe
            Console.WriteLine($"Das Doppelte deiner Eingabe ist {doppelteZahl}.");

            //Bsp für Teilung durch 0 von Gleitkommazahlen
            double erg = 5.7 / 0;
            Console.WriteLine(erg);

            //Programmpause (nur für Debug-Mode benötigt)
            Console.ReadKey();
        }
    }
}
