using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAutomate.Data.Dtos
{
    public class Afpa_TemperaturesDTOIn
    {
        public float? ValeurTemperature { get; set; }
        public DateTime? DateTemperature { get; set; }
    }

    public class Afpa_TemperaturesDTOOut
    {
        public float? ValeurTemperature { get; set; }
        public DateTime? DateTemperature { get; set; }
    }
}
