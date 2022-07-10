using System;

namespace Projet_Design_Pattern_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Societe societe1 = new SocieteSansFiliale();
            societe1.ajouteVehicule();
            Societe societe2 = new SocieteSansFiliale();
            societe2.ajouteVehicule();
            societe2.ajouteVehicule();
            Societe groupe = new SocieteMere();
            groupe.ajouteFiliale(societe1);
            groupe.ajouteFiliale(societe2);
            groupe.ajouteVehicule();
            Console.WriteLine(
            " Cout d'entretien total du groupe : " +  groupe.calculeCoutEntretien());
        }
    }
}
