using System;
using System.Collections.Generic;

#nullable disable

namespace GestionAeroport.Data.Models
{
    public partial class Avion
    {
        public Avion()
        {
            Vols = new HashSet<Vol>();
        }

        public int IdAvion { get; set; }
        public string Compagnie { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Vol> Vols { get; set; }
    }
}
