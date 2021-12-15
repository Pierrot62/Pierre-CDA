using GestionStock.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Data.Services
{
    class CategoryServices
    {

        private readonly MyDbContext _context;

        public CategoryServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddCategory(Category obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Categories.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteCategory(Category obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Categories.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Category> GetAllCategory()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.FirstOrDefault(obj => obj.IdCategories == id);
        }

        public void UpdateCategory(Category obj)
        {
            _context.SaveChanges();
        }


    }
}
