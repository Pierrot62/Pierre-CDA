using System;
using System.Collections.Generic;

#nullable disable

namespace GestionAeroport.Data.Dtos
{
    public partial class PiloteDTOIn
    {
        //public Pilote()
        //{
        //    Vols = new HashSet<Vol>();
        //}
        public string Nom { get; set; }
        public string Prenom { get; set; }
    }

    public partial class PiloteDTOOut
    {
        public int IdPilote { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
    }
}


