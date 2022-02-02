using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAutomate.Data.Dtos
{
    public class Afpa_CadencesDTOOut
    {
        public int? NbProduit { get; set; }
        public DateTime? DateCadence { get; set; }
    }

    public class Afpa_CadencesDTOIn
    {
        public int? NbProduit { get; set; }
        public DateTime? DateCadence { get; set; }
    }
}
