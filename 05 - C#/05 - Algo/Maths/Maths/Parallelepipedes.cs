using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    class Parallelepipedes : Rectangles
    {
        public double Profondeur { get; set; }

        public Parallelepipedes(double largeur, double longueur,double profondeur) : base(largeur, longueur)
        {
            Profondeur = profondeur;
        }

        public override double Perimetre()
        {
            return (this.Longueur + this.Largeur + this.Profondeur) * 2;
        }


        public double Volume()
        {
            return this.Longueur * this.Largeur * this.Profondeur;
        }

        public override string ToString()
        {
            return base.ToString() + " - Profondeur : " + this.Profondeur + " - Volume : " + this.Volume();
        }

    }


}
