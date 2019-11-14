using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
    public class PKW : Fahrzeug, IBewegbar
    {
        public int AnzahlTueren { get; set; }
        public int AnzahlRaeder { get; set; }

        public PKW(string name, int maxG, decimal preis, int anzTueren) : base(name, maxG, preis)
        {
            this.AnzahlTueren = anzTueren;
            this.AnzahlRaeder = 4;
        }

        public override string BeschreibeMich()
        {
            return "Der PKW " + base.BeschreibeMich() + $" Er hat {this.AnzahlTueren} Türen.";
        }

        public override void Hupe()
        {
            Console.WriteLine("HupHup");
        }

        public void Crash()
        {
            Console.WriteLine("Du hast den Baum übersehen.");
            this.AnzahlRaeder--;
        }
    }
}
