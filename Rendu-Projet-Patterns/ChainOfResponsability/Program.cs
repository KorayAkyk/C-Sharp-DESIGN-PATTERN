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
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("");
        Console.WriteLine("Design Pattern : Chain of Responsibility");
        Console.WriteLine("Bienvenue dans le gestionnaire de fichiers");
        Console.WriteLine("Ci-dessous, les types de fichiers disponibles :");
        Console.ResetColor();
        Console.WriteLine("------------------------------------------------------------------------------");
        foreach (string request in requests)
        {
            pdf.Handle(request);
        }
        Console.WriteLine("------------------------------------------------------------------------------");

    }
}