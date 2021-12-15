using System;
using System.Collections.Generic;

#nullable disable

namespace GestionStock.Data.Models
{
    public partial class Article
    {
        public int IdArticle { get; set; }
        public string LibelleArticle { get; set; }
        public int QuantiteStockee { get; set; }
        public int IdCategories { get; set; }

        public virtual Category IdCategoriesNavigation { get; set; }
    }
}
