using AbstractFactory;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Orchestre instrumentCorde = new InstrumentCorde();

        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Design Pattern : Abstract Factory");
        Console.WriteLine("Ce programme resproduit un exemple d'utilisation du pattern Abstract Factory avec des instruments de cordes et des instruments de vent.");
        Console.ResetColor();

        Console.WriteLine("");
        Console.WriteLine("-----------------------------------------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Je suis un instrument à corde. \nAppuyez sur une touche pour découvrir l'instrument.");
        Console.ResetColor();
        Console.ReadKey();
        Console.ForegroundColor = ConsoleColor.Green;
        TypeCorde guitare = instrumentCorde.ajouterCorde("Guitare");
        guitare.afficherInstrument();
        Console.ResetColor();
        Console.ReadKey();

        Console.WriteLine("");
        Console.WriteLine("-----------------------------------------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Je suis un instrument à vent. \nAppuyez sur une touche pour découvrir l'instrument.");
        Console.ResetColor();
        Console.ReadKey();
        Console.ForegroundColor = ConsoleColor.Green;
        TypeVent clarinette = instrumentCorde.ajouterVent("Clarinette");
        clarinette.afficherInstrument();
        Console.ResetColor();
        Console.ReadKey();

        Console.WriteLine("");
        Console.WriteLine("-----------------------------------------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Je suis un instrument à corde. \nAppuyez sur une touche pour découvrir l'instrument.");
        Console.ResetColor();
        Console.ReadKey();
        Orchestre instrumentVent = new InstrumentVent();
        Console.ForegroundColor = ConsoleColor.Green;
        TypeCorde saz = instrumentVent.ajouterCorde("Saz");
        saz.afficherInstrument();
        Console.ResetColor();
        Console.ReadKey();

        Console.WriteLine("");
        Console.WriteLine("-----------------------------------------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Je suis un instrument à vent. \nAppuyez sur une touche pour découvrir l'instrument.");
        Console.ResetColor();
        Console.ReadKey();
        Console.ForegroundColor = ConsoleColor.Green;
        TypeVent saxophone = instrumentVent.ajouterVent("Saxophone");
        saxophone.afficherInstrument();
        Console.ResetColor();
        Console.ReadKey();
    }
}