using System;
using System.Collections;

namespace IteratorPattern
{
    public class Etudiant
    {
        private IEnumerable _etudiant;
        private IEnumerable _information;

        public Etudiant(ListeEleve etudiant, EtudiantInformation information)
        {
            this._etudiant = etudiant.Eleves;
            this._information = information.Eleves;
        }

        public void AfficherEleve()
        {
            var etudiant = _etudiant;
            AfficherEleve(etudiant);
            var information = _information;
            AfficherEleve(information);
        }

        private void AfficherEleve(IEnumerable iter)
        {
            foreach (var eleve in iter)
            {
                var i = (Information)eleve;
                Console.WriteLine($"{i.Nom}  Moyenne :. {i.Moyenne} Encouragement : {  (i.Encouragement ? "Oui" : "Non") } \n  Remarques : {i.Remarques} \n ");

            }
        }
    }
}