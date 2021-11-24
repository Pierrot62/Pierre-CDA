using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstres
{
    class Des
    {
        private static Random num = new Random();

        public static int LanceLeDe()
        {
            return num.Next(1,7);
        }
    }
}
