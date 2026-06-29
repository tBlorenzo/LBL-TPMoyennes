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
        public List<Eleve> eleves { get; private set; } = new();
        public List<String> matieres { get; private set; } = new();


        public Classe(String nom) 
        {
            this.nomClasse = nom;
        }

        public void ajouterEleve(String prenom,String nom)
        {
            if (eleves.Count < MAXELEVES)
            { eleves.Add(new Eleve(prenom, nom)); }
        }

        public void ajouterMatiere(String nom)
        {
            if (matieres.Count < MAXMATIERES)
               { matieres.Add(nom); }
        }

        public float moyenneGeneral()
        {
            float moy = 0;
            
            foreach (Eleve eleve in eleves)
            {
                moy += eleve.moyenneGeneral();
            }
            return MathF.Round(moy / eleves.Count, 2);

        }

        public float moyenneMatiere(int iMatiere)
        {
            float moyMat = 0;
            foreach (Eleve eleve in eleves)
            {
                moyMat += eleve.moyenneMatiere(iMatiere);
            }
            return MathF.Round(moyMat / eleves.Count, 2);
        }
    }
}
