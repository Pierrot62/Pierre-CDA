using System;
using System.Collections.Generic;

#nullable disable

namespace GestionGroupeDeMusique.Data.Models
{
    public partial class Groupe
    {
        public Groupe()
        {
            Musiciens = new HashSet<Musicien>();
        }

        public int IdGroupe { get; set; }
        public string NomDuGroupe { get; set; }
        public int NombreDeFollowers { get; set; }
        public string Logo { get; set; }

        public virtual ICollection<Musicien> Musiciens { get; set; }
    }
}
