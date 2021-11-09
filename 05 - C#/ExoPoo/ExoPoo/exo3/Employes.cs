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
        public Agences Agence { get; set; }
        public List<Enfants> Enfants { get; }
        public Employes(string nom, string prenom, DateTime dateEmbauche, string fonction, double salaire, string service, Agences agence, List<Enfants> enfant)
        {
            Nom = nom;
            Prenom = prenom;
            DateEmbauche = dateEmbauche;
            Fonction = fonction;
            Salaire = salaire;
            Service = service;
            this.Agence = agence;
            this.Enfants = enfant;
        }

        public double NbAnnees()
        {
            //Nombre d'années dans l'entreprise
            return (int)(DateTime.Today.Subtract(DateEmbauche).TotalDays / 365);
        }

        public bool ChequeVac()
        {
            if (this.NbAnnees() >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int[] ChequeNoel()
        {
            int[] tab = new int[3] { 0, 0, 0 }; 
            foreach (var enfant in Enfants)
            {
                int age = (int)DateTime.Today.Subtract(enfant.Ddn).TotalDays / 365; 
                if (enfant.Ddn > DateTime.Now) 
                {
                    age--;
                }
                if (age < 10)
                {
                    tab[0]++;
                }
                else if (age >= 11 && age <= 15) // **
                {
                    tab[1]++;
                }
                else if (age >= 15 && age <= 18) // **
                {
                    tab[2]++;
                }
            }
            return tab;
        }

        public void Augmentation()
        {
            //Augmentation de 5% chaque années
            this.Salaire += (0.05 * this.Salaire) / 100;
            //Augmentation de 2% pour chaque années dans la societe
            this.Salaire += ((NbAnnees() * 0.02) * this.Salaire) / 100;
        }

        public static int Classement(Employes a, Employes b)
        {
            if (a.Nom.CompareTo(b.Nom) > 0)
            {
                return 1;
            }else if(a.Nom.CompareTo(b.Nom) < 0)
            {
                return -1;
            }else if(a.Prenom.CompareTo(b.Nom) > 0)
            {
                return 1;
            }else
            {
                return -1;
            }
        }

        public override string ToString()
        {
            string Vac = ChequeVac() ? "Dispose de cheques Vacances" : "Ne dispose pas de cheques Vacances";

            string reponse =
            "****_INFORMATION_SUR_L'EMPLOYES_****" +
            "\n|Nom                : " + this.Nom +
            "\n|Prenom           : " + this.Prenom +
            "\n|Date Embauche    : " + this.DateEmbauche.ToString("dd/MM/yyyy") +
            "\n|Fonction         : " + this.Fonction +
            "\n|Salaire          : " + this.Salaire +
            "\n|Service          : " + this.Service +
            "\n|Cheque Vacances  : " + Vac + 
            this.Agence;
            if (Enfants.Count == 1)
            {
                reponse += "\n\n***ENFANT***";
            }
            else if (Enfants.Count >= 2 )
            {
                reponse += "\n\n***ENFANTS***";
            }
            foreach (var enfant in Enfants)
            {
                reponse += enfant;
            }
            int[] cheque = this.ChequeNoel();
            int somme = 0;
            for (int i = 0; i < cheque.Length; i++)
            {
                somme += cheque[i];
            }
            if (somme != 0)
            {
                reponse += "\nEligible au cheque Noël";
                reponse += "\nCheques noel :";
            }
            if (cheque[0] != 0)
            {
                reponse += "\n" + cheque[0] + " Cheque de 20Euros";
            }
            if (cheque[1] != 0)
            {
                reponse += "\n" + cheque[1] + " Cheque de 30Euros";
            }
            if (cheque[2] != 0)
            {
                reponse += "\n" + cheque[2] + " Cheque de 50Euros";
            }
            reponse += "\n***************************************************\n\n\n\n";

            return reponse;
        }

    }
}

