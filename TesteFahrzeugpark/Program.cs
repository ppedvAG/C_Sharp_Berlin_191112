using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fahrzeugpark;

namespace TesteFahrzeugpark
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Modul04: OOP
            //Fahrzeug fz1 = new Fahrzeug("BMW", 200);
            //Fahrzeug fz2 = new Fahrzeug("Audi", 180);

            //Console.WriteLine(fz1.Name);

            //fz1.Name = "Opel";
            //Console.WriteLine(fz1.Name);
            //Console.WriteLine(fz2.Name);

            //Console.WriteLine(fz2.BeschreibeMich());
            //Console.WriteLine(fz1.BeschreibeMich());

            //fz2 = new Fahrzeug("VW", 250);

            //GC.Collect(); 
            #endregion

            #region Lab04 Fahrzeug_Klasse

            //Deklaration einer Fahrzeug-Variablen und Initialisierung mittels einer Fahrzeug-Instanz
            Fahrzeug fz1 = new Fahrzeug("Mercedes", 190, 23000);
            //Ausführen der BeschreibeMich()-Methode des Fahrzeugs und Ausgabe in der Konsole
            Console.WriteLine(fz1.BeschreibeMich());

            //Diverse Methodenausführungen
            fz1.StarteMotor();
            fz1.Beschleunige(120);
            Console.WriteLine(fz1.BeschreibeMich());

            fz1.Beschleunige(300);
            Console.WriteLine(fz1.BeschreibeMich());

            fz1.StoppeMotor();
            Console.WriteLine(fz1.BeschreibeMich());

            #endregion

            Console.ReadKey();
        }
    }
}
