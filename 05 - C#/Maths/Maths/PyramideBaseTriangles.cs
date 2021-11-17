using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    class PyramideBaseTriangles : TriangleRectangles
    {
        public double Profondeur { get; set; }

        public PyramideBaseTriangles(double profondeur, double bas, double longueur) : base(bas, longueur)
        {
            Profondeur = profondeur;
        }

        public double Perimetre()
        {
            //return (this.Longueur + this.Largeur + this.Profondeur) * 2;
        }

        public override string ToString()
        {
            return base.ToString() + " - Profondeur : " + this.Profondeur + " - Perimetre : " + this.;
        }
    }
}
