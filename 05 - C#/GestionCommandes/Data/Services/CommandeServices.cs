using GestionCommandes.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionCommandes.Data.Profiles
{
    public class CommandeServices
    {

        private readonly GestionCommandeContext _context;

        public CommandeServices(GestionCommandeContext context)
        {
            _context = context;
        }

        public void AddCommande(Commande obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Commandes.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteCommande(Commande obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Commandes.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Commande> GetAllCommande()
        {
            return _context.Commandes.ToList();
        }

        public Commande GetCommandeById(int id)
        {
            return _context.Commandes.FirstOrDefault(obj => obj.IdCommande == id);
        }

        public void UpdateCommande(Commande obj)
        {
            _context.SaveChanges();
        }


    }
}
