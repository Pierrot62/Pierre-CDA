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




            //6.1.1 Analyse oral
            //6.1.2 Analyse oral
            //6.1.3 Analyse oral


            //6.2.4
            //int[] liste = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine("              Un beau tableau  ");
            //Console.WriteLine("              +-------------+");
            //for (int i = 0; i < liste.Length; i++)
            //{
            //if (liste[i] < 10)
            //{
            //  Console.WriteLine("              | Poste {0}: {1}  |", i, liste[i]);
            //}
            //  else { Console.WriteLine("              | Poste {0}: {1} |", i, liste[i]); }
            //}
            //Console.WriteLine("              +-------------+");


            //6.2.5
            //int[] tab = new int[10];
            //for (int i = 0; i < tab.Length; i++)
            //{
            //    tab[i] = i + 1;
            //    Console.WriteLine("valeur : " + tab[i]);
            //}


            //6.2.6
            //int[] t = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int somme = 0;
            //for (int i = 0; i < t.Length; i++)
            //{
            //    somme = somme + t[i];
            //}
            //Console.Write("la somme est de: " + somme);


            //6.2.7
            //int[] t = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int cpt = 0;
            //Console.WriteLine("Donner un chiffre :");
            //int value = int.Parse(Console.ReadLine());
            //while (cpt < t.Length && t[cpt] != value)
            //{
            //    cpt++;
            //}
            //if (cpt < t.Length)
            //{
            //    Console.WriteLine("Bien joué !");
            //}
            //else
            //{
            //    Console.WriteLine("Le chiffre n'est pas dans le tableau.");
            //}

            //6.3.8
            //int[] tableau = new int[10];
            //int[] tableauCirculezYaRienAVoir = new int[10];
            //for (int i = 0; i < tableau.Length; i++)
            //    tableau[i] = i + 1;
            //for (int i = 0; i < tableau.Length; i++)
            //    tableauCirculezYaRienAVoir[(i + 1) % tableau.Length] = tableau[i];
            //foreach (int p in tableauCirculezYaRienAVoir)
            //    Console.WriteLine(p);

            //6.3.9
            //int[] k = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int stock;
            //stock = k[k.Length - 1];
            //for (int index = k.Length - 2; index >= 0; index--)
            //{
            //    k[index + 1] = k[index];
            //}
            //k[0] = stock;
            //foreach (int p in k)
            //{
            //    Console.WriteLine(p);
            //}

            //6.3.10
            //int[] t = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            //int temp;
            //for (int i = 0; i < (t.Length / 2); i++)
            //{
            //    temp = t[i];
            //    t[i] = t[t.Length - 1 - i];
            //    t[t.Length - 1 - i] = temp;
            //}
            //foreach (int val in t)
            //{
            //    Console.Write(val + " ");
            //}

            //6.4.11
            //int[] t = new int[10];
            //int i2;
            //Array.Resize(ref t, t.Length + 10);
            //for (int i = 0; i < t.Length; i++)
            //{
            //    i2 = i;
            //    for (int j = 1; j < i; j++)
            //    {
            //        i2 *= i;
            //    }
            //    t[i] = i2 % 17;
            //    Console.WriteLine(i2 % 17);
            //}


            //6.4.12
            //int[] t = new int[20] { 1, 2, -3, 4, 5, 6, 7, 8, 9, 10, 15, 20, 30, 35, 40, 45, 50, 55, 0, 65 };
            //int min, max;
            //min = t[0];
            //max = t[0];
            //for (int i = 0; i < t.Length; i++)
            //{
            //    if (t[i] < min)
            //    {
            //        min = t[i];

            //    }

            //    else if (t[i] > max)
            //    {
            //        max = t[i];
            //    }
            //}
            //Console.Write("la valeur minimale est de " + min + " et la valeur maximale est de " + max);

            //6.4.13
            //int[] t = new int[10] { 42, 59, 75, 62, 14, 1, 32, 5, 689, 32 };
            //int value;
            //bool apparition = false;

            //Console.Write("Saisissez une valeur numérique : ");
            //while (!int.TryParse(Console.ReadLine(), out value)) ;

            //for (int i = 0; i < t.Length; i++)
            //{
            //    if (t[i] == value)
            //    {
            //        Console.WriteLine("La valeur apparait a l'indice " + i + " du tableau.");
            //        apparition = true;
            //    }
            //}

            //if (!apparition)
            //{
            //    Console.WriteLine("La valeur n'apparait pas dans le tableau.");
            //}

            //6.4.14
            //int[] tab = new int[10] { 1, 58, 58, 4, 5, 6, 0, 8, 3, 58 };
            //int[] tab2 = new int[0];
            //int cpt = 0;
            //Console.Write("Entrez votre valeur : ");
            //int valeur = int.Parse(Console.ReadLine());
            //for (int i = 0; i < tab.Length; i++)
            //{
            //    if (tab[i] == valeur)
            //    {
            //        Array.Resize(ref tab2, tab2.Length + 1);
            //        tab2[cpt] = i;
            //        cpt++;
            //    }
            //}
            //foreach (var item in tab2)
            //{
            //    Console.Write(item + " ");
            //}

            //******

            //int valeur;
            //int[] k = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] q = new int[10];
            //List<int> liste = new List<int>();
            //Console.Write("Saisissez une valeur : ");
            //valeur = int.Parse(Console.ReadLine());
            //for (int i = 0; i < k.Length; i++)
            //{
            //    if (k[i] == valeur)
            //    {
            //        liste.Add(i);
            //        q = liste.ToArray();

            //    }
            //}
            //foreach (int p in q)
            //{
            //    Console.WriteLine(p);

            //}
            
        }
    }
}
