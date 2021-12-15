using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelToBase.Data
{
    public class Fromage
    {
        [Key]
        public int idFromage { get; set; }

        public string nomFromage { get; set; }
        public double prixFromage { get; set; }
    }
}
