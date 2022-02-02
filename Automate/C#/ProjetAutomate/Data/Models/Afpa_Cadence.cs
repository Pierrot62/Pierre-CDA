using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAutomate.Data.Models
{
    public class Afpa_Cadence
    {
        public int IdCadence { get; set; }
        public int? NbProduit { get; set; }
        public DateTime? DateCadence { get; set; }
    }
}
