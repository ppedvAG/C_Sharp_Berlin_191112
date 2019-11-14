using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WdhPolymorphismus
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund hund1 = new Hund("Bello", "Braun");
            Console.WriteLine(hund1.Name);

            Meise meise1 = new Meise("Tschiep", "Blau");

            hund1.Name = "Hasso";

            Tier tier1 = hund1;

            Console.WriteLine(tier1.Name);

            tier1 = meise1;

            Console.WriteLine(tier1.Name);

            if (tier1 is Hund)
                ((Hund)tier1).FellFarbe = "Schwarz";
            else
            {
                ((Meise)tier1).FederFarbe = "Rot";
                meise1 = (Meise)tier1;
                Console.WriteLine(meise1.FederFarbe);
            }

            Flugzeug fz = new Flugzeug();

            Abstuerzen(fz);

            Abstuerzen(meise1);

            IFlugfähig flugfähig = meise1;

            Abstuerzen(flugfähig);

            Console.ReadKey();
        }

        public static void Abstuerzen(IFlugfähig flugfähig)
        {
            flugfähig.FlügelAnzahl--;

            if(flugfähig is Meise)
                Console.WriteLine($"{((Meise)flugfähig).Name} ist abgestürzt");
        }
    }

    public abstract class Tier
    {
        public string Name { get; set; }
        public int AnzahlBeine { get; set; }

        public Tier(string name, int anzB)
        {
            this.Name = name;
            this.AnzahlBeine = anzB;
        }
    }

    public class Hund : Tier
    {
        public string FellFarbe { get; set; }

        public Hund(string name, string farbe): base(name, 4)
        {
            this.FellFarbe = farbe;
        }

    }

    public class Meise : Tier, IFlugfähig
    {
        public string FederFarbe { get; set; }
        public int FlügelAnzahl { get; set; }

        public Meise(string name, string farbe):base(name, 2)
        {
            this.FederFarbe = farbe;
        }

        public void Abheben()
        {
            Console.WriteLine("Dieses Tier fliegt jetzt.");
        }
    }

    public class Flugzeug : IFlugfähig
    {
        public Flugzeug() { this.FlügelAnzahl = 2; }

        public int FlügelAnzahl { get; set; }

        public void Abheben()
        {
            Console.WriteLine("Flugzeug fliegt");
        }
    }

    public interface IFlugfähig
    {
        int FlügelAnzahl { get; set; }

        void Abheben();
    }
}
