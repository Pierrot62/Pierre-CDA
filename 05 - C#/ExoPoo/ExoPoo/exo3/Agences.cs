using System;
using System.Collections.Generic;
using System.Text;
using static ExoPoo.Program;

namespace ExoPoo.Exo3
{
    class Agences
    {
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public int CodePostal { get; set; }
        public string Ville { get; set; }
        public RestaurationEnum Restauration { get; set; }

        public Agences(string nom, string adresse, int codePostal, string ville, RestaurationEnum restauration)
        {
            Nom = nom;
            Adresse = adresse;
            CodePostal = codePostal;
            Ville = ville;
            Restauration = restauration;
        }

        public override string ToString()
        {
            return 
                "\n***AGENCE***" +
                "\nNom                  :"+ this.Nom + 
                "\nAdresse              : " + this.Adresse + 
                "\nCode postal          : " + this.CodePostal + 
                "\nVille                : " + this.Ville + 
                "\nMode de restauration : " + this.Restauration;
        }
    }
}
