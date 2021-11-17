using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstres
{
    class Joueurs
    {
        public int PointsDeVie { get; private set; }

        public Joueurs()
        {
            PointsDeVie = 50;
        }

        public bool EstVivant()
        {
            return this.PointsDeVie > 0 ? true : false;
        }

        public bool Attaque(MonstresFacile Monstres)
        {
            int nbJ = Des.LanceLeDe();
            int nbM = Des.LanceLeDe();
            if (nbJ >= nbM)
            {
                Monstres.EstVivant = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SubitDegats(int valDegats)
        {
            if (Des.LanceLeDe() > 2)
            {
                this.PointsDeVie -= valDegats;
                return true;
            }
            return false;
        }

    }
}
