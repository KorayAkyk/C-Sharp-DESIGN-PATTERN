namespace IteratorPattern
{
    public class Information
    {
        public string Nom { get; }
        public string Remarques { get; }
        public bool Encouragement { get; }
        public double Moyenne { get; }

        public Information(string nom, string remarques, double moyenne, bool encouragement)
        {
            Nom = nom;
            Remarques = remarques;
            Moyenne = moyenne;
            Encouragement = encouragement;
        }

    }
}