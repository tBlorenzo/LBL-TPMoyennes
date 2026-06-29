using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNI_TPmoyennes
{
    internal class Classe
    {
        private const int MAXELEVES = 30;
        private const int MAXMATIERES = 10;

        public String nomClasse {  get; private set; }
        public List<Eleve> eleves { get; private set; }
        public List<String> matieres { get; private set; }
        public float Moyenne { get; private set; }


        public Classe(String nom) 
        {
            this.nomClasse = nom;
            this.eleves = new List<Eleve>();
            this.matieres = new List<string>();
            this.Moyenne = 0;
        }

        public void ajouterEleve(String prenom,String nom)
        {
            eleves.Add(new Eleve(prenom,nom));
        }

        public void ajouterMatiere(String nom)
        {
            matieres.Add(nom);
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
