using System;
using System.Collections.Generic;

#nullable disable

namespace GestionAeroport.Data.Models
{
    public partial class Pilote
    {
        public Pilote()
        {
            Vols = new HashSet<Vol>();
        }

        public int IdPilote { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public virtual ICollection<Vol> Vols { get; set; }
    }
}
