using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
    public class Flugzeug : Fahrzeug, IBewegbar
    {
        public int MaxFlughöhe { get; set; }
        public int AnzahlRaeder { get; set; }

        public Flugzeug(string name, int maxG, decimal preis, int maxFH) : base(name, maxG, preis)
        {
            this.MaxFlughöhe = maxFH;
        }

        public override string BeschreibeMich()
        {
            return "Das Flugzeug " + base.BeschreibeMich() + $"Es kann bis auf {this.MaxFlughöhe}m aufsteigen.";
        }

        public override void Hupe()
        {
            Console.WriteLine("BiepBiep");
        }

        public void Crash()
        {
            Console.WriteLine("Da war ein Vogel im Weg");
            this.AnzahlRaeder--;
        }
    }
}
