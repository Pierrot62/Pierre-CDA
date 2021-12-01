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
    class TypesProduitController
    {

        private readonly TypesProduitServices _service;
        private readonly IMapper _mapper;

        public TypesProduitController(TypesProduitServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/TypesProduit
        [HttpGet]
        public ActionResult<IEnumerable<TypesProduitDTO>> GetAllTypesProduit()
        {
            IEnumerable<TypesProduit> listeTypesProduit = _service.GetAllTypesProduit();
            return Ok(_mapper.Map<IEnumerable<TypesProduitDTO>>(listeTypesProduit));
        }

        //GET api/TypesProduit/{i}
        [HttpGet("{id}", Name = "GetTypesProduitById")]
        public ActionResult<TypesProduitDTO> GetTypesProduitById(int id)
        {
            TypesProduit commandItem = _service.GetTypesProduitById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<TypesProduitDTO>(commandItem));
            }
            return NotFound();
        }

        //POST api/TypesProduit
        [HttpPost]
        public ActionResult<TypesProduitDTO> CreateTypesProduit(TypesProduitDTOIn objIn)
        {
            TypesProduit obj = _mapper.Map<TypesProduit>(objIn);
            _service.AddTypesProduit(obj);
            return CreatedAtRoute(nameof(GetTypesProduitById), new { Id = obj.IdTypesProduit }, obj);
        }

        //POST api/TypesProduit/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateTypesProduit(int id, TypesProduitDTOIn obj)
        {
            TypesProduit objFromRepo = _service.GetTypesProduitById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateTypesProduit(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/TypesProduit/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialTypesProduitUpdate(int id, JsonPatchDocument<TypesProduit> patchDoc)
        {
            TypesProduit objFromRepo = _service.GetTypesProduitById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            TypesProduit objToPatch = _mapper.Map<TypesProduit>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateTypesProduit(objFromRepo);
            return NoContent();
        }

        //DELETE api/TypesProduit/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteTypesProduit(int id)
        {
            TypesProduit obj = _service.GetTypesProduitById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteTypesProduit(obj);
            return NoContent();
        }


    }
}
