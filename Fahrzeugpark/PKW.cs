using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
    public class PKW : Fahrzeug
    {
        public int AnzahlTueren { get; set; }

        public PKW(string name, int maxG, decimal preis, int anzTueren) : base(name, maxG, preis)
        {
            this.AnzahlTueren = anzTueren;
        }

        public override string BeschreibeMich()
        {
            return "Der PKW " + base.BeschreibeMich() + $" Er hat {this.AnzahlTueren} Türen.";
        }

        public override void Hupe()
        {
            Console.WriteLine("HupHup");
        }
    }
}
