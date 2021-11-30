using System;
using System.Collections.Generic;

#nullable disable

namespace TEST_TES_TESTTEST.Data.Models
{
    public partial class Produit
    {
        public Produit()
        {
            Preparations = new HashSet<Preparation>();
        }

        public int IdProduit { get; set; }
        public string LibelleProduit { get; set; }
        public decimal PrixProduit { get; set; }
        public int QuantiteProduit { get; set; }

        public virtual ICollection<Preparation> Preparations { get; set; }
    }
}
