using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Guitare : TypeCorde
    {
        public Guitare(string instrument) : base(instrument) { }

        public override void afficherInstrument()
        {
            Console.WriteLine($"C'est la {Instrument} qui est un instrument à cordes pincées.");
        }
    }
}
