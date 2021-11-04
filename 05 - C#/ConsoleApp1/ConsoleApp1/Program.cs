using System;
using System.Text;

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


            //Rectangle
            //string xHautGauche, yHautGauche, xBasDroite, yBasDroite;
            //int xGauche, yHaut, xDroite, yBas;

            //Console.Write("Entrez la valeur de xHautGauche : ");
            //xHautGauche = Console.ReadLine();

            //Console.Write("Entrez la valeur de yHautGauche : ");
            //yHautGauche = Console.ReadLine();

            //Console.Write("Entrez la valeur de xBasDroite : ");
            //xBasDroite = Console.ReadLine();

            //Console.Write("Entrez la valeur de yBasDroite : ");
            //yBasDroite = Console.ReadLine();

            //Console.Write("Entrez la valeur de yBasDroite : ");
            //yBasDroite = Console.ReadLine();

            //Console.Write("Entrez la valeur de yBasDroite : ");
            //yBasDroite = Console.ReadLine();

            //if (int.TryParse(xHautGauche, out xGauche) && int.TryParse(yHautGauche, out yHaut) && int.TryParse(xBasDroite, out xDroite) && int.TryParse(yBasDroite, out yBas))
            //{
            //    if (xDroite > xGauche && yHaut > yBas)
            //    {
            //        Console.WriteLine(" Le rectangle est correct.");
            //    }
            //    else
            //    {
            //        Console.WriteLine(" Le rectangle est incorrect.");
            //    }
            //}

            //LES BOUCLES


            //Heures
            //int h1, m1, h2, m2;
            //string temp;
            //Console.WriteLine("heure de debut : hh-mm");

            //temp = Console.ReadLine();
            //h1 = int.Parse(temp.Substring(0, 2));
            //m1 = int.Parse(temp.Substring(3, 4));

            //Console.WriteLine(h1 + m1);
            //Console.WriteLine("heure de fin : hh-mm");

            //4.1
            // int a = 1, b = 0, n = 5;
            // while (a <= n)
            //    b += a++;
            // Console.WriteLine(a + " , " + b);

            //6, 15


            //4.2
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


            //4.3
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


            // 4.2.4
            //compte a rebours
            //int val, i;
            //Console.WriteLine("Entrez une valeur :");
            //val = int.Parse(Console.ReadLine());
            //do
            //{
            //    i = val - 1;
            //    Console.WriteLine(i);
            //    val--;

            //} while (i > 0);




            //4.3.6 Table de multiplication
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



            ////4.3.7
            //Console.WriteLine("  ");
            //for (int i = 1; i <= 10 ; i++)
            //{
            //    Console.Write("   " + i);
            //}
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine();
            //    Console.Write(i);
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.Write("  " + i * j);
            //    }
            //}


            //4.8
            //Joli carré
            // int nb;
            // int i = 0;
            // int j = 0;
            // string a = "";
            // string val;
            // Console.WriteLine("Nombre :");
            // val = Console.ReadLine();
            // nb = int.Parse(val);
            // do
            // {
            //    j++;
            //    a += " " + val;
            // } while (j < nb);
            // do
            // {
            //    i++;
            //    Console.WriteLine(a);
            // } while (i < nb);

            //4.8 Puissance

            //int n, b;
            //double p;
            //Console.WriteLine("Entrez la valeur 1 : ");
            //b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entrez la valeur 2 : ");
            //n = int.Parse(Console.ReadLine());

            //if (n >= 0 )
            //{
            //   p = Math.Pow( b, n);
            //    Console.WriteLine(p);
            //}


            // Calculette


            //double nb, nb2;
            //int nb3;
            //bool val;
            //char op;
            //double result;
            //bool flag;
            //bool flagKey;

            //flag = true;
            //flagKey = false;
            //result = 0;
            //nb = 0;
            //nb2 = 0;
            //nb3 = 0;
            //val = false;

            //do
            //{

            //    if (flag)
            //    {
            //        Console.Write("Entrez une valeur : ");
            //        val = double.TryParse(Console.ReadLine(), out nb);
            //        flag = false;
            //    }

            //    if (val || !flag)
            //    {
            //        Console.Write("Entrez un opérateur : ");
            //        val = char.TryParse(Console.ReadLine(), out op);
            //        if (val)
            //        {
            //            if (op != '!' && op != '?')
            //            {
            //                if (op != '$')
            //                {
            //                    Console.Write("Entrez une valeur : ");
            //                    val = double.TryParse(Console.ReadLine(), out nb2);
            //                }
            //                else
            //                {
            //                    do
            //                    {
            //                        Console.Write("Entrez une valeur entière : ");
            //                        val = int.TryParse(Console.ReadLine(), out nb3);
            //                    } while (!val);

            //                }
            //            }
            //            switch (op)
            //            {
            //                case '+':
            //                    result = nb + nb2;
            //                    break;
            //                case '-':
            //                    result = nb - nb2;
            //                    break;
            //                case '/':
            //                    result = nb / nb2;
            //                    break;
            //                case '*':
            //                    result = nb * nb2;
            //                    break;

            //                case '$':
            //                    result = Math.Pow(nb, nb3);
            //                    break;

            //                case '!':
            //                    result = Math.Sqrt(nb);
            //                    break;
            //                case '?':
            //                    result = nb;
            //                    for (int i = 1; i < nb; i++)
            //                    {
            //                        result *= i;
            //                    }
            //                    break;

            //                default:
            //                    val = false;
            //                    break;
            //            }

            //            if (val)
            //            {
            //                Console.WriteLine(" = " + result);

            //                if (!flag)
            //                {
            //                    nb = result;
            //                    val = true;
            //                }
            //            }
            //        }
            //    }

            //    if (val)
            //    {
            //        Console.WriteLine("Arrêter le calcul ? Press Enter");
            //        if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            //        {
            //            flagKey = true;
            //        }
            //    }


            //} while (!val || !flagKey);

            //Console.Write("Le résultat final est : " + result);

            //static int demanderEntierPositif()
            //{
            //    int nb;
            //    bool ok;
            //    do
            //    {
            //        Console.Write("Entrez un entier positif : ");
            //        ok = int.TryParse(Console.ReadLine(), out nb);
            //    } while (nb <= 0 || !ok);
            //     return nb;
            //}

            //static double demanderDouble()
            //{
            //    double nb;
            //    bool ok;
            //    do
            //    {
            //        Console.Write("Entrez une valeur : ");
            //        ok = double.TryParse(Console.ReadLine(), out nb);
            //    } while (!ok);
            //    return nb;
            //}

            //static double demanderDoubleNonNull()
            //{
            //    double nb;
            //    bool ok;
            //    do
            //    {
            //        Console.Write("Entrez un double : ");
            //        ok = double.TryParse(Console.ReadLine(), out nb);
            //    } while (nb <= 0 || !ok);
            //    return nb;
            //}

            //static char demanderOperateur()
            //{
            //    char op;
            //    do
            //    {
            //        Console.WriteLine("Entrez un operateur : ");
            //        char.TryParse(Console.ReadLine(), out op);
            //    } while (op != '+' && op != '-' && op != '*' && op != '/' && op != '$' && op != '!' && op != 'V');
            //    return op;
            //}

            //static double calculSimple(double valeur1, char operateur, double valeur2)
            //{
            //    double resultat = 0;
            //    switch (operateur)
            //    {
            //        case '+':
            //            resultat = valeur1 + valeur2;
            //            break;
            //        case '-':
            //            resultat = valeur1 - valeur2;
            //            break;
            //        case '*':
            //            resultat = valeur1 * valeur2;
            //            break;
            //        case '/':
            //            if (valeur2 != 0)
            //            { 
            //                resultat = valeur1 / valeur2;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Calcul impossible");
            //            }
            //            break;
            //        case '$':
            //            resultat = Math.Round(valeur1);
            //            resultat = Math.Pow(valeur1, valeur2);
            //            break;
            //        default:
            //            break;
            //    }
            //    return resultat;
            //}


            //static double Calcul(double valeur, char operateur)
            //{
            //    double result = 1;

            //    switch (operateur)
            //    {
            //        case 'V':
            //            result = Math.Sqrt(valeur);
            //            break;

            //        case '!':
            //            for (int i = 1; i < valeur; i++)
            //            {
            //                result *= i;
            //            }
            //            break;
            //    }
            //    return result;
            //}

            //double value1, value2;
            //char operateur;

            //value1 = demanderDouble();
            //do
            //{
            //    operateur = demanderOperateur();
            //    switch (operateur)
            //    {
            //        case '-':
            //        case '+':
            //        case '*':
            //            value2 = demanderDouble();
            //            value1 = calculSimple(value1, value2, operateur);
            //            break;
            //        case '/':
            //            value2 = demanderDoubleNonNull();
            //            value1 = calculSimple(value1, value2, operateur);
            //            break;
            //        case '$':
            //            value2 = demanderEntierPositif();
            //            value1 = calculSimple(value1, value2, operateur);
            //            break;
            //        case '!':
            //            if (value1 % 1 == 0 && value1 > 0) // On vérifie que value1 est un Entier et qu'il est positif.
            //            {
            //                value1 = calcul(value1, operateur);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Calcul impossible !");
            //            }
            //            break;
            //        case 'V':
            //            if (value1 > 0) // On vérifie que value1 est positif.
            //            {
            //                value1 = calcul(value1, operateur);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Calcul impossible !");
            //            }
            //            break;
            //        case '=':
            //            break;
            //        default:
            //            Console.WriteLine("Opérateur incorrect.");
            //            break;
            //    }

            //    Console.WriteLine("Résultat = " + value1);
            //    if (operateur == '=')
            //    {
            //        Console.WriteLine("Merci d'avoir utiliser cette calculatrice made in AFPA.");
            //    }
            //} while (operateur != '=');






            //5 Chaînes de caractères

            //5.1
            //string chaine = "Les framboises sont perchées sur le tabouret de mon grand-père.";
            //for (int i = 0; i < chaine.Length; i++)
            //{
            //    Console.WriteLine(chaine[i]);
            //}

            //5.2
            //string t, t2;
            //t2 = "";
            //int ind1, ind2;
            //Console.WriteLine("Entrez une chaine de caractere : ");
            //t = Console.ReadLine();
            //Console.WriteLine("Entrez le premier indice : ");
            //ind1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entrez le second indice : ");
            //ind2 = int.Parse(Console.ReadLine());
            //for (int i = ind1; i < ind2; i++)
            //{
            //    t2 = t2 + t[i];
            //}
            //Console.WriteLine(t);
            //Console.WriteLine(t2);

            //5.3
            //string t, t2;
            //t2 = "";
            //int ind1, ind2;
            //Console.WriteLine("Entrez une chaine de caractere : ");
            //t = Console.ReadLine();
            //Console.WriteLine("Entrez le premier indice : ");
            //ind1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entrez le second indice : ");
            //ind2 = int.Parse(Console.ReadLine());
            //for (int i = ind1; i < ind2; i++)
            //{
            //    t2 = t2 + t[i];
            //}
            //Console.WriteLine(t);
            //Console.WriteLine(t.Insert(t.Length," " + t2));

            //5.4
            //string chaine, a, b;
            //Console.Write("Entrez une chaine de caractere : ");
            //chaine = Console.ReadLine();
            //Console.Write("Entrez la premiere lettre : ");
            //a = Console.ReadLine();
            //Console.Write("Entrez la seconde lettre : ");
            //b = Console.ReadLine();
            //Console.WriteLine(chaine.Replace(a, b));

            //5.5
            //string chaine;
            //char a, b;
            //Console.Write("Entrez une chaine de caractere : ");
            //chaine = Console.ReadLine();
            //StringBuilder sb = new StringBuilder(chaine);
            //Console.Write("Entrez la premiere lettre : ");
            //a = char.Parse(Console.ReadLine());
            //Console.Write("Entrez la seconde lettre : ");
            //b = char.Parse(Console.ReadLine());
            //for (int i = 0; i < sb.Length; i++)
            //{
            //    if (sb[i] == a)
            //    {
            //        sb[i] = b;
            //    }
            //}
            //Console.WriteLine(sb);

            //5.6
            //string nomFichier;
            //Console.Write("Entrez le nom du fichier : ");
            //nomFichier = Console.ReadLine();
            //Console.WriteLine("Le nom du fichier est : '" + nomFichier.Substring(0, nomFichier.IndexOf(".")) + "' et son extention est : '" + nomFichier.Substring(nomFichier.LastIndexOf(".")) + "'");

            //5.7
            //string chaine = "3 + 4, ((3 − 2) + (7/3)))";
            //int cpt = 0;
            //for (int i = 0; i < chaine.Length; i++)
            //{
            //    if (chaine[i] == '(')
            //    {
            //        cpt++;
            //    }
            //    else if (chaine[i] == ')')
            //    {
            //        cpt--;
            //    }
            //}
            //if (cpt == 0)
            //{
            //    Console.WriteLine("La chaine est correct");
            //}
            //else
            //{
            //    Console.WriteLine("La chaine n'est pas correct");
            //}


            //6 LES TABLEAUX

            //6.2.4
            //int[] tab = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //for (int i = 0; i < tab.Length; i++)
            //{
            //    Console.WriteLine(tab[i]);
            //}

            //6.2.5
            //int[] tab = new int[10];
            //for (int i = 0; i < tab.Length; i++)
            //{
            //    tab[i] = i + 1;
            //    Console.WriteLine("valeur : " + tab[i]);
            //}

            //6.2.6
            //int somme = 0;
            //int[] tab = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //for (int i = 0; i < tab.Length; i++)
            //{
            //    somme += tab[i];
            //}
            //Console.WriteLine("la somme du tableau et des : " + somme);

            //6.2.7
            //int indice;
            //bool inTab = false;
            //int[] tab = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine("Entrez un chiffre afin de savoir si il est dans le tableau");
            //indice = int.Parse(Console.ReadLine());
            //for (int i = 0; i < tab.Length; i++)
            //{
            //    if (tab[i] == indice)
            //    {
            //        inTab = true;
            //    }
            //}
            //if (inTab == true)
            //{
            //    Console.WriteLine("C'EST UN OUI !");
            //}
            //else
            //{
            //    Console.WriteLine("C'EST UN NON !");
            //}

            //6.2.8
            //int[] tableau = new int[10];
            //int[] tableauCirculezYaRienAVoir = new int[10];
            //for (int i = 0; i < tableau.Length; i++)
            //    tableau[i] = i + 1;
            //for (int i = 0; i < tableau.Length; i++)
            //    tableauCirculezYaRienAVoir[(i + 1) % tableau.Length] = tableau[i];
            //foreach (int p in tableauCirculezYaRienAVoir)
            //    Console.WriteLine(p);


            //6.2.9

            //6.2.10
            //int temp;
            //int[] tab = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //for (int i = 0; i < tab.Length; i++)
            //{
            //    temp = tab[i];

            //}

            //6.2.11
            //int temp;
            //int[] tab = new int[20] { 1, 0, 2, 0, 3, 0, 4, 0, 5, 0, 6, 0, 7, 0, 8, 0, 9, 0, 10, 0 };
            //for (int i = 0; i < tab.Length -1; i++)
            //{

            //    temp = tab[i + 1] % 17;
            //    tab[i] = temp;
            //    Console.WriteLine(tab[i]);
            //}

            //6.2.12
            //int min = 0, max = 0;
            //int[] tab = new int[10] { 1, 58, 7, 4, 5, 6, 0, 8, 3, 10 };
            //min = tab[0];
            //max = tab[0];
            //for (int i = 0; i < tab.Length; i++)
            //{

            //    if (tab[i] > max)
            //    {
            //        max = tab[i];
            //    }
            //    else if (tab[i] < min)
            //    {
            //        min = tab[i];
            //    }
            //}
            //Console.WriteLine("La valeur la plus petite est " + min + " et la plus grande est " + max);


            //6.2.13
            //int[] tab = new int[10] { 1, 58, 7, 4, 5, 6, 0, 8, 3, 10 };
            //6.2.14




        }
    }
}