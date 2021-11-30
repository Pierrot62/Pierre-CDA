using System;
using System.Collections.Generic;

#nullable disable

namespace GestionAeroport.Data.Dtos
{
    public partial class AvionDTOIn
    {
        //public Avion()
        //{
        //    Vols = new HashSet<Vol>();
        //}

        public string Compagnie { get; set; }
        public string Type { get; set; }

    }

    public partial class AvionDTOOut
    {
        public int IdAvion { get; set; }
        public string Compagnie { get; set; }
        public string Type { get; set; }

    }
}
