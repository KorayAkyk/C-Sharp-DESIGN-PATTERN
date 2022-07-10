using System;

namespace Projet_Design_Pattern_Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            FormImmatriculationLuxembourg formulaire1 = new
            FormImmatriculationLuxembourg(new FormHtmlImpl());
            formulaire1.affiche();
            if (formulaire1.gereSaisie())
            formulaire1.genereDocument();
            Console.WriteLine();
            FormImmatriculationFrance formulaire2 = new
            FormImmatriculationFrance(new FormAppletImpl());
            formulaire2.affiche();
            if (formulaire2.gereSaisie())
            formulaire2.genereDocument();
        }
    }
}
