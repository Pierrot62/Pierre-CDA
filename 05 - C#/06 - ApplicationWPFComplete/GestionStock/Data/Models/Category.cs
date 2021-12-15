using System;
using System.Collections.Generic;

#nullable disable

namespace GestionStock.Data.Models
{
    public partial class Category
    {
        public Category()
        {
            Articles = new HashSet<Article>();
        }

        public int IdCategories { get; set; }
        public string LibelleCategorie { get; set; }
        public int IdTypesProduits { get; set; }

        public virtual TypesProduit IdTypesProduitsNavigation { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
}
