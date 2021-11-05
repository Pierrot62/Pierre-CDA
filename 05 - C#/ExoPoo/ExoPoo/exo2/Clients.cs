using System;
using System.Collections.Generic;
using System.Text;

namespace ExoPoo.exo2
{
    class Clients
    {
        //Attributs
        public string CIN { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Tel { get; set; }


        //Constructeurs
        public Clients(string CIN, string nom, string prenom, string tel)
        {
            CIN = CIN;
            Nom = nom;
            Prenom = prenom;
            Tel = tel;
        }
        public Clients(string CIN, string nom, string prenom)
        {
            CIN = CIN;
            Nom = nom;
            Prenom = prenom;
        }

        public string Afficher()
        {
            return "Nom du client : " + this.Nom +"\n Prenom du client : " + this.Prenom + "\n CIN : " + CNI + "\n" 
        }
    }
}
