using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelToBase.Data
{
    public class Fruit
    {
        [Key]
        public int idFruit { get; set; }

        public string nomFruit { get; set; }
        public double prixFruit { get; set; }
        public double paysFruit { get; set; }
    }
}
