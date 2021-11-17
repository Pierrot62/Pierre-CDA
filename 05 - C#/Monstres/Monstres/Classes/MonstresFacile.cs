using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstres
{
    class MonstresFacile
    {
        public bool EstVivant { get; set; }


        public MonstresFacile()
        {
            EstVivant = true;
        }

        public int Attaque()
        {
            int nbJ = Des.LanceLeDe();
            int nbM = Des.LanceLeDe();
            if (nbJ < nbM)
            {
                return 10;
            }
            return 0;
        }
    }
}
