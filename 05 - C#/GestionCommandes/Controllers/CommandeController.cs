using AutoMapper;
using GestionCommandes.Data.Dtos;
using GestionCommandes.Data.Models;
using GestionCommandes.Data.Profiles;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionCommandes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandeController : ControllerBase
    {

        private readonly CommandeServices _service;
        private readonly IMapper _mapper;

        public CommandeController(CommandeServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Commande
        [HttpGet]
        public ActionResult<IEnumerable<CommandeDTOavecProduits>> GetAllCommande()
        {
            IEnumerable<Commande> listeCommande = _service.GetAllCommande();
            return Ok(_mapper.Map<IEnumerable<CommandeDTOavecProduits>>(listeCommande));
        }

        //GET api/Commande/{i}
        [HttpGet("{id}", Name = "GetCommandeById")]
        public ActionResult<CommandeDTOavecProduits> GetCommandeById(int id)
        {
            Commande commandItem = _service.GetCommandeById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<CommandeDTOavecProduits>(commandItem));
            }
            return NotFound();
        }

        //POST api/Commande
        [HttpPost]
        public ActionResult<CommandeDTO> CreateCommande(CommandeDTOIn objIn)
        {
            Commande obj = _mapper.Map<Commande>(objIn);
            _service.AddCommande(obj);
            return CreatedAtRoute(nameof(GetCommandeById), new { Id = obj.IdCommande }, obj);
        }

        //POST api/Commande/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateCommande(int id, CommandeDTOIn obj)
        {
            Commande objFromRepo = _service.GetCommandeById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateCommande(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Commande/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialCommandeUpdate(int id, JsonPatchDocument<Commande> patchDoc)
        {
            Commande objFromRepo = _service.GetCommandeById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Commande objToPatch = _mapper.Map<Commande>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateCommande(objFromRepo);
            return NoContent();
        }

        //DELETE api/Commande/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteCommande(int id)
        {
            Commande obj = _service.GetCommandeById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteCommande(obj);
            return NoContent();
        }


    }
}
