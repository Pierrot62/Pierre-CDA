using APISurPlusieurTables.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISurPlusieurTables.Data.Dtos
{
    public class EmployerDTO
    {
        public string NomEmployer { get; set; }
        public string PrenomEmployer { get; set; }
        public int AgeEmployer { get; set; }
        //Ajout de la class voitue a l'employé
        public Voiture Tuture { get; set; }

    }
}
