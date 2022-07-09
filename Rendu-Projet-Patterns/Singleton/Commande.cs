using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
        public class Commande
    {
        public string nom { get; set; }
        public DateTime Date { get; set; }

        public Commande(string leNom, DateTime date)
        {
            this.nom = leNom;
            this.Date = date;
        }
    }
    public class GestionCommande
    {
        private static GestionCommande? _instance = null;
        public List<Commande> commande;

        private GestionCommande()
        {
            commande = new List<Commande>();
        }

        public static GestionCommande Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GestionCommande();
                return _instance;
            }
        }
        public void CommandeEnCours(Commande commandeActuelle) => commande.Add(commandeActuelle);

        public void AfficherCommande()
        {
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("| \t Date \t\t\t | \t\t Nom \t\t\t |");
            Console.WriteLine("--------------------------------------------------------------------------");
            foreach(Commande laCommande in commande)
            {
                Console.WriteLine($"| \t {laCommande.Date.ToString("yyyy-MM-dd hh:mm:ss")} \t | \t {laCommande.nom} \t\t\t\t |");
            }
            Console.WriteLine("--------------------------------------------------------------------------\n");
        }
        public bool AjouterCommande(Commande laCommande)
        {
            if (NewMethod(laCommande))
            {
                Console.WriteLine($"La commande de '{laCommande.nom}' est déjà en cours de préparation");
                return false;
            }

            commande.Add(laCommande);
            Console.WriteLine($"\n La commande de '{laCommande.nom}' est en cours de préparation");
            return true;

            bool NewMethod(Commande laCommande)
            {
                return commande.Contains(laCommande);
            }
        }
    }
}
