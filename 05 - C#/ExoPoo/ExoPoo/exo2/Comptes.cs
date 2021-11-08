using System;
using System.Collections.Generic;
using System.Text;

namespace ExoPoo.Exo2
{
    class Comptes
    {
        public double Solde { get; private set; }
        public int Numero { get;}
        public int Code { get;}
        public Clients Titulaire { get;}

        public Comptes(double solde, int code, Clients titulaire)
        {
            Solde = solde;
            Code = code;
            Titulaire = titulaire;
            Numero ++;
        }

        public void Crediter(double somme)
        {
            this.Solde += somme;
        }

        public void Crediter(double somme, Comptes cpt)
        {
            this.Crediter(somme);
            cpt.Solde -= somme;
        }
        
        public void Debiter(double somme)
        {
            this.Solde -= somme;
        }

        public void Debiter(double somme, Comptes cpt)
        {
            this.Debiter(somme);
            cpt.Solde += somme;
        }

        public override string ToString()
        {
            return "Informations pour le compte n° " + this.Numero + "\nSolde : " + this.Solde + "\nCode : " + Code;
        }
    }
}
