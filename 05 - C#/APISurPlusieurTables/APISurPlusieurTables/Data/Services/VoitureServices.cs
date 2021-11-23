using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISurPlusieurTables.Data.Services
{
    public class VoitureServices
    {
        private readonly MyDbContext _context;
        public VoitureServices(MyDbContext context)
        {
            _context = context;
        }

        //Add
        public void AddVoiture(Voiture v)
        {
            if (v == null)
            {
                throw new ArgumentNullException(ne)
            }
        }
    }
}
