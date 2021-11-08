using System;
using System.Collections.Generic;
using System.Text;

namespace ExoPoo.Exo1
{
    class Voitures
    {
        //Proprietes
        public string Couleur { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
        public int NbKilometres { get; set; }
        public string Motorisation { get; set; }


        //Constructeur
        public Voitures(string couleur, string marque, string modele, int nbKilometres, string motorisation)
        {
            Couleur = couleur;
            Marque = marque;
            Modele = modele;
            NbKilometres = nbKilometres;
            Motorisation = motorisation;
        }

        public Voitures(string marque, string modele)
        {
            Marque = marque;
            Modele = modele;
        }

        //ToString
        public override string ToString()
        {
            return "Cette voiture est une " + this.Modele + " de la marque " + this.Marque + " , de couleur " + this.Couleur + " , de motorisation " + this.Motorisation + ", avec " + this.NbKilometres + " Kilomètres";
        }

        //Rouler

        public int Rouler(int nbKlm)
        {
            this.NbKilometres += nbKlm;
            return NbKilometres;
        }
    }
}
