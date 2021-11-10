using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Invaders.Classes
{
    class Space
    {
        public int NbLignes { get; set; }
        public int NbColonnes { get; set; }
        public char[,] Grille { get; set;} // ce serait plus facile un tableau a 2 dim de char


        public Space(int nbLignes, int nbColonnes)
        {
            NbLignes = nbLignes;
            NbColonnes = nbColonnes;
            Grille = this.CreeGrille();
        }

        public char[,] CreeGrille()
        {            
            char[,] grille = new char[NbLignes,NbColonnes];

            for (int i = 0; i < this.NbLignes; i++)
            {
                grille[i,0] = ' ';
                for (int j = 0; j < this.NbColonnes; j++)
               {
                    grille[i, j] = ' ';
               }
            }
            return grille;
        }

        public char[,] AjouterInvader(Invader cara)
        {
            for (int i = 0; i < this.NbLignes; i++)
            {
                for (int j = 0; j < this.NbColonnes; j++)
                {
                    this.Grille[i, j] = cara;
                }
            }
            return Grille;
        }

        public override string ToString()
        {
            return ;
        }
        //public string AfficheGrille()
        //{

        //}
    }
}
