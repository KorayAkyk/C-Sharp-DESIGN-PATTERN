namespace ChainOfResponsability;

public class PdfGestion : Handler
{
public override void Handle(string request)
    {
        if (request == ".pdf")
        {
            //Console.WriteLine("PDF", request);
            Console.WriteLine(" | Fichier PDF        |" + "  -- Type d'estensions disponibles : " + request);
        }
        else if (request != null
            && suivant != null)
        {
            suivant.Handle(request: request);
        }
    }
}