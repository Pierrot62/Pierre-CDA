using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExoPoo.Exo3
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

        public double NbAnnees()
        {
            //Nombre d'années dans l'entreprise
            return (int)(DateTime.Today.Subtract(DateEmbauche).TotalDays / 365);
        }

        public void Augmentation()
        {
            //Augmentation de 5% chaque années
            this.Salaire += (0.05 * this.Salaire) / 100;
            //Augmentation de 2% pour chaque années dans la societe
            this.Salaire += ((NbAnnees() * 0.02) * this.Salaire) / 100;
        }

    }
}

