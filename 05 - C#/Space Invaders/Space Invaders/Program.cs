using System;
using Space_Invaders.Classes;

namespace Space_Invaders
{
    class Program
    {
        static void Main(string[] args)
        {   
            Invader invader = new Invader('#');
            Space grille = new Space(2, 10);
            Space.AjouterInvader(invader.Caractere);
            //grille.AfficheGrille();
        }
    }
}
