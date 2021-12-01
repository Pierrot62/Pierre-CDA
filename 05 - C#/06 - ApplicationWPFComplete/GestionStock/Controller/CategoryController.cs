using AutoMapper;
using GestionStock.Data.Models;
using GestionStock.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Controller
{
    class CategoryController
    {

        private readonly CategoryServices _service;
        private readonly IMapper _mapper;

        public CategoryController(CategoryServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Category
        [HttpGet]
        public ActionResult<IEnumerable<CategoryDTO>> GetAllCategory()
        {
            IEnumerable<Category> listeCategory = _service.GetAllCategory();
            return Ok(_mapper.Map<IEnumerable<CategoryDTO>>(listeCategory));
        }

        //GET api/Category/{i}
        [HttpGet("{id}", Name = "GetCategoryById")]
        public ActionResult<CategoryDTO> GetCategoryById(int id)
        {
            Category commandItem = _service.GetCategoryById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<CategoryDTO>(commandItem));
            }
            return NotFound();
        }

        //POST api/Category
        [HttpPost]
        public ActionResult<CategoryDTO> CreateCategory(CategoryDTOIn objIn)
        {
            Category obj = _mapper.Map<Category>(objIn);
            _service.AddCategory(obj);
            return CreatedAtRoute(nameof(GetCategoryById), new { Id = obj.IdCategory }, obj);
        }

        //POST api/Category/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateCategory(int id, CategoryDTOIn obj)
        {
            Category objFromRepo = _service.GetCategoryById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateCategory(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Category/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialCategoryUpdate(int id, JsonPatchDocument<Category> patchDoc)
        {
            Category objFromRepo = _service.GetCategoryById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Category objToPatch = _mapper.Map<Category>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateCategory(objFromRepo);
            return NoContent();
        }

        //DELETE api/Category/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteCategory(int id)
        {
            Category obj = _service.GetCategoryById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteCategory(obj);
            return NoContent();
        }


    }
}
