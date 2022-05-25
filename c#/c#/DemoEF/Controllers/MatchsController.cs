using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using DemoEF.Data.Dtos;
using DemoEF.Data.Models;
using DemoEF.Data.Services;
using DemoEF.Helpers;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoEF.Controllers
{
    [Route("api/Matchs")]
    [ApiController]
    public class MatchsController : ControllerBase
    {
        private readonly MatchsServices _service;
        private readonly IMapper _mapper;

        public MatchsController(MatchsServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Matchs
        [HttpGet]
        public ActionResult<IEnumerable<Matchs>> GetAllMatchs()
        {
            IEnumerable < Matchs > listeMatchs = _service.GetAllMatchs();
            return Ok(_mapper.Map<IEnumerable<MatchsDTO>>( listeMatchs));
        }
        //GET api/Matchs/{id}
        [HttpGet("{id}", Name = "GetMatchsById")]
        public ActionResult<MatchsDTO> GetMatchsById(int id)
        {
            var commandItem = _service.GetMatchsById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<MatchsDTO>(commandItem));
            }
            return NotFound();
        }

        //POST api/matchs
        [HttpPost]
        public ActionResult<MatchsDTO> CreateMatchs(Matchs match)
        {
            //on ajoute l’objet à la base de données
            _service.AddMatchs(match);
            //on retourne le chemin de findById avec l'objet créé
            return CreatedAtRoute(nameof(GetMatchsById), new { Id = match.id }, match);

        }


        //DELETE api/matchs/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteMatchs(int id)
        {
            var matchModelFromRepo = _service.GetMatchsById(id);
            if (matchModelFromRepo == null)
            {
                return NotFound();
            }
            _service.DeleteMatchs(matchModelFromRepo);

            return NoContent();
        }

    }

}

