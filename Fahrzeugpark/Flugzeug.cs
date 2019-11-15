using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
    //vgl auch PKW
    public class Flugzeug : Fahrzeug, IBewegbar, IEnumerable
    {
        public int MaxFlughöhe { get; set; }
        public int AnzahlRaeder { get; set; }

        public List<string> Passagierliste { get; set; }

        public string this[int i]
        {
            get { return Passagierliste[i]; }
            set { Passagierliste[i] = value; }
        }

        public Flugzeug(string name, int maxG, decimal preis, int maxFH) : base(name, maxG, preis)
        {
            this.MaxFlughöhe = maxFH;

            Passagierliste = new List<string>() { "Hugo", "Anna", "Otto", "Maria" };
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

        public IEnumerator GetEnumerator()
        {
            foreach (var item in this.Passagierliste)
            {
                yield return item;
            }
        }
    }
}
