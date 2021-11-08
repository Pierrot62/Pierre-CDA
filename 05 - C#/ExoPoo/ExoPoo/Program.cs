using System;

namespace ExoPoo
{
    class Program
    {
        static void Main()
        {
            //Voitures v1 = new Voitures("Noir", "Citroen", "C4", 10000, "essence");
            //Voitures v2 = new Voitures("Rouge", "Renault", "Kadjar", 845, "Diesel");
            //v1.Rouler(50);
            //Console.WriteLine(v1);
            //Console.WriteLine(v2);

            Clients Pierre = new Clients("FFZ23113", "COURQUIN", "Pierre", "06.06.49.69.02");
            Clients Martine = new Clients("FFZ23113", "POIX", "Martine", "06.06.06.06.06");

            Comptes compte1 = new Comptes(710, 2876, Pierre);
            //Comptes compte2 = new Comptes(1000000, 1708, Martine);
            Comptes compte3 = new Comptes(0, 1708, Martine);


            //Console.WriteLine("Information pour le compte numero : " + compte1.Numero + "\nSolde du compte : " + compte1.Solde + " Euros\nCode du compte : " + compte1.Code + "\nTitulaire du compte : \nNom : " + compte1.Titulaire.Nom + "\nPrenom : " + compte1.Titulaire.Prenom + "\nCIN : " + compte1.Titulaire.Cin);

            //Console.WriteLine("Information pour le compte numero : " + compte3.Numero + "\nSolde du compte : " + compte3.Solde + " Euros\nCode du compte : " + compte3.Code + "\nTitulaire du compte : \nNom : " + compte3.Titulaire.Nom + "\nPrenom : " + compte3.Titulaire.Prenom + "\nCIN : " + compte3.Titulaire.Cin);

            //compte3.Crediter(50);
            //Console.WriteLine(compte3);
            Console.WriteLine(DateTime.Today);
            //    Employes Paul = new Employes("Paul", "Henry", new DateTime(2000,10,15), "Chef de projet", 45500, "Developpement");
            //    Console.WriteLine(Paul.nbAnnees());
        }
    }
}
