using System.Runtime.Serialization;
using Singleton;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
internal class Program
{
    private static void Main(string[] args)
    {
        DateTime now = DateTime.Now;

        Console.ResetColor();
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Présentation du design pattern Singleton");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("");

        // Attente de l'entrée du clavier pour confirmer le résultat
        
        Console.WriteLine("Appuyer sur une touche pour commencer à visualiser la commandes passée par les utilisateurs...");
        Console.ResetColor();
        Console.ReadKey();
        
        Console.ForegroundColor = ConsoleColor.Green;
        Uttilisateur utilisateur1 = new Uttilisateur("Koko");
        Uttilisateur utilisateur2 = new Uttilisateur("Brut");
        Uttilisateur utilisateur3 = new Uttilisateur("Kebab");

        utilisateur3.Ajouter(new Commande($"{utilisateur3.Nom}", new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second)));
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Appuyer sur une touche pour visualiser la nouvelle commande...");
        Console.ReadKey();
        Console.ForegroundColor = ConsoleColor.Green;
        utilisateur3.AfficherCommande();

        
        utilisateur2.Ajouter(new Commande($"{utilisateur2.Nom}", new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second)));
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Appuyer sur une touche pour visualiser la nouvelle commande...");
        Console.ReadKey();
        Console.ForegroundColor = ConsoleColor.Green;
        utilisateur2.AfficherCommande();
        //Console.ReadKey();

        
        utilisateur1.Ajouter(new Commande($"{utilisateur1.Nom}", new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second)));
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Appuyer sur une touche pour visualiser la nouvelle commande...");
        Console.ReadKey();
        Console.ForegroundColor = ConsoleColor.Green;
        utilisateur1.AfficherCommande();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Fin de la visualisation du design pattern Singleton représentant une visualisation de la commande passée par les utilisateurs");
        Console.ReadKey();
        Console.ResetColor();
    }
}