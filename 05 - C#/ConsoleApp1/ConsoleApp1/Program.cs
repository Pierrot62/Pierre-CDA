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

            // 2.2
            //char val1 = '0';
            //char val2 = '1';
            //char val3 = '2';
            //char val4 = '3';
            //char val5 = '4';
            //char val6 = '5';
            //char val7 = '6';
            //char val8 = '7';
            //char val9 = '8';
            //char val10 = '9';

            //Console.WriteLine((int)val1);
            //Console.WriteLine((int)val2);
            //Console.WriteLine((int)val3);
            //Console.WriteLine((int)val4);
            //Console.WriteLine((int)val5);
            //Console.WriteLine((int)val6);
            //Console.WriteLine((int)val7);
            //Console.WriteLine((int)val8);
            //Console.WriteLine((int)val9);
            //Console.WriteLine((int)val10);

            //2.3
            //float k, M;
            //Console.WriteLine("Poid d'un colis : ");
            //k = float.Parse(Console.ReadLine());
            //Console.WriteLine("Capacité du camion : ");
            //M = float.Parse(Console.ReadLine());
            //Console.WriteLine("Il est possible de mettre " + Math.Floor(M / k) + " carton(s) dans le camion !");

            //2.4
            //float somme;
            //Console.WriteLine("Entrer une somme ( 0 - 0,99 ) : ");
            //somme = float.Parse(Console.ReadLine());
            //Console.WriteLine(somme);




            //3
            //3.1
            //int age = 0;
            //Console.WriteLine("Votre age : ");
            //age = int.Parse(Console.ReadLine());
            //if (age >= 18)
            //{
            //    Console.WriteLine("Tu es majeur !");
            //    Console.Read();
            //}else
            //{
            //    Console.WriteLine("Tu es mineur !");
            //    Console.Read();
            //}

            //3.2

            //3.3

            //double note = 0;
            //Console.WriteLine("Entrez votre note : ");
            //note = double.Parse(Console.ReadLine());
            //if(note < 8)
            //{
            //    Console.WriteLine("ajourné");
            //}else if(note >= 8 && note <= 10)
            //{
            //    Console.WriteLine("Rattrapage");
            //}else if(note > 10){
            //    Console.WriteLine("Admis");
            //}

            //3.4
            //double franchise = 0;
            //Console.WriteLine("Montant des dommages : ");
            //franchise = (10 * double.Parse(Console.ReadLine()) / 100);
            //if (franchise > 4000)
            //{
            //    Console.WriteLine("Votre franchise est de 4000Euros");
            //}
            //else
            //{
            //    Console.WriteLine("Votre franchise est de " + franchise + "Euro(s)");
            //}

            //3.5
            //int val1, val2, i;
            //Console.WriteLine("Valeur 1 : ");
            //val1 = int.Parse(Console.ReadLine());       
            //Console.WriteLine("Valeur 2 : ");
            //val2 = int.Parse(Console.ReadLine());

            //do
            //{
            //    Console.WriteLine(val1++);
            //} while (val1 != val2);  

            //3.7
            //int a, b;
            //char op;
            //Console.WriteLine("Saisisez la valeur a : ");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Saisisez la valeur b : ");
            //b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Saisisez l'opérateur de calcul");
            //op = char.Parse(Console.ReadLine());
            //switch (op)
            //{
            //    case '-':
            //        Console.WriteLine(a - b);
            //        break;
            //    case '+':
            //        Console.WriteLine(a + b);
            //        break;
            //    case '*':
            //        Console.WriteLine(a * b);
            //        break;
            //    case '/':
            //        Console.WriteLine(a / b);
            //        break;
            //}

            //3.8
            //int i, j;
            //string color;
            //Console.WriteLine("Entrez la position i : ");
            //i = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entrez la position j : ");
            //j = int.Parse(Console.ReadLine());
            //if (i > 8 && j > 8 && i < 0 && j < 8)
            //{
            //    Console.WriteLine("Valeur incorrecte");
            //}

            //if ((i + j) % 2 == 0)
            //{
            //    color = "NOIR";
            //}
            //else
            //{
            //    color = "BLANCHE";
            //}

            //Console.WriteLine("La couleur de la case est : " + color);


            //3.9
            //int i, j, k, l;
            //Console.WriteLine("Entrez la position i : ");
            //i = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entrez la position j : ");
            //j = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entrez la position k : ");
            //k = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entrez la position l : ");
            //l = int.Parse(Console.ReadLine());

            //if ((i + 2 == k && j + 1 == l) || (i - 2 == k && j - 1 == l) || (i + 2 == k && j - 1 == l) || (i - 2 == k && j + 1 == l) || (i + 1 == k && j + 2 == l) || (i - 1 == k && j - 2 == l) || (i + 1 == k && j - 2 == l) || (i - 1 == k && j + 2 == l))
            //{
            //    Console.WriteLine("Deplacement possible !");
            //}
            //else
            //{
            //    Console.WriteLine("Va chier tu sais pas jouer, connard !");
            //}


            //3.10
            //int i, j, k, l;
            //Console.WriteLine("Entrez la position i : ");
            //i = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entrez la position j : ");
            //j = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entrez la position k : ");
            //k = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entrez la position l : ");
            //l = int.Parse(Console.ReadLine());

            //if ((i + 2 == k && j + 1 == l) || (i - 2 == k && j - 1 == l) || (i + 2 == k && j - 1 == l) || (i - 2 == k && j + 1 == l) || (i + 1 == k && j + 2 == l) || (i - 1 == k && j - 2 == l) || (i + 1 == k && j - 2 == l) || (i - 1 == k && j + 2 == l))
            //{
            //    Console.WriteLine("Deplacement possible !");
            //}
            //else
            //{
            //    Console.WriteLine("tu sais pas jouer !");
            //}


            //int piece, i1, i2, j1, j2;
            //bool etat = false;
            //string[] nomPiece = new string[5] { "du Cavalier", "de la Tour", "du Fou", "de la Dame", "du Roi" };
            //Console.WriteLine("Quelle piece souhaitez-vous deplacer ? :" +  // Présentation by Pierrot |/!\| Utilisation INTERDITE |/!\|
            //                  "\n**************************************" +
            //                  "\n0 = Cavalier " +
            //                  "\n1 = Tour" +
            //                  "\n2 = Fou" +
            //                  "\n3 = Dame" +
            //                  "\n4 = Roi" +
            //                  "\n**************************************");
            //piece = int.Parse(Console.ReadLine());
            //Console.WriteLine("Coordonnées (i,j) de la position de départ :");
            //Console.Write("i = ");
            //i1 = int.Parse(Console.ReadLine());
            //Console.Write("j = ");
            //j1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Coordonnées (i',j') de la position d'arrivée :");
            //Console.Write("i' = ");
            //i2 = int.Parse(Console.ReadLine());
            //Console.Write("j' = ");
            //j2 = int.Parse(Console.ReadLine());
            //switch (piece)
            //{
            //    case 0: // Cavalier
            //        etat = Math.Abs(i1 - i2) == 2 && Math.Abs(j1 - j2) == 1 || Math.Abs(i1 - i2) == 1 && Math.Abs(j1 - j2) == 2 ? true : false;
            //        break;
            //    case 1: // Tour
            //        etat = i1 == i2 || j1 == j2 ? true : false;
            //        break;
            //    case 2: // Fou
            //        etat = Math.Abs(i1 - i2) == Math.Abs(j1 - j2) ? true : false;
            //        break;
            //    case 3: // Dame
            //        etat = i1 == i2 || j1 == j2 || Math.Abs(i1 - i2) == Math.Abs(j1 - j2) ? true : false;
            //        break;
            //    case 4: // Roi
            //        etat = Math.Abs(i1 - i2) < 2 && Math.Abs(j1 - j2) < 2 ? true : false;
            //        break;
            //    default:
            //        break;
            //}
            //Console.WriteLine("Le deplacement " + nomPiece[piece] + " est " + (etat != true ? "impossible" : "possible"));

            //int a = 1, b = 0, n = 5;
            //while (a <= n)
            //    b += a++;
            //Console.WriteLine(a + " , " + b);

            //6, 15

            //int a = 0, b = 0, c = 0, d = 3, m = 3, n = 4;
            //for (a = 0; a < m; a++)
            //{
            //    d = 0;
            //    for (b = 0; b < n; b++)
            //        d += b;
            //    c += d;
            //}
            //Console.WriteLine(a + " , " + b + " , " + c + " , " + d + " . ");

            //3,4,18,6.

            //int a, b, c, d;
            //a = 1; b = 2;
            //c = a / b;
            //d = (a == b) ? 3 : 4;
            //Console.WriteLine(c + " , " + d + " . ");
            //a = ++b;
            //b %= 3;
            //Console.WriteLine(a + " , " + b + " . ");
            //b = 1;
            //for (a = 0; a <= 10; a++)
            //    c = ++b;
            //Console.WriteLine(a + " , " + b + " , " + c + " , " + d + " . ");


            //int val, i;
            //Console.WriteLine("Entrez une valeur :");
            //val = int.Parse(Console.ReadLine());

            //do
            //{
            //    i = val - 1;
            //    Console.WriteLine(i);

            //} while (i == 0);

            //int h1, m1, h2, m2;
            //string temp;
            //Console.WriteLine("heure de debut : hh-mm");

            //temp = Console.ReadLine();
            //h1 = int.Parse(temp.Substring(0, 2));
            //m1 = int.Parse(temp.Substring(3, 4));

            //Console.WriteLine(h1 + m1);
            //Console.WriteLine("heure de fin : hh-mm");


            //Table de multiplication
            //int nb;
            //int i = 0;
            //Console.WriteLine("Nombre :");
            //nb = int.Parse(Console.ReadLine());
            //Console.WriteLine("********Table de " + nb + "********");
            //do
            //{
            //    i++;
            //    Console.WriteLine(nb + " x " + i + " = " + (nb * i));
            //} while (i< 10);

            //Joli carré
            //int nb;
            //int i = 0;
            //int j = 0;
            //string a = "";
            //string val;
            //Console.WriteLine("Nombre :");
            //val = Console.ReadLine();
            //nb = int.Parse(val);
            //do
            //{
            //    j++;
            //    a += " " + val;
            //} while (j < nb);
            //do
            //{
            //    i++;
            //    Console.WriteLine(a);
            //} while (i < nb);

        }
    }
}