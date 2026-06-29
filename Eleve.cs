using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNI_TPmoyennes
{
    internal class Eleve
    {

        private const int MAXNOTES= 200;

        public String prenom {  get; private set; }
        public String nom {  get; private set; }
        public float Moyenne { get; private set; }
        public List<Note> notes { get; private set; }


        public Eleve(String prenom, String nom)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.Moyenne = 0;
            this.notes= new List<Note>();
        }

        public void ajouterNote(Note note)
        {
            notes.Add(note);
        }

        public float moyenneGeneral()
        {
            return Moyenne;
        }

        public float moyenneMatiere(int i)
        {
            return Moyenne;
        }
    }
}
