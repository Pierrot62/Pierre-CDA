using System;
using System.Collections.Generic;
using System.Text;

namespace ExoPoo
{
    class Clients
    {
        //Attributs
        public string Cin { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Tel { get; set; }


        //Constructeurs
        public Clients(string CIN, string nom, string prenom, string tel)
        {
            Cin = CIN;
            Nom = nom;
            Prenom = prenom;
            Tel = tel;
            
        }
        public Clients(string CIN, string nom, string prenom)
        {
            Cin = CIN;
            Nom = nom;
            Prenom = prenom;

        }

        public string Afficher()
        {
            return "Nom du client : " + this.Nom + "\nPrenom du client : " + this.Prenom + "\nCIN : " + Cin;
        }
    }
}
