using System;
using System.Collections.Generic;

#nullable disable

namespace Magasin.Data.Models
{
    public class Produit
    {
        public int IdProduit { get; set; }
        public string LibelleProduit { get; set; }
        public float PrixProduit { get; set; }
        public int QuantiteProduit { get; set; }
        public int IdCategorie { get; set; }
        public Categorie CatProduit { get; set; }

    }
}
