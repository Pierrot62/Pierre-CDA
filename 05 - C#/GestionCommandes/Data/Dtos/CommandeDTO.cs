using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionCommandes.Data.Dtos
{
    public class CommandeDTO
    {
        public int IdCommande { get; set; }
        public DateTime DateCommande { get; set; }
        public int NumeroCommande { get; set; }
    }

    public class CommandeDTOIn
    {
        public DateTime DateCommande { get; set; }
        public int NumeroCommande { get; set; }
    }
}
