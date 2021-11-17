using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Monstres
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Joueurs joueur = new Joueurs();
            int degats;
            MonstresFacile monstre;
            int md = 0;
            int mf = 0;

            if (Des.LanceLeDe() <= 4)
                {
                    monstre = new MonstresFacile();
                    Console.WriteLine("C'est un Monstre facile !");
                }
                else
                {
                    monstre = new MonstresDificile();
                    Console.WriteLine("C'est un Monstre difficile !");
                }
            do
            {

                if (!monstre.EstVivant)
                {

                    if (Des.LanceLeDe() <= 4)
                    {
                        monstre = new MonstresFacile();
                        Console.WriteLine("C'est un Monstre facile !");
                    }
                    else
                    {
                        monstre = new MonstresDificile();
                        Console.WriteLine("C'est un Monstre difficile !");
                    }
                }

                if (joueur.Attaque(monstre))
                {
                    Console.WriteLine("Le Heros a tue le Monstre ! ");

                }
                else
                {
                    Console.WriteLine("Le Heros a rater sont attaque ! ");
                    degats = monstre.Attaque();
                    if (degats == 0)
                    {
                        Console.WriteLine("Le monstre a rater son coup ! ");
                    }
                    else
                    {
                        if (joueur.SubitDegats(degats))
                        {
                            Console.WriteLine("Le joueur a subit " + degats);
                        }
                        else
                        {
                            Console.WriteLine("Le joueur a bloquer le coup du Monstre");
                        }
                    }
                }

            } while (joueur.PointsDeVie > 0);
        }
    }
}
