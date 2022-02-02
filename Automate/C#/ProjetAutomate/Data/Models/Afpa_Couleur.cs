using System;
using System.Collections.Generic;

#nullable disable

namespace ProjetAutomate.Data.Models
{
    public partial class Afpa_Couleur
    {
        public int IdCouleur { get; set; }
        public int? Red { get; set; }
        public int? Green { get; set; }
        public int? Blue { get; set; }
    }
}
