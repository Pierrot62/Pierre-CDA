using System;
using System.Collections.Generic;

#nullable disable

namespace GestionAeroport.Data.Models
{
    public partial class Vol
    {
        public int IdVol { get; set; }
        public int IdPilote { get; set; }
        public int IdTrajet { get; set; }
        public int IdAvion { get; set; }
        public DateTime DateVol { get; set; }

        public virtual Avion IdAvionNavigation { get; set; }
        public virtual Pilote IdPiloteNavigation { get; set; }
        public virtual Trajet IdTrajetNavigation { get; set; }
    }
}
