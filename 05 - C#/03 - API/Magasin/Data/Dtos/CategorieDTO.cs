using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Magasin.Data.Dtos
{
    public class CategorieDTO
    {

        public int IdCategorie { get; set; }

        public string LibelleCategorie { get; set; }
    }
}
