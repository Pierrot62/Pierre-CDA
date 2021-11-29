using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Magasin.Data.Models
{
    public class Categorie
    {
        [Key]
        public int IdCategorie { get; set; }

        public string LibelleCategorie { get; set; }

        public List<Produit> ListProd { get; set; }
    }
}
