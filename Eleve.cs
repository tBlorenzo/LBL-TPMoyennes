using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNI_TPmoyennes
{
    internal class Eleve
    {

        private const int MAXNOTES = 200;

        public String prenom { get; private set; }
        public String nom { get; private set; }
        public List<Note> notes { get; private set; } = new();


        public Eleve(String prenom, String nom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        public void ajouterNote(Note note)
        {
            if (notes.Count < MAXNOTES)
            { notes.Add(note); }
        }

        public float moyenneGeneral()
        {
            float moy = 0;
            var matieres = notes.Select(n => n.matiere).Distinct().ToList();
            foreach (int matiere in matieres)
            {
                moy += moyenneMatiere(matiere);
            }
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
            return MathF.Round(moyMat/nb,2);
        }
    }
}
