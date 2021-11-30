using System;
using System.Collections.Generic;

#nullable disable

namespace GestionAeroport.Data.Models
{
    public partial class Trajet
    {
        public Trajet()
        {
            Vols = new HashSet<Vol>();
        }

        public int IdTrajet { get; set; }
        public string AeroportArrivee { get; set; }
        public string AeroportDepart { get; set; }
        public TimeSpan DureeVol { get; set; }

        public virtual ICollection<Vol> Vols { get; set; }
    }
}
