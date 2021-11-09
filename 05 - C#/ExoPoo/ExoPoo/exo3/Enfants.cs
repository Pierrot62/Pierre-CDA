using System;
using System.Collections.Generic;
using System.Text;

namespace ExoPoo.Exo3
{
    class Enfants
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime Ddn { get; set; }

        public Enfants(string nom, string prenom, DateTime age)
        {
            Nom = nom;
            Prenom = prenom;
            Ddn = age;
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
