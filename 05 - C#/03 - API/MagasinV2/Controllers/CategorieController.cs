using AutoMapper;
using Magasin.Data.Dtos;
using Magasin.Data.Models;
using Magasin.Data.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magasin.Controllers
{
    //URL Permettant d'arriver sur le controller
    [Route("api/Categorie")]
    [ApiController]

    public class CategorieController : ControllerBase
    {

        private readonly CategorieServices _service;
        private readonly IMapper _mapper;

        public CategorieController(CategorieServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Categorie
        [HttpGet]
        public ActionResult<IEnumerable<CategorieDTO>> GetAllCategorie()
        {
            IEnumerable<Categorie> listeCategorie = _service.GetAllCategorie();
            return Ok(_mapper.Map<IEnumerable<CategorieDTO>>(listeCategorie));
        }

        //GET api/Categorie/{i}
        [HttpGet("{id}", Name = "GetCategorieById")]
        public ActionResult<CategorieDTO> GetCategorieById(int id)
        {
            Categorie commandItem = _service.GetCategorieById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<CategorieDTOIn>(commandItem));
            }
            return NotFound();
        }

        //POST api/Categorie
        [HttpPost]
        public void CreateCategorie(CategorieDTOIn obj)
        {
            _service.AddCategorie(obj);
            //return NoContent();
        }

        //POST api/Categorie/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateCategorie(int id, CategorieDTO obj)
        {
            Categorie objFromRepo = _service.GetCategorieById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateCategorie(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]

        //PATCH api/Categorie/{id}
        //[HttpPatch("{id}")]
        //public ActionResult PartialCategorieUpdate(int id, JsonPatchDocument<Categorie> patchDoc)
        //{
        //    Categorie objFromRepo = _service.GetCategorieById(id);
        //    if (objFromRepo == null)
        //    {
        //        return NotFound();
        //    }
        //    Categorie objToPatch = _mapper.Map<Categorie>(objFromRepo);
        //    patchDoc.ApplyTo(objToPatch, ModelState);
        //    if (!TryValidateModel(objToPatch))
        //    {
        //        return ValidationProblem(ModelState);
        //    }
        //    _mapper.Map(objToPatch, objFromRepo);
        //    _service.UpdateCategorie(objFromRepo);
        //    return NoContent();
        //}

        //DELETE api/Categorie/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteCategorie(int id)
        {
            Categorie obj = _service.GetCategorieById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteCategorie(obj);
            return NoContent();
        }


    }
}
