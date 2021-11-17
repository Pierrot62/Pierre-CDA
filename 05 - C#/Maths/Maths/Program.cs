using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangles r1 = new Rectangles(14, 14);
            r1.AfficherRectangle();

            TriangleRectangles tr1 = new TriangleRectangles(12, 45);
            tr1.AfficherRectangle();

            Cercles c1 = new Cercles(54);
            c1.AfficherCercle();
        }
    }
}
