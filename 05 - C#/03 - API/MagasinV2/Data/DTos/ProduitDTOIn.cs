using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magasin.Data.Dtos
{
    public class ProduitDTOIn
    {
        public string LibelleProduit { get; set; }
        public float PrixProduit { get; set; }
        public int QuantiteProduit { get; set; }
        public int IdCategorie { get; set; }
    }
}
