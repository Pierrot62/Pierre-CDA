using ProjetAutomate.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAutomate.Data.Dtos
{
    public class Afpa_AnomaliesDTOIn
    {
        public DateTime? DateAnomalie { get; set; }
        public string TypeAnomalie { get; set; }
        public int IdErreur { get; set; }
    }

    public class Afpa_AnomaliesDTOOut
    {
        public DateTime? DateAnomalie { get; set; }
        public string TypeAnomalie { get; set; }
        public string Erreur { get; set; }
    }
}
