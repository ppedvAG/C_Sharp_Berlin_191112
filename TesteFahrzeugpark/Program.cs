using System;
using System.Collections;
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
            //Ändern des durch Console verwendeten Zeichensatzes auf Unicode (damit das €-Zeichen angezeigt werden kann)
            Console.OutputEncoding = Encoding.UTF8;

            #region Modul04: OOP
            ////Instanzierung der Fahrzeuge
            //Fahrzeug fz1 = new Fahrzeug("BMW", 200);
            //Fahrzeug fz2 = new Fahrzeug("Audi", 180);

            ////Ausgabe von fz1
            //Console.WriteLine(fz1.Name + ": " + fz1.MaxGeschwindigkeit + "km/h");

            ////Veränderung des Namens von fz1
            //fz1.Name = "Opel";
            ////Ausgabe der Fahrzeugeigenschaften (fz1 wurde verändert, fz2 nicht)
            //Console.WriteLine(fz1.Name + ": " + fz1.MaxGeschwindigkeit + "km/h");
            //Console.WriteLine(fz2.Name + ": " + fz2.MaxGeschwindigkeit + "km/h");
            ////Ausgabe der BeschreibeMich-Methode von fz1
            //Console.WriteLine(fz1.BeschreibeMich());


            ////Neuzuweisung der fz2-Variable auf Objekt in fz1 (beide Variablen zeigen auf dasselbe Objekt)
            //fz2 = fz1;

            ////manueller Aufruf der GarbageCollection
            //GC.Collect(); 
            #endregion

            #region Lab04: Fahrzeug_Klasse

            ////Deklaration einer Fahrzeug-Variablen und Initialisierung mittels einer Fahrzeug-Instanz
            //Fahrzeug fz1 = new Fahrzeug("Mercedes", 190, 23000);
            ////Ausführen der BeschreibeMich()-Methode des Fahrzeugs und Ausgabe in der Konsole
            //Console.WriteLine(fz1.BeschreibeMich());

            ////Diverse Methodenausführungen
            //fz1.StarteMotor();
            //fz1.Beschleunige(120);
            //Console.WriteLine(fz1.BeschreibeMich());

            //fz1.Beschleunige(300);
            //Console.WriteLine(fz1.BeschreibeMich());

            //fz1.StoppeMotor();
            //Console.WriteLine(fz1.BeschreibeMich());

            #endregion

            #region Modul05: Vererbung
            //PKW pkw1 = new PKW("BMW", 230, 26000, 3);
            //pkw1 = new PKW("BMW", 230, 26000, 3);
            //pkw1 = new PKW("BMW", 230, 26000, 3);
            //pkw1 = new PKW("BMW", 230, 26000, 3);
            //pkw1 = new PKW("BMW", 230, 26000, 3);
            //pkw1 = new PKW("BMW", 230, 26000, 3);

            //Console.WriteLine(pkw1.BeschreibeMich());

            //pkw1.Hupe();

            //Console.WriteLine("Es wurden " + Fahrzeug.AnzahlErstellterFahrzeuge + " Fahrzeuge gebaut."); 
            #endregion

            #region Lab05: PKW-, Schiff- und Flugzeug-Klasse

            //PKW pkw1 = new PKW("BMW", 250, 23000, 5);
            //Console.WriteLine(pkw1.BeschreibeMich());
            //pkw1.Hupe();

            //Schiff schiff1 = new Schiff("Titanic", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf);
            //Console.WriteLine(schiff1.BeschreibeMich());
            //schiff1.Hupe();

            //Flugzeug flugzeug1 = new Flugzeug("Boing", 750, 3000000, 9990);
            //Console.WriteLine(flugzeug1.BeschreibeMich());
            //flugzeug1.Hupe();

            //Console.WriteLine(Fahrzeug.ZeigeAnzahlFahrzeuge());

            #endregion

            #region Modul06: Interfaces und Polymorphismus
            //PKW pkw1 = new PKW("BMW", 230, 27000, 5);

            //Fahrzeug fz1 = pkw1;

            //IBewegbar bewegbaresObjekt = pkw1;

            //MontiereNeuesRad(pkw1);

            //Flugzeug flugzeug1 = new Flugzeug("Boing", 750, 3000000, 9990);

            //MontiereNeuesRad(flugzeug1);

            //if (fz1 is PKW)
            //    pkw1 = (PKW)fz1; 
            #endregion

            #region Lab06: IBeladbar

            //PKW pkw1 = new PKW("BMW", 250, 23000, 5);
            //Flugzeug flugzeug1 = new Flugzeug("Boing", 750, 3000000, 9990);
            //Schiff schiff1 = new Schiff("Titanic", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf);

            //BeladeFahrzeuge(pkw1, flugzeug1);
            //BeladeFahrzeuge(flugzeug1, schiff1);
            //BeladeFahrzeuge(schiff1, pkw1);

            //Console.WriteLine("\n" + schiff1.BeschreibeMich());

            #endregion

            #region Modul07: Generische Listen
            ////Deklaration und Initialisierung einer Liste von Strings
            //List<string> Staedteliste = new List<string>();

            ////Ausgabe der Länge der Liste
            //Console.WriteLine(Staedteliste.Count);

            ////Hinzufügen von Listeneinträgen
            //Staedteliste.Add("Berlin");
            //Staedteliste.Add("Hamburg");
            //Staedteliste.Add("München");
            //Staedteliste.Add("Köln");

            //Console.WriteLine(Staedteliste.Count);

            ////Ausgabe der 3. Listenposition
            //Console.WriteLine(Staedteliste[2]);

            ////Manipulation der 3. Listenposition
            //Staedteliste[2] = "Dresden";
            //Console.WriteLine(Staedteliste[2]);

            ////Schleife über die Liste
            //foreach (var item in Staedteliste)
            //{
            //    Console.WriteLine(item);
            //}

            ////Löschen des Eintrags 'Köln' (Nachfolgende Einträge rücken nach oben)
            //Staedteliste.Remove("Köln");


            ////Deklaration und Initialisierung eines Dictionarys (Key: Int, Value: String)
            //Dictionary<int, string> Dictionary1 = new Dictionary<int, string>();

            ////Hinzufügen von Dictionary-Einträgen
            //Dictionary1.Add(2, "Hallo");
            //Dictionary1.Add(4, "Ciao");
            //Dictionary1.Add(8, "Moin");

            ////Ausgabe des Eintrags mit Key '4'
            //Console.WriteLine(Dictionary1[4]);

            ////Schleife über Dictionary
            //foreach (var item in Dictionary1)
            //{
            //    Console.WriteLine(item.Key + ": " + item.Value);
            //}

            ////Deklaration und Initialisierung eines Hastables + Erstellung und Abruf von Einträgen (nicht-genereisches Dictionary nach dem Hash-Speicherprinzip)
            //Hashtable ht = new Hashtable();
            //ht.Add("Hallo", 450);
            //ht.Add(78.5, new PKW("VW", 260, 250020, 4));
            //Console.WriteLine(ht["Hallo"]);

            ////Deklaration und Initialisierung eines HashSets (generische Liste nach dem Hash-Speicherprinzip)
            //HashSet<int> hs = new HashSet<int>();
            //hs.Add(23); 
            #endregion

            #region Lab07 ZufälligeFahrzeuglisten

            ////Deklaration der benötigten Variablen und und Initialisierung mit Instanzen der benötigten Objekte
            //Random generator = new Random();
            //Queue<Fahrzeug> fzQueue = new Queue<Fahrzeug>();
            //Stack<Fahrzeug> fzStack = new Stack<Fahrzeug>();
            //Dictionary<Fahrzeug, Fahrzeug> fzDict = new Dictionary<Fahrzeug, Fahrzeug>();
            ////Deklaration und Initialisierung einer Variablen zur Bestimmung der Anzahl der Durchläufe 
            //int AnzahlFZs = 10000;

            ////Schleife zur zufälligen Befüllung von Queue und Stack
            //for (int i = 0; i < AnzahlFZs; i++)
            //{
            //    //Würfeln einer zufälligen Zahl im Switch
            //    switch (generator.Next(1, 4))
            //    {
            //        //Erzeugung von Objekten je nach zufälliger Zahl
            //        case 1:
            //            fzQueue.Enqueue(new Flugzeug($"Boing_Q{i}", 800, 3600000, 9999));
            //            fzStack.Push(new Flugzeug($"Boing_S{i}", 800, 3600000, 9999));
            //            break;
            //        case 2:
            //            fzQueue.Enqueue(new Schiff($"Titanic_Q{i}", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf));
            //            fzStack.Push(new Schiff($"Titanic_S{i}", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf));
            //            break;
            //        case 3:
            //            fzQueue.Enqueue(PKW.ErzeugeZufälligenPKW($"_Q{i}"));
            //            fzStack.Push(PKW.ErzeugeZufälligenPKW($"_S{i}"));
            //            break;
            //    }
            //}

            ////Schleife zur Prüfung auf das Interface und Befüllung des Dictionaries
            //for (int i = 0; i < AnzahlFZs; i++)
            //{
            //    //Prüfung, ob das Interface vorhanden ist (mittels Peek(), da die Objekte noch benötigt werden)...
            //    if (fzQueue.Peek() is IBeladbar)
            //    {
            //        //...wenn ja, dann Cast in das Interface und Ausführung der Belade()-Methode (mittels Peek())...
            //        ((IBeladbar)fzQueue.Peek()).Belade(fzStack.Peek());
            //        //...sowie Hinzufügen zum Dictionary (mittels Pop()/Dequeue(), um beim nächsten Durchlauf andere Objekte an den Spitzen zu haben)
            //        fzDict.Add(fzQueue.Dequeue(), fzStack.Pop());
            //    }
            //    else
            //    {
            //        //... wenn nein, dann Löschung der obersten Objekte (mittels Pop()/Dequeue())
            //        fzQueue.Dequeue();
            //        fzStack.Pop();
            //    }
            //}

            ////Programmpause
            //Console.ReadKey();
            //Console.WriteLine("\n----------LADELISTE----------");

            ////Schleife zur Ausgabe des Dictionaries
            //foreach (var item in fzDict)
            //{
            //    Console.WriteLine($"'{item.Key.Name}' hat '{item.Value.Name}' geladen.");
            //}

            #endregion

            //Erstellung von Bsp-Objekten
            PKW pkw1 = PKW.ErzeugeZufälligenPKW("");
            PKW pkw2 = PKW.ErzeugeZufälligenPKW("");

            //Ausgabe der ToString-Funktion des PKWs (wird in Fahrzeugklasse überschrieben)
            Console.WriteLine(pkw1);

            //Bsp für die Verwendung der in der Fahrzeug-Klasse definierten Operatoren
            Console.WriteLine(pkw1 == pkw2);
            Console.WriteLine(pkw1 == pkw1);

            Flugzeug flug1 = new Flugzeug($"Boing", 800, 3600000, 9999);

            //Bsp für die Verwendung von IEnumerable
            foreach (var item in flug1)
            {
                Console.WriteLine(item);
            }

            //Bsp für die Verwendung der Indexer-Property
            Console.WriteLine(flug1[2]);

            Random gene = new Random();
            //Bsp für die Verwendung einer Erweiterungsmethode (s.u.)
            gene.NextInclusive(1, 10);
            
            #region TaskBsp
            //Task t1 = Task.Factory.StartNew(() =>
            //{
            //    for (int i = 0; i < 1000; i++)
            //    {
            //        Console.WriteLine("Task1: " + i);
            //    }
            //    Console.WriteLine("Task1 beendet");
            //});

            //for (int i = 0; i < 1000; i++)
            //{
            //    Console.WriteLine("Task2: " + i);
            //}
            //Console.WriteLine("Task2 beendet");
            #endregion


            Console.ReadKey();
        }

        //Methode Lab06
        public static void BeladeFahrzeuge(Fahrzeug fz1, Fahrzeug fz2)
        {
            if (fz1 is IBeladbar)
            {
                ((IBeladbar)fz1).Belade(fz2);
            }
            else if (fz2 is IBeladbar)
            {
                (fz2 as IBeladbar).Belade(fz1);
            }
            else
                Console.WriteLine("Keines der Fahrzeuge kann ein Fahrzeug transportieren.");
        }

        //Bsp-Methode Modul06
        public static void MontiereNeuesRad(IBewegbar bewegbaresObjekt)
        {
            bewegbaresObjekt.AnzahlRaeder++;
        }
    }

    static class Hilfsmethoden
    {
        //Mittels des THIS-Stichworts in der Parameterübergabe kann eine Methode als Erweiterungsmethode einer Klasse definiert
        //werden. Diese muss in einer statischen Klasse beschrieben werden und wird dann als Teil der zugeordneten Klasse betrachtet.
        public static int NextInclusive(this Random generator, int untergrenze, int obergrenze)
        {
            return generator.Next(untergrenze, obergrenze + 1);
        }
    } 
}
