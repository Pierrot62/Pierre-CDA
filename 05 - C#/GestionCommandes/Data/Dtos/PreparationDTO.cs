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
        public ICollection<ProduitDTOIn> Produit { get; set; }
    }
    public class PreparationDTOIn
    {
        public int IdProduit { get; set; }
        public int IdCommande { get; set; }
        public DateTime DatePreparation { get; set; }

    }
}
