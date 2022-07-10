namespace ChainOfResponsability;

public class PowerPointGestion : Handler
{
    public override void Handle(string request)
    {
        if (request == ".ppt" || request == ".pptx")
        {
            //Console.WriteLine("PowerPoint" , request);
            Console.WriteLine(" | Fichier PowerPoint | " + " -- Type d'estensions disponibles : " + request);

        }
        else if (request != null
            && suivant != null)
        {
            suivant.Handle(request: request);
        }
    }
}
