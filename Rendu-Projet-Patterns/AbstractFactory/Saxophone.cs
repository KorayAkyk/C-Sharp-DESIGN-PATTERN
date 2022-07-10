using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Saxophone : TypeVent
    {
        public Saxophone(string instrument) : base(instrument) { }

        public override void afficherInstrument()
        {
            Console.WriteLine($"C'est le {Instrument} qui est un instrument à vent de la famille des bois");
        }
    }
}
