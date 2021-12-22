using AutoMapper;
using GestionGroupeDeMusique.Data;
using GestionGroupeDeMusique.Data.Dtos;
using GestionGroupeDeMusique.Data.Models;
using GestionGroupeDeMusique.Data.Profiles;
using GestionGroupeDeMusique.Data.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGroupeDeMusique.Controllers
{
    class GroupesController : ControllerBase
    {

        private readonly GroupesServices _service;
        private readonly IMapper _mapper;

        public GroupesController(EcfContext _context)
        {
            _service = new GroupesServices(_context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<GroupesProfiles>();
            });
            _mapper = config.CreateMapper();
        }

        //GET api/Groupes
        [HttpGet]
        public IEnumerable<GroupesDTOOut> GetAllGroupes()
        {
            IEnumerable<Groupe> listeGroupes = _service.GetAllGroupes();
            return _mapper.Map<IEnumerable<GroupesDTOOut>>(listeGroupes);
        }        
        
        //GET api/Groupes
        [HttpGet]
        public IEnumerable<GroupesDTOOut> GetAllGroupesAvecMusiciens()
        {
            IEnumerable<Groupe> listeGroupes = _service.GetAllGroupes();
            return _mapper.Map<IEnumerable<GroupesDTOOut>>(listeGroupes);
        }

        //GET api/Groupes/{i}
        [HttpGet("{id}", Name = "GetGroupeById")]
        public ActionResult<GroupesDTOOut> GetGroupeById(int id)
        {
            Groupe commandItem = _service.GetGroupeById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<GroupesDTOOut>(commandItem));
            }
            return NotFound();
        }

        //POST api/Groupes
        [HttpPost]
        public ActionResult<GroupesDTOIn> CreateGroupe(GroupesDTOIn objIn)
        {
            Groupe obj = _mapper.Map<Groupe>(objIn);
            _service.AddGroupe(obj);
            return CreatedAtRoute(nameof(GetGroupeById), new { Id = obj.IdGroupe }, obj);
        }

        //POST api/Groupes/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateGroupe(int id, GroupesDTOIn obj)
        {
            Groupe objFromRepo = _service.GetGroupeById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateGroupe(objFromRepo);
            return NoContent();
        }

        //DELETE api/Groupes/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteGroupe(int id)
        {
            Groupe obj = _service.GetGroupeById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteGroupe(obj);
            return NoContent();
        }


    }
}
