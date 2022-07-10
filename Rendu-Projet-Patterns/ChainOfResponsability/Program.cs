using ChainOfResponsability;

public class Program
{
    static void Main(string[] args)
    {
        PdfGestion pdf = new PdfGestion();
        WordGestion word = new WordGestion();
        ExcelGestion excel = new ExcelGestion();
        PowerPointGestion powerpoint = new PowerPointGestion();

        pdf.elemSuivant(word).elemSuivant(powerpoint).elemSuivant(excel);
        
        string[] requests = { ".doc", ".docx",".docm", ".pdf", ".ppt", ".pptx", ".xls", ".xlsx",".xlsm"};
        //Console.BackgroundColor = ConsoleColor.Blue;

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("");

        Console.WriteLine("Design Pattern : Chain of Responsibility");
        Console.WriteLine("Bienvenue dans le gestionnaire de fichiers");
        Console.WriteLine("Ci-dessous, les types de fichiers disponibles :");
        Console.WriteLine("Appuyez sur une touche pour découvrir les types de fichiers...");
        Console.ResetColor();
        Console.ReadKey();

        Console.ResetColor();
        Console.WriteLine("------------------------------------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Green;
        foreach (string request in requests)
        {
            pdf.Handle(request);
        }
        Console.ResetColor();
        Console.WriteLine("------------------------------------------------------------------------------");

    }
}