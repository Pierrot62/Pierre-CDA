using GestionStock.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Data.Services
{
    class TypesProduitServices
    {

        private readonly MyDbContext _context;

        public TypesProduitServices(MyDbContext context)
        {
            _context = context;
}

        public void AddTypesProduit(TypesProduit obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.TypesProduits.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteTypesProduit(TypesProduit obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.TypesProduits.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<TypesProduit> GetAllTypesProduit()
        {
            return _context.TypesProduits.ToList();
        }

        public TypesProduit GetTypesProduitById(int id)
        {
            return _context.TypesProduits.FirstOrDefault(obj => obj.IdTypesProduits == id);
        }

        public void UpdateTypesProduit(TypesProduit obj)
        {
            _context.SaveChanges();
        }


    }
}
