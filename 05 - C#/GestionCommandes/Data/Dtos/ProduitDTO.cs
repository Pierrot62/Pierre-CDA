using GestionCommandes.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionCommandes.Data.Dtos
{
    public class ProduitDTO
    {
        public int IdProduit { get; set; }
        public string LibelleProduit { get; set; }
        public decimal PrixProduit { get; set; }
        public int QuantiteProduit { get; set; }
    }

    public class ProduitDTOIn
    {
        public string LibelleProduit { get; set; }
        public decimal PrixProduit { get; set; }
        public int QuantiteProduit { get; set; }
    }

    public class ProduitPreparationDTO
    {
        public string LibelleProduit { get; set; }
        public decimal PrixProduit { get; set; }
        public int QuantiteProduit { get; set; }
        public ICollection<PreparationCommandeDTO> Preparations { get; set; }
    }
}
