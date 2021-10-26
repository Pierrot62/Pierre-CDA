using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            //1.1
            //Console.WriteLine("Entre ton nom");
            //string nom = Console.ReadLine();
            //Console.WriteLine(nom);

            //1.2
            //int age;
            //Console.WriteLine("Entrez ton age");
            //age = int.Parse(Console.ReadLine());
            //Console.WriteLine(age);

            //bool flag1;
            //do
            //{
            //    try
            //    {
            //        Convert.ToInt32(age);
            //        Console.WriteLine("OK");
            //        flag1 = true;
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Valeur incorect");
            //        age = Console.ReadLine();
            //        flag1 = false;
            //    }
            //} while (!flag1);

            //1.3
            /*   string error = "/!\\ Valeur incorrecte /!\\";
                 Console.WriteLine("Valeur 1 :");
                 string val1 = Console.ReadLine();
                 int nb = 0;
                 bool flag2;
                 do
                 {
                     try
                     {
                         nb = Convert.ToInt32(val1);
                         flag2 = true;
                     }
                     catch
                     {
                         Console.WriteLine(error);
                         val1 = Console.ReadLine();
                         flag2 = false;
                     }
                 } while (!flag2);

                 Console.WriteLine("Valeur 2 :");
                 string val2 = Console.ReadLine();
                 int nb2 = 0;

                 do
                 {
                     try
                     {
                         nb2 = Convert.ToInt32(val2);
                         flag2 = true;

                     }
                     catch
                     {
                         Console.WriteLine(error); 
                         val2 = Console.ReadLine();
                         flag2 = false;
                     }
                 } while (!flag2);

                 int somme = nb + nb2;

                 if(nb2 == 0)
                 {
                     Console.WriteLine("La somme est de : " + somme);
                     Console.WriteLine("Calcul du quotien impossible");
                 }
                 else
                 {
                     int quotien = nb / nb2;
                     Console.WriteLine("Somme des deux valeurs : " + somme + " leurs quotien est : " + quotien);
                 }*/

            //1.4
            /*float nb;
            Console.WriteLine("Entre un float : ");
            nb = float.Parse(Console.ReadLine());
            Console.WriteLine("Le valeur du float est : " + nb);*/

            //1.5
            //int a, b, c;
            //Console.WriteLine("Val 1 : ");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Val 2 : ");
            //b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Val 3 : ");
            //c = int.Parse(Console.ReadLine());
            //Console.WriteLine("La moyenne des 3 valeurs et de : " + (a + b + c) / 3);

            //1.6

            /*            int L, l;
                        Console.WriteLine("Longueur : ");
                        l = int.Parse(Console.ReadLine());
                        Console.WriteLine("Largeur : ");
                        L = int.Parse(Console.ReadLine());
                        Console.WriteLine("La surface du rectangle est de : " + l * L + " Cm2");*/

            //1.8

            //Console.WriteLine("lettre en minuscule : ");
            //string mot = Console.ReadLine();
            //Console.WriteLine("Lettre en majuscule : " + mot.ToUpper());

            //2
            //2.1
            //Console.WriteLine("Caractere : ");
            //string mot = Console.ReadLine();
            //Console.WriteLine(int.Parse(mot)+1);

            //2.3
            //float k, M;
            //Console.WriteLine("Poid d'un colis : ");
            //k = float.Parse(Console.ReadLine());
            //Console.WriteLine("Capacité du camion : ");
            //M = float.Parse(Console.ReadLine());
            //Console.WriteLine("Il est possible de mettre " + Math.Round(M / k) + " carton(s) dans le camion !");

            //2.4
            //float somme;
            //Console.WriteLine("Entrer une somme ( 0 - 0,99 ) : ");
            //somme = float.Parse(Console.ReadLine());
            //Console.WriteLine(somme);




            //3
            //3.1
            int age = 0;
            Console.WriteLine("Votre age : ");
            age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Tu es majeur !");
                Console.Read();
            }else
            {
                Console.WriteLine("Tu es mineur !");
                Console.Read();
            }

        }
    }
}