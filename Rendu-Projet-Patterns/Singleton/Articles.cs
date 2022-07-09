using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Singleton;

public class Articles
{
    protected float articleProteines;
    protected float articlePoids;
    protected double articleCalories;
    protected string? articlePrix;
    public virtual void Affichage()
    {
        Console.WriteLine("\n ---------------- Article: Inconnu ---------------- ");
        Console.WriteLine("\n -------------------------------------------------- ");
    }
}

public class Article : Articles
{
    private string article;
    private InformationArticles info;
    public Article(string article)
    {
        this.article = article;
    }
    public override void Affichage()
    {
        // L'adaptateur utilise le constructeur de la classe InformationArticles
        info = new InformationArticles();
        articleProteines = info.RecupProtPoids(article, "PR");
        articlePoids = info.RecupProtPoids(article, "POIDS");
        articleCalories = info.RecupCalories(article);
        articlePrix = info.RecupPrix(article);
        Console.WriteLine("\n ---------------- Article: {0} ---------------- ", article);
        Console.WriteLine("");
        Console.WriteLine("             Prix        : {0}   ", articlePrix);
        Console.WriteLine("             Calories    : {0}   ", articleCalories);
        Console.WriteLine("             Poids Pt    : {0}   ", articlePoids);
        Console.WriteLine("             Protéines   : {0}   ", articleProteines);
        Console.WriteLine("\n -------------------------------------------------- ", article);

    }
}
//Class adapter qui permet de récupérer les données d'un article
public class InformationArticles
{
    public float RecupProtPoids(string compound, string point)
    {
        // Le poids de l'article en grammes
        if (point == "POIDS")
        {
            switch (compound.ToLower())
            {
                case "kebab": return 450.0f;
                case "muffin": return 130.5f;
                case "burger": return 306.2f;
                default: return 0f;
            }
        }
        // Les protéines dans l'article en grammes
        else if (point == "PR")
        {
            switch (compound.ToLower())
            {
                case "kebab": return 19.2f;
                case "muffin": return 4.5f;
                case "burger": return 17.1f;
                default: return 0f;
            }
        }
        else
        {
            switch (compound.ToLower())
            {
                case "kebab": return 0.0f;
                case "muffin": return 0.0f;
                case "burger": return 0.0f;
                default: return 0f;
            }
        }
    }
    public string RecupPrix(string compound)
    {
        switch (compound.ToLower())
        {
            case "kebab": return "6 euros";
            case "muffin": return "3 euros";
            case "burger": return "8 euros";
            default: return "";
        }
    }
    public double RecupCalories(string compound)
    {
        switch (compound.ToLower())
        {
            case "kebab": return 1001.152;
            case "muffin": return 392.123;
            case "burger": return 825.365;
            default: return 0d;
        }
    }
}