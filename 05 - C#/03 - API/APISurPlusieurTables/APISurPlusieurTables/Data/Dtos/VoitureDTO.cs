using APISurPlusieurTables.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISurPlusieurTables.Data.Dtos
{
    public class VoitureDTO
    {
        public string ImmatriculationVoiture { get; set; }
        public int KilometrageVoiture { get; set; }
        public DateTime DateAchatVoiture { get; set; }
        //public List<Employer> ListEmployer { get; set; }
    }
}
