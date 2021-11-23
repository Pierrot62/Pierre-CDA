using APISurPlusieurTables.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISurPlusieurTables.Data.Services
{
    public class EmployerServices
    {
        private readonly MyDbContext _context;
        public EmployerServices(MyDbContext context)
        {
            _context = context;
        }

        //Add
        public void AddEmployer(Employer e)
        {
            if (e == null)
            {
                throw new ArgumentNullException(nameof(e));
            }
            _context.Employer.Add(e);
            _context.SaveChanges();
        }

        //Delete
        public void DeleteEmployer(Employer e)
        {
            if (e == null)
            {
                throw new ArgumentNullException(nameof(e));
            }
            _context.Employer.Add(e);
            _context.SaveChanges();
        }

        //FindAll
        public IEnumerable<Employer> GetAllEmployer()
        {
            return _context.Employer.ToList();
        }

        //FindById
        public Employer GetEmployerById(int id)
        {
            return _context.Employer.FirstOrDefault(e => e.IdEmployer == id);
        }

        //Update
        public void UpdateEmployer(Employer e)
        {

            _context.SaveChanges();
        }

    }
}
