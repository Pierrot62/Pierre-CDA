using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExoPoo
{
    class Employes
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateEmbauche { get; set; }
        public string Fonction { get; set; }
        public double Salaire { get; set; }
        public string Service { get; set; }

        public Employes(string nom, string prenom, DateTime dateEmbauche, string fonction, double salaire, string service)
        {
            Nom = nom;
            Prenom = prenom;
            DateEmbauche = dateEmbauche;
            Fonction = fonction;
            Salaire = salaire;
            Service = service;
        }

        public DateTime nbAnnees()
        {

            DateTime compare = DateTime.Today - new(DateEmbauche);
        }
    }
}

