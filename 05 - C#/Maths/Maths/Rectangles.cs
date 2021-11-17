using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    class Rectangles
    {
        public double Longueur { get; set; }
        public double Largeur { get; set; }

        public Rectangles(double longueur, double largeur)
        {
            Longueur = longueur;
            Largeur = largeur;
        }

        public virtual double Perimetre()
        {
            return (this.Longueur * this.Largeur) * 2;
        }

        public double Aire()
        {
            return this.Longueur * this.Largeur;
        }

        public bool EstCarre()
        {
            return this.Longueur == this.Largeur ? true : false;
        }

        public string AfficherRectangle()
        {
            string carre = EstCarre() == true ? "Il s\'agit d\'un carré" : "Il ne s\'agit pas d\'un carré";
            return "Longueur : " + this.Longueur + " - Largeur : " + this.Largeur + " - Périmètre : " + this.Perimetre() + " - Aire : " + this.Aire() + " - " + carre;
        }
    }
}
