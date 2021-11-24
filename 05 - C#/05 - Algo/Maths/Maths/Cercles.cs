using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    class Cercles
    {
        public double Diametre { get; set; }

        public Cercles(double diametre)
        {
            Diametre = diametre;
        }

        public double Perimetre()
        {
            return Math.PI * this.Diametre;
        }

        public double Aire()
        {
            return Math.PI * Math.Sqrt(this.Diametre / 2);
        }

        public void AfficherCercle()
        {
            Console.WriteLine("Diametre : " + this.Diametre + " - Perimetre : " + this.Perimetre() + " - Aire : " + this.Aire());
        }
    }
}
