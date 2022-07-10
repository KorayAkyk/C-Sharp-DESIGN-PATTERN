namespace ChainOfResponsability;

public abstract  class Handler
{
    protected Handler? suivant;
    
    public Handler elemSuivant(Handler suivant)
    {
        this.suivant = suivant;
        return suivant;
    }
    
    public abstract void Handle(string request);
}
