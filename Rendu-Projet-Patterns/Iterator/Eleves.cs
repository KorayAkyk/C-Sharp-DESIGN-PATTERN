using System.Collections;

namespace IteratorPattern
{
    public class ListeEleve
    {
        private ArrayList _eleves;

        public IEnumerable Eleves
        {
            get
            {
                return new ElevesIterateur(_eleves);
            }
        }

        public ListeEleve()
        {
            _eleves = new ArrayList();

            AjouterEleve("Boris", "Eleve serieux mais alcoolique", 12, true);
            AjouterEleve("Yves", "Trop de discussion en cours", 10, false);
            AjouterEleve("Jakson", "Danse en cours !!", 15, false);
            AjouterEleve("Bendahmane", "Parfait", 20, true);
        }

        private void AjouterEleve(string nom, string remarques, int moyenne, bool encouragement)
        {
            var eleve = new Information(nom, remarques, moyenne, encouragement);
            _eleves.Add(eleve);
        }

    }
}