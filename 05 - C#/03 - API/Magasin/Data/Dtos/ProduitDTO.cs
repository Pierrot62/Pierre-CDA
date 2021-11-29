using Magasin.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magasin.Data.Dtos
{
    public class ProduitDTO
    {
        public string LibelleProduit { get; set; }
        public int QuantiteProduit { get; set; }
        public float PrixProduit { get; set; }
        public int IdCategorie { get; set; }
        public Categorie CatProduit { get; set; }
    }
}
