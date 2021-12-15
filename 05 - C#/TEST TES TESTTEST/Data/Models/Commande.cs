using System;
using System.Collections.Generic;

#nullable disable

namespace TEST_TES_TESTTEST.Data.Models
{
    public partial class Commande
    {
        public Commande()
        {
            Preparations = new HashSet<Preparation>();
        }

        public int IdCommande { get; set; }
        public DateTime DateCommande { get; set; }
        public int NumeroCommande { get; set; }

        public virtual ICollection<Preparation> Preparations { get; set; }
    }
}
