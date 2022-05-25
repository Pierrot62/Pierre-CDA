using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DemoEF.Data.Models
{
    public partial class Matchs
    {
        [Key]
        public int id { get; set; }

        public string numero_match { get; set; }
        public DateTime date_heure_match { get; set; }
        public int numero_journee { get; set; }
        public string categorie_equipe_local { get; set; }
        public string score_match { get; set; }
        public string equipe_local { get; set; }
        public string equipe_adverse { get; set; }
        public string lieu_match { get; set; }
        public string lien_feuille_de_match { get; set; }

    }
}
