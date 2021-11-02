using System;

namespace Corrections
{
    class Program
    {
        static void Main(string[] args)
        {

            //1 VARIABLE
            /* Exercice 1-1 */
            string chaine1;
            Console.Write("Entrez votre nom : ");
            chaine1 = Console.ReadLine();
            Console.Write("La nom saisie est : " + chaine1);
            Console.ReadLine();

            //Exercie 1.2
            int nb;
            Console.WriteLine("Entrez un entier : ");
            nb = int.Parse(Console.ReadLine());
            //nb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nb);


            //*********


            //4 LES BOUCLES

            //4.1.1   compréhension oral
            //4.1.2   compréhension oral
            //4.1.3   compréhension oral

            //4.2.4
            //compte a rebours

            //do while
            //int val;
            //Console.WriteLine("Entrez une valeur :");
            //val = int.Parse(Console.ReadLine());
            //do
            //{
            //    Console.WriteLine(val--);
            //} while (val >= 0);

            //while
            //int val1;
            //Console.Write("Saisissez une valeur:");
            //val1 = int.Parse(Console.ReadLine());
            //while (val1 >= 0)
            //{
            //    Console.WriteLine(val1--);
            //}

            //For
            //int n;
            //Console.Write("Saisissez un nombre positif : ");
            //n = int.Parse(Console.ReadLine());
            //for (int i = n; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}


            //4.2.5

            //int valeur;
            //int fact = 1;
            //int i = 1;
            //Console.Write("Entrez une valeur entière positive : ");
            //valeur = Convert.ToInt32(Console.ReadLine());
            //while (i <= valeur)
            //{
            //    fact *= i++;
            //}
            //Console.WriteLine("La factorielle de " + valeur + " est " + fact);

            //int saisie;
            //int resultat;
            //Console.WriteLine("saisir un entier positif");
            //saisie = int.Parse(Console.ReadLine());

            //Console.WriteLine();
            //resultat = 1;
            //for (int i = 1; i <= saisie; i++)
            //{
            //    resultat *= i;
            //}
            //Console.WriteLine(resultat);

            //int n;
            //int i;
            //Console.Write("Veuillez rentrez une valeur :");
            //n = int.Parse(Console.ReadLine());
            //i = 1;
            //do
            //{
            //    n *= i++;
            //}
            //while (i <= n)
            //Console.WriteLine("La factorielle de " + n + " est " + n);


            //4.3.6
            //int nb;
            //bool val;
            //do
            //{
            //    Console.Write("Entrez une valeur entière : ");
            //    val = int.TryParse(Console.ReadLine(), out nb);
            //} while (!val || nb < 0);

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(nb + " x " + i + " = " + (nb * i));
            //}


            //4.3.7
            //int valeur;
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        valeur = i * j;
            //        Console.Write(valeur + ",");
            //    }
            //    Console.WriteLine("");
            //}


            //4.3.8
            //int nombre, puissance;
            //int total = 1;
            //int i;
            //bool boolean;

            //do
            //{

            //    Console.WriteLine("entrer le nombre ");
            //    nombre = int.Parse(Console.ReadLine());
            //    Console.WriteLine("entrer la puissance ");
            //    boolean = int.TryParse(Console.ReadLine(), out puissance);

            //} while (!boolean || puissance < 0);

            //for (i = 1; i <= puissance; i++)
            //{
            //    total = total * nombre;
            //}
            //Console.WriteLine("total de l'operation " + total);

            //4.3.9
            //int n;
            //Console.Write("Saisissez une valeur:");
            //n = int.Parse(Console.ReadLine());
            //for (int j = 0; j < n; j++)
            //{
            //    Console.WriteLine();

            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write("X ");
            //    }

            //}


            //4.4.10

            //4.4.11

            //4.4.12

        }
    }
}
