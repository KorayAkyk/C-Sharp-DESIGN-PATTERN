namespace IteratorPattern
{
    static class Program
    {
        private static void Main()
        {
            var eleve = new ListeEleve();
            var information = new EtudiantInformation();
            var etudiant = new Etudiant(eleve, information);
            etudiant.AfficherEleve();
        }
    }
}
