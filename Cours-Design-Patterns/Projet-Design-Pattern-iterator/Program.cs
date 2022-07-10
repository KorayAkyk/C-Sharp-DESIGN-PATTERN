using System;

namespace Projet_Design_Pattern_iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            CatalogueVehicule catalogue = new CatalogueVehicule();
            IterateurVehicule iterateur = catalogue.recherche(
            "bon march�");
            Vehicule vehicule;
            iterateur.debut();
            vehicule = iterateur.item();
            while (vehicule != null)
            {
            vehicule.affiche();
            iterateur.suivant();
            vehicule = iterateur.item();
            }
        }
    }
}
