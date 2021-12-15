using System;
using System.Collections.Generic;

#nullable disable

namespace GestionStock.Data.Models
{
    public partial class TypesProduit
    {
        public TypesProduit()
        {
            Categories = new HashSet<Category>();
        }

        public int IdTypesProduits { get; set; }
        public string LibelleTypesProduit { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}
