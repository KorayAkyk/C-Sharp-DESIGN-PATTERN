using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Saz : TypeCorde
    {
        public Saz(string instrument) : base(instrument) { }

        public override void afficherInstrument()
        {
            Console.WriteLine($"C'est le {Instrument} qui est un instrument traditionnel Turque ressemblant à une Mandoline.");
        }
    }
}
