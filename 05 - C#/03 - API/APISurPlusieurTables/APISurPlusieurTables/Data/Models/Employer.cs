using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace APISurPlusieurTables.Data.Models
{
    public partial class Employer
    {
        [Key]
        public int IdEmployer { get; set; }

        public string NomEmployer { get; set; }
        public string PrenomEmployer { get; set; }
        public int AgeEmployer { get; set; }
    }
}
