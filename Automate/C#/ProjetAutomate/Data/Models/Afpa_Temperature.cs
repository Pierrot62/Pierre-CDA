using System;
using System.Collections.Generic;

#nullable disable

namespace ProjetAutomate.Data.Models
{
    public partial class Afpa_Temperature
    {
        public int IdTemperature { get; set; }
        public float? ValeurTemperature { get; set; }
        public DateTime? DateTemperature { get; set; }
    }
}
