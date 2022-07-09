using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Uttilisateur
    {
        public string Nom { get; set; }
        private GestionCommande GestionCommande { get; set; }

        public Uttilisateur(string nom)
        {
            this.Nom = nom;
            this.GestionCommande = GestionCommande.Instance;
            Console.WriteLine($"L'uttilsateur {Nom} a été ajouté à la liste des uttilisateurs du Magasin");
        }

        public void Ajouter(Commande commandeActuelle)
        {
            GestionCommande.AjouterCommande(commandeActuelle);    
        }

        public void AfficherCommande()
        {
            Console.WriteLine($"\n{Nom} a passé la commande suivante :");
            GestionCommande.AfficherCommande();
        }

    }
}
