using System;

namespace Projet_Design_Pattern_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            VueVehicule vueVehicule = new VueVehicule();
            ModeleDecorateur modeleDecorateur = new
            ModeleDecorateur(vueVehicule);
            MarqueDecorateur marqueDecorateur = new
            MarqueDecorateur(modeleDecorateur);
            marqueDecorateur.affiche();
        }
    }
}
