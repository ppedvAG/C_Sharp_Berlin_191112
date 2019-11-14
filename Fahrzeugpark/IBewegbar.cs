using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
    public interface IBewegbar
    {
        int AnzahlRaeder { get; set; }

        void Crash();
    }
}
