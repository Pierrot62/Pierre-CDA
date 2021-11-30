using System;
using System.Collections.Generic;

#nullable disable

namespace GestionAeroport.Data.Dtos
{
    public partial class TrajetDTOIn
    {
        //public Trajet()
        //{
        //    Vols = new HashSet<Vol>();
        //}

        public string AeroportArrivee { get; set; }
        public string AeroportDepart { get; set; }
        public TimeSpan DureeVol { get; set; }
    }

    public partial class TrajetDTOOut
    {
        //public Trajet()
        //{
        //    Vols = new HashSet<Vol>();
        //}
        public int IdTrajet { get; set; }
        public string AeroportArrivee { get; set; }
        public string AeroportDepart { get; set; }
        public TimeSpan DureeVol { get; set; }
    }

}
