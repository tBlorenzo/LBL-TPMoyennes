using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBL_TPmoyennes
{
    internal class Eleve
    {

        private const int MAXNOTES = 200;

        public String prenom { get; private set; }
        public String nom { get; private set; }
        private List<Note> notes { get; private set; } = new();


        public Eleve(String prenom, String nom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        public void ajouterNote(Note note)
        {
            if (notes.Count < MAXNOTES)
            { notes.Add(note); }
            else
                throw new InvalidOperationException($"Nombre max de notes pour l'eleve {this.prenom}{this.nom} atteint");
        }

        public float moyenneGeneral()
        {
            float moy = 0;
            var matieres = notes.Select(n => n.matiere).Distinct().ToList();
            foreach (int matiere in matieres)
            {
                moy += moyenneMatiere(matiere);
            }
            if (matieres.Count ==0)
                throw new InvalidOperationException($"{this.prenom} {this.nom} n'a pas de notes, division par zero");

            return MathF.Round(moy/matieres.Count,2);
        }

        public float moyenneMatiere(int iMatiere)
        {
            int nb = 0;
            float moyMat = 0;
            foreach (Note note in notes)
            {
                if (note.matiere == iMatiere)
                {
                    moyMat += note.note;
                    nb++;
                }
            }
            if (nb == 0)
                throw new InvalidOperationException($"{this.prenom} {this.nom} n'a pas de note dans la matiere d'indice {iMatiere}, division par zero");
            return MathF.Round(moyMat/nb,2);
        }
    }
}
