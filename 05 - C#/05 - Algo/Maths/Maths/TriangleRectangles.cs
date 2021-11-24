using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    class TriangleRectangles
    {
        public double Bas { get; set; }
        public double Hauteur { get; set; }

        public TriangleRectangles(double bas, double hauteur)
        {
            Bas = bas;
            Hauteur = hauteur;
        }

        public double Perimetre()
        {
            return this.Hauteur + this.Bas + Math.Sqrt(Math.Pow(this.Hauteur, this.Hauteur) + Math.Pow(this.Bas, this.Bas));
        }

        public double Aire()
        {
            return (this.Hauteur * this.Bas) / 2;
        }

        public void AfficherRectangle()
        {
            Console.WriteLine("Bas : " + this.Bas + " - Hauteur : " + this.Hauteur + " - Perimetre : " + this.Perimetre() + " - Aire : " + this.Aire());
        }
    }
}
