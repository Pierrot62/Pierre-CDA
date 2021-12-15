using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace APISurPlusieurTables.Data.Models
{
    public partial class Voiture
    {
        [Key]
        public int IdVoiture { get; set; }

        public string ImmatriculationVoiture { get; set; }
        public int KilometrageVoiture { get; set; }
        public DateTime DateAchatVoiture { get; set; }
    }
}