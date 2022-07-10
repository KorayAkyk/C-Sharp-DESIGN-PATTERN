namespace ChainOfResponsability;

public class WordGestion : Handler
{
    public override void Handle(string request)
    {
        if (request == ".doc" || request == ".docx" || request == ".docm")
        {
            //Console.WriteLine("Word",   request);
            Console.WriteLine(" | Fichier Word       |" + "  -- Type d'estensions disponibles : " + request);

        }
        else if (request != null
            && suivant != null)
        {
            string request1 = request;
            suivant.Handle(request1);
        }
    }
}