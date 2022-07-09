using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Singleton;

//Design pattern: Adapter
//Le design pattern Adapter est un design pattern qui permet de transformer un objet en un autre objet.
public class Program
{
    public static void Main(string[] args)
    {
        // Article non adapté
        Articles articleInconnu = new Articles();
        articleInconnu.Affichage();
        // Artcile adapté présent dans sur la carte
        Articles kebab = new Article("Kebab");
        kebab.Affichage();
        Articles muffin = new Article("Muffin");
        muffin.Affichage();
        Articles burger = new Article("Burger");
        burger.Affichage();
        // Attente de l'entrée du clavier pour terminer le programme
        Console.ReadKey();
    }
}