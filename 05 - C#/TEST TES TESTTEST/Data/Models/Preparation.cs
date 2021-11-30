using System;
using System.Collections.Generic;

#nullable disable

namespace TEST_TES_TESTTEST.Data.Models
{
    public partial class Preparation
    {
        public int IdPreparation { get; set; }
        public int IdProduit { get; set; }
        public int IdCommande { get; set; }
        public DateTime DatePreparation { get; set; }

        public virtual Commande IdCommandeNavigation { get; set; }
        public virtual Produit IdProduitNavigation { get; set; }
    }
}
