using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CrudApiPersonnes.Models.DbModels
{
    public partial class Personne
    {
        [Key]
        public int Id { get; set; }

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
    }
}
