using System;
using System.Collections.Generic;
using System.Text;

namespace Employe
{
    class Enfants
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime Ddn { get; set; }

        public Enfants(string nom, string prenom, DateTime ddn)
        {
            Nom = nom;
            Prenom = prenom;
            Ddn = ddn;
        }

        public override string ToString()
        {
            return
                "\n***************************************************" +
                "\nNom                      : " + this.Nom +
                "\nPrenom                   : " + this.Prenom +
                "\nDate de naissance        : " + this.Ddn.ToString("dd/MM/yyyy") +
                "\n***************************************************";

        }
    }

}
