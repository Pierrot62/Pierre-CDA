using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionCommandes.Data.Dtos
{
    public class PreparationDTO
    {
        public int IdPreparation { get; set; }
        public int IdProduit { get; set; }
        public int IdCommande { get; set; }
        public DateTime DatePreparation { get; set; }

        public CommandeDTOIn Commande { get; set; }
        public ProduitDTOIn Produit { get; set; }
    }

    public class PreparationDTOIn
    {
        public int IdProduit { get; set; }
        public int IdCommande { get; set; }
        public DateTime DatePreparation { get; set; }

    }

    public class PreparationProduitDTO
    {
        public ProduitDTOIn Produit { get; set; }

    }

    public class PreparationCommandeDTO
    {
        public CommandeDTOIn Commande { get; set; }

    }
}


