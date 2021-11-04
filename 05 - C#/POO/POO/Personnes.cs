using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    class Personnes
    {

        //Attributs
        public string nom;
        public string prenom;
        public int age;
        public string email;

        //Constructeurs
        public Personnes()
        {
        
        }
        public Personnes(string nom, string prenom, int age, string email)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.email = email;
        } 
        
        //Accesseurs
        public string GetNom()
        {
            return this.nom;
        }
        public string SetNom()
        {
            return this.nom;
        }
        public string GetPrenom()
        {
            return this.prenom;
        }
        public string SetPrenom()
        {
            return this.prenom;
        }
        public int GetAge()
        {
            return this.age;
        }
        public int SetAge()
        {
            return this.age;
        }
        public string GetEmail()
        {
            return this.email;
        }
        public string SetEmail()
        {
            return this.email;
        }

        //ToString
        public override string ToString()
        {
            return "nom " + this.nom + " prenom " + this.prenom + " age " + this.age + " email " + this.email;
        }
    }
}
