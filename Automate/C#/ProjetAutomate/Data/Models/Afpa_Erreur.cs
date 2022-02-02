using System;
using System.Collections.Generic;

#nullable disable

namespace ProjetAutomate.Data.Models
{
    public partial class Afpa_Erreur
    {
        public Afpa_Erreur()
        {
            AfpaAnomalies = new HashSet<Afpa_Anomalie>();
        }

        public int IdErreur { get; set; }
        public string MessageErreur { get; set; }

        public virtual ICollection<Afpa_Anomalie> AfpaAnomalies { get; set; }
    }
}
