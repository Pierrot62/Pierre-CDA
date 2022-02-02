using System;
using System.Collections.Generic;

#nullable disable

namespace ProjetAutomate.Data.Models
{
    public partial class Afpa_Anomalie
    {
        public int IdAnomalie { get; set; }
        public DateTime? DateAnomalie { get; set; }
        public string TypeAnomalie { get; set; }
        public int? NbDeclasses { get; set; }
        public int IdErreur { get; set; }

        public virtual Afpa_Erreur Erreur { get; set; }
    }
}
