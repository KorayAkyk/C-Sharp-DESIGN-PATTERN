namespace ChainOfResponsability;

public class ExcelGestion : Handler
{
    public override void Handle(string request)
    {
        if (request == ".xls" || request == ".xlsx" || request == ".xlsm")
        {
            Console.WriteLine(" | Fichier Excel      | " + " -- Type d'estensions disponibles : " + request);
        }
        else if (request != null
            && suivant != null)
        {
            suivant.Handle(request: request);
        }
        
    }
}
