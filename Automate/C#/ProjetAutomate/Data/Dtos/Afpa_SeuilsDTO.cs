using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAutomate.Data.Dtos
{
    public class Afpa_SeuilsDTOIn
    {
        public float? SeuilBas { get; set; }
        public float? SeuilHaut { get; set; }
        public DateTime? DateSeuil { get; set; }
        public int Temps { get; set; }
    }
    public class Afpa_SeuilsDTOOut
    {
        public float? SeuilBas { get; set; }
        public float? SeuilHaut { get; set; }
        public DateTime? DateSeuil { get; set; }
        public int Temps { get; set; }
    }
}
