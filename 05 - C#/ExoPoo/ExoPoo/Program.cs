using System;
using System.Collections.Generic;
using ExoPoo.Exo1;
using ExoPoo.Exo2;
using ExoPoo.Exo3;
namespace ExoPoo
{
    class Program
    {
        static void Main()
        {

            //Voitures v1 = new Voitures("Noir", "Citroen",,10000, "Essence");
            //Voitures v2 = new Voitures("Rouge", "Renault", "Kadjar", 845, "Diesel");
            //v1.Rouler(50);
            //Console.WriteLine(v1);
            //Console.WriteLine(v2);

            //Clients pierre = new Clients("FFZ23113", "COURQUIN", "Pierre", "06.06.49.69.02");
            //Clients martine = new Clients("FFZ23113", "POIX", "Martine", "06.06.06.06.06");

            //Comptes compte1 = new Comptes(710, 2876, pierre);
            ////Comptes compte2 = new Comptes(1000000, 1708, martine);
            //Comptes compte3 = new Comptes(1000000, 1708, martine);

            //Console.WriteLine("Information pour le compte numero : " + compte1.Numero + "\nSolde du compte : " + compte1.Solde + " Euros\nCode du compte : " + compte1.Code + "\nTitulaire du compte : \nNom : " + compte1.Titulaire.Nom + "\nPrenom : " + compte1.Titulaire.Prenom + "\nCIN : " + compte1.Titulaire.Cin);

            //Console.WriteLine("Information pour le compte numero : " + compte3.Numero + "\nSolde du compte : " + compte3.Solde + " Euros\nCode du compte : " + compte3.Code + "\nTitulaire du compte : \nNom : " + compte3.Titulaire.Nom + "\nPrenom : " + compte3.Titulaire.Prenom + "\nCIN : " + compte3.Titulaire.Cin);

            //compte3.Crediter(50);
            //Console.WriteLine(compte3);
            Agences prapage = new Agences("Prapage", "96 Rue de la paix", 62200, "Boulogne", RestaurationEnum.RestaurantEntreprise);
            Agences afpa = new Agences("Afpa", "407 avenue de la gironde", 59111, "Dunkerque", RestaurationEnum.TicketRestaurant);

            Enfants paul = new Enfants("Paul", "Parker", new DateTime(2012,05,04));
            Enfants lola = new Enfants("Lola", "Blanpain", new DateTime(2010, 02, 08));
            Enfants lucie = new Enfants("Lucie", "Dupont", new DateTime(2015, 05, 12));

            Employes bruno = new Employes("Bruno", "MAYEUX", new DateTime(2000, 10, 15), "Chef de projet", 45500, "Front-End", afpa ,new List<Enfants>(){ paul, lola });
            Employes pierre = new Employes("Pierre", "COURQUIN", new DateTime(2020, 5, 1), "Developpeur", 67500, "Front-End", afpa , new List<Enfants>() { });
            Employes martine = new Employes("Martine", "POIX", new DateTime(2021, 11, 01), "Stagiaire", 0, "Café", afpa ,new List<Enfants>(){ lucie });
            Employes quentin = new Employes("Quentin", "BALAIR", new DateTime(2017, 02, 15), "Developpeur", 0, "Back-End", prapage, new List<Enfants>() { });
            Employes maxence = new Employes("Maxence", "THACKER", new DateTime(2021, 11, 01), "Stagiaire", -1000, "Menage", prapage, new List<Enfants>() { });

            //DateTime dateDeVersement = new DateTime(2021, 11, 08);
            //Console.WriteLine(Bruno.Salaire);
            //if (DateTime.Today == dateDeVersement)
            //{
            //    Bruno.Augmentation();
            //    Pierre.Augmentation();
            //    Martine.Augmentation();
            //    Quentin.Augmentation();
            //    Maxence.Augmentation();
            //}

            List<Employes> listeEmployes = new List<Employes>()
            {
            bruno,
            pierre,
            martine,
            quentin,
            maxence
            };

            //Console.WriteLine(ListeEmployes);

            listeEmployes.Sort(Employes.Classement);
            Console.WriteLine("Nombre d'employer dans la societe : " + listeEmployes.Count);
            foreach (var employe in listeEmployes)
            {
                Console.WriteLine("\n"+employe);
            }
            double masse = 0;

            for (int i = 0; i < listeEmployes.Count; i++)
            {
                masse += listeEmployes[i].Salaire; 
            }
            Console.WriteLine("\n\nLa masse salarial est de : " + masse);
        }
        public enum RestaurationEnum
        {
            RestaurantEntreprise,
            TicketRestaurant
        }
    }
}

